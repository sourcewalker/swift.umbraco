using umbraco.businesslogic;
using umbraco.interfaces;

namespace Swift.Umbraco.Web.App_Plugins.Tools.Application
{
    [Application(
        alias: "tools",
        name: "Tools",
        icon: "icon-wrench",
        sortOrder: 15)]
    public class ToolsSection : IApplication { }
}