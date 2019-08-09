using Hangfire;
using Owin;
using Trebor.Cash.In.Flash.Infrastructure.Filters;
using Umbraco.Web;

namespace Trebor.Cash.In.Flash
{
    public class Startup : UmbracoDefaultOwinStartup
    {
        public override void Configuration(IAppBuilder app)
        {
            base.Configuration(app);

            var connectionString = Umbraco.Core.ApplicationContext.Current.DatabaseContext.ConnectionString;
            GlobalConfiguration.Configuration.UseSqlServerStorage(connectionString);

            var dashboardOptions = new DashboardOptions
            {
                Authorization = new[]
                {
                    new UmbracoAuthorizationFilter()
                }
            };

            app.UseHangfireDashboard("/umbraco/backoffice/Plugins/hangfire", dashboardOptions);
            app.UseHangfireServer();
        }
    }
}