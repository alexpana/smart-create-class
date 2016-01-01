Smart Create Class for C++
==========================
This extension allows the user to create c++ classes by using the context menu in the solution explorer. The classes are created in the folder represented by the filter hierarchy.

Usage
=====
1. Use the context menu to open up the class creation dialog.
![Contextual menu for adding classes](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step1.png)

2. Select the class template. Available templates are: cocos2d Node, empty class or empty files.
![Create class dialog](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step2.png)

3. The header / source files are generated in the correct directory and added to the solution.
![Result](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/step3.png)

Settings
========
To change the way the output path is calculated, you can use the settings window. It can be accessed via **Tools > Smart Create Class Settings** or via the **Settings** link in the Create Class window.

![The settings window](https://raw.githubusercontent.com/alexpana/smart-create-class/master/images/settings.png)

The output path is calculated as follows:

1. Use the skip filters count to trim the filter hierarchy. For example: using the hierarchy **SourceFiles\CPP\Entities\Obstacles** and a skip count of **2**, the result is **Entities\Obstacles**
2. Use the prefix hierarchy path with the trimmed hierarchy. For example: using the trimmed hierarchy **Entities\Obstacles** and the prefix **Sources**, the result is **Sources\Entities\Obstacles**
3. The **Solution Directory** is concatenated with the previous prefixed and trimmed hierarchy path to create the final path.
