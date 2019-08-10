using Hangfire;
using Swift.Umbraco.Web.Infrastructure.Filters;
using Owin;
using Umbraco.Web;
using UmbracoCore = Umbraco.Core;

namespace Swift.Umbraco.Web
{
    public class Startup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);

            //var connectionString = UmbracoCore.ApplicationContext.Current.DatabaseContext.ConnectionString;
            //GlobalConfiguration.Configuration.UseSqlServerStorage(connectionString);

            //var dashboardOptions = new DashboardOptions
            //{
            //    Authorization = new[]
            //    {
            //        new UmbracoAuthorizationFilter()
            //    }
            //};

            //app.UseHangfireDashboard("/umbraco/backoffice/Plugins/hangfire", dashboardOptions);
            //app.UseHangfireServer();
        }
    }
}