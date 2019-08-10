using System;
using Umbraco.Web;

namespace Swift.Umbraco.Web
{
    public class WebApplication : UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            base.OnApplicationStarting(sender, e);
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
        }
    }
}