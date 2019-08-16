using umbraco.businesslogic;
using umbraco.interfaces;

namespace Trebor.Cash.In.Flash.Web.App_Plugins.Tools.Application
{
    [Application(
        alias: "tools",
        name: "Tools",
        icon: "icon-wrench",
        sortOrder: 15)]
    public class ToolsSection : IApplication { }
}