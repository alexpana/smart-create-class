//DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//            Version 2, December 2004 
//
// Copyright(C) 2004 Sam Hocevar<sam@hocevar.net>
//
//
//Everyone is permitted to copy and distribute verbatim or modified
//
//copies of this license document, and changing it is allowed as long
// as the name is changed.
//
//           DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//  TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION
//
//  0. You just DO WHAT THE FUCK YOU WANT TO.

using System;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices;
using EnvDTE80;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using SmartCreateClass.Properties;

namespace SmartCreateClass.Sources
{
    internal sealed class SmartCreateClassCommand
    {
        public const int CommandId = 0x0100;

        public static readonly Guid CommandSet = new Guid("6271ddce-e0ab-4cb3-9340-c8aa2d5cea21");

        private readonly DTE2 dte;

        private readonly Package package;

        private readonly TemplateRenderer templateRenderer;

        private SmartCreateClassCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            dte = Package.GetGlobalService(typeof (SDTE)) as DTE2;

            templateRenderer = new TemplateRenderer();

            var commandService = ServiceProvider.GetService(typeof (IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new OleMenuCommand(MenuItemCallback, menuCommandID);
                menuItem.BeforeQueryStatus += menuCommand_BeforeQueryStatus;

                commandService.AddCommand(menuItem);
            }
        }

        public static SmartCreateClassCommand Instance { get; private set; }

        private IServiceProvider ServiceProvider
        {
            get { return package; }
        }

        private void menuCommand_BeforeQueryStatus(object sender, EventArgs e)
        {
            // get the menu that fired the event
            var menuCommand = sender as OleMenuCommand;
            if (menuCommand != null)
            {
                // start by assuming that the menu will not be shown
                menuCommand.Visible = menuCommand.Enabled = false;

                IVsHierarchy hierarchy = null;
                var itemid = VSConstants.VSITEMID_NIL;

                if (!IsSingleProjectItemSelection(out hierarchy, out itemid)) return;

                menuCommand.Visible = menuCommand.Enabled = true;
                menuCommand.Enabled = true;
            }
        }

        public static void Initialize(Package package)
        {
            Instance = new SmartCreateClassCommand(package);
        }

        private void MenuItemCallback(object sender, EventArgs e)
        {
            var menuCommand = sender as OleMenuCommand;


            IVsHierarchy hierarchy = null;
            var itemid = VSConstants.VSITEMID_NIL;

            if (!IsSingleProjectItemSelection(out hierarchy, out itemid)) return;

            // Get the file path
            string selectedFilterPath = null;
            hierarchy.GetCanonicalName(itemid, out selectedFilterPath);

            var solutionDirectory = GetSolutionDir();

            var CreateClassForm = new ClassSelectionForm(solutionDirectory, selectedFilterPath, onCreate);
            CreateClassForm.ShowDialog();
        }

        private void onCreate(string className, string path, ClassType classType)
        {
            try
            {
                // create directory if doesn't exist
                Directory.CreateDirectory(path);

                // write file contents
                var templateRender = templateRenderer.RenderTemplate(classType,
                    new TemplateContext(className + ".h", className));

                var headerPath = Path.Combine(path, className + ".h");
                File.Create(headerPath).Close();
                File.WriteAllText(headerPath, templateRender.Header);

                var sourcePath = Path.Combine(path, className + ".cpp");
                File.Create(sourcePath).Close();
                File.WriteAllText(sourcePath, templateRender.Source);

                // Add files to solution
                var solutionService = Package.GetGlobalService(typeof (SVsSolution)) as IVsSolution;
                var guidProjectID = Guid.Empty;

                var project = dte.SelectedItems.Item(1).ProjectItem.ContainingProject;

                var headerItem = dte.SelectedItems.Item(1).ProjectItem.ProjectItems.AddFromFile(headerPath);
                var sourceItem = dte.SelectedItems.Item(1).ProjectItem.ProjectItems.AddFromFile(sourcePath);

                var firstItem = dte.SelectedItems.Item(1).ProjectItem.ProjectItems.Item(1);

                project.Save();
            }
            catch (Exception e)
            {
                ShowMessage(e.Message, "Exception");
            }
        }

        private static string GetSolutionDir()
        {
            var solutionService = Package.GetGlobalService(typeof (SVsSolution)) as IVsSolution;
            object solutionDirectory;
            solutionService.GetProperty((int) __VSPROPID.VSPROPID_SolutionDirectory, out solutionDirectory);

            return solutionDirectory as string;
        }

        private IVsHierarchy GetSelectedHierarchy()
        {
            var monitorSelection = Package.GetGlobalService(typeof (SVsShellMonitorSelection)) as IVsMonitorSelection;

            IVsMultiItemSelect multiItemSelect = null;
            var hierarchyPtr = IntPtr.Zero;
            var selectionContainerPtr = IntPtr.Zero;
            var itemid = VSConstants.VSITEMID_NIL;

            var hr = monitorSelection.GetCurrentSelection(out hierarchyPtr, out itemid, out multiItemSelect,
                out selectionContainerPtr);

            if (hierarchyPtr != IntPtr.Zero)
            {
                var hierarchy = Marshal.GetObjectForIUnknown(hierarchyPtr) as IVsHierarchy;
                Marshal.Release(hierarchyPtr);
                return hierarchy;
            }

            return null;
        }

        private bool IsSingleProjectItemSelection(out IVsHierarchy hierarchy, out uint itemid)
        {
            hierarchy = null;
            itemid = VSConstants.VSITEMID_NIL;
            var hr = VSConstants.S_OK;

            var monitorSelection = Package.GetGlobalService(typeof (SVsShellMonitorSelection)) as IVsMonitorSelection;

            var solution = Package.GetGlobalService(typeof (SVsSolution)) as IVsSolution;

            if (monitorSelection == null || solution == null)
            {
                return false;
            }

            IVsMultiItemSelect multiItemSelect = null;
            var hierarchyPtr = IntPtr.Zero;
            var selectionContainerPtr = IntPtr.Zero;

            try
            {
                hr = monitorSelection.GetCurrentSelection(out hierarchyPtr, out itemid, out multiItemSelect,
                    out selectionContainerPtr);

                if (ErrorHandler.Failed(hr) || hierarchyPtr == IntPtr.Zero || itemid == VSConstants.VSITEMID_NIL)
                {
                    return false;
                }

                if (multiItemSelect != null) return false;

                if (itemid == VSConstants.VSITEMID_ROOT) return false;

                hierarchy = Marshal.GetObjectForIUnknown(hierarchyPtr) as IVsHierarchy;
                if (hierarchy == null) return false;

                var guidProjectID = Guid.Empty;

                if (ErrorHandler.Failed(solution.GetGuidOfProject(hierarchy, out guidProjectID)))
                {
                    // hierarchy is not a project inside the Solution if it does not have a ProjectID Guid
                    return false;
                }

                return true;
            }
            finally
            {
                if (selectionContainerPtr != IntPtr.Zero)
                {
                    Marshal.Release(selectionContainerPtr);
                }

                if (hierarchyPtr != IntPtr.Zero)
                {
                    Marshal.Release(hierarchyPtr);
                }
            }
        }

        private void ShowMessage(string message, string title)
        {
            VsShellUtilities.ShowMessageBox(
                ServiceProvider,
                message,
                title,
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }
    }
}