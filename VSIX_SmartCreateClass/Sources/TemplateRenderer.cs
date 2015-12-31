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

namespace SmartCreateClass.Sources
{
    internal class TemplateRenderer
    {
        private static readonly string COCOS_2D_NODE_CPP = @"# include ""$HEADER_PATH$""

USING_NS_CC;

bool $CLASS_NAME$::init() {
    if (!Node::init())
    {
        return false;
    }

    return true;
}";

        private static readonly string COCOS_2D_NODE_HPP = @"#pragma once

#include <cocos2d/cocos/2d/CCNode.h>

class $CLASS_NAME$ : public cocos2d::Node {
public:
	CREATE_FUNC($CLASS_NAME$);

	bool init() override;
};
";
        private static readonly string EMPTY_CLASS_CPP = @"#include ""$HEADER_PATH$""

$CLASS_NAME$::$CLASS_NAME$() {
    
}
";

        private static readonly string EMPTY_CLASS_HPP = @"#pragma once

class $CLASS_NAME$ {
public:
    $CLASS_NAME$();
};
";

        private static readonly string EMPTY_FILE_CPP = @"#include ""$HEADER_PATH$""
";

        private static readonly string EMPTY_FILE_HPP = @"#pragma once

";

        public RenderResult RenderTemplate(ClassType classType, TemplateContext context)
        {
            switch (classType)
            {
                case ClassType.COCOS_2D_NODE:
                    return RenderTemplate(COCOS_2D_NODE_HPP, COCOS_2D_NODE_CPP, context);
                case ClassType.EMPTY_CLASS:
                    return RenderTemplate(EMPTY_CLASS_HPP, EMPTY_CLASS_CPP, context);
                case ClassType.EMPTY_FILES:
                    return RenderTemplate(EMPTY_FILE_HPP, EMPTY_FILE_CPP, context);
            }

            return null;
        }

        private RenderResult RenderTemplate(string hppTemplate, string cppTemplate, TemplateContext context)
        {
            return new RenderResult(ReplaceVariables(hppTemplate, context), ReplaceVariables(cppTemplate, context));
        }

        private string ReplaceVariables(string content, TemplateContext context)
        {
            return content
                .Replace("$HEADER_PATH$", context.HeaderPath)
                .Replace("$CLASS_NAME$", context.ClassName);
        }

        public class RenderResult
        {
            public RenderResult(string header, string source)
            {
                Header = header;
                Source = source;
            }

            public string Header { get; set; }
            public string Source { get; set; }
        }
    }
}