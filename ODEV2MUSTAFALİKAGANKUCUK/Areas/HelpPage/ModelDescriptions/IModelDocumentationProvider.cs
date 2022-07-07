using System;
using System.Reflection;

namespace ODEV2MUSTAFALİKAGANKUCUK.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}