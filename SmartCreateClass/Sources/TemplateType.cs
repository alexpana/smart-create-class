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
    public enum TemplateType
    {
        Cocos2DNode,
        EmptyClass,
        EmptyHeaderSourcePair,
        EmptyHeader
    }

    internal class TemplateTraits
    {
        public readonly bool HasSourceFile;

        public TemplateTraits(bool hasSourceFile)
        {
            HasSourceFile = hasSourceFile;
        }

        public static TemplateTraits ForType(TemplateType templateType)
        {
            switch (templateType)
            {
                case TemplateType.Cocos2DNode:
                    return new TemplateTraits(true);
                case TemplateType.EmptyClass:
                    return new TemplateTraits(true);
                case TemplateType.EmptyHeaderSourcePair:
                    return new TemplateTraits(true);
                case TemplateType.EmptyHeader:
                    return new TemplateTraits(false);
            }

            return null;
        }
    }
}