using System;
using System.Reflection;

namespace Rad302SummerWebAPIdmulligan.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}