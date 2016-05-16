using System.Web.Http;
using Owin;
using Swashbuckle.Application;

namespace WebApiProductionPack.Examples
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();
            WebApiConfig.Register(httpConfiguration);
            appBuilder.UseWebApi(httpConfiguration);

            httpConfiguration
                .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
                .EnableSwaggerUi();


            WebApiProductionPack.Configure
                .IpFilter(c =>
                {
                    c.EnableGloballyFor("192.168.0.1");
                    // c.EnforceAttributeFilters();
                    // c.EnableGloballyFrom(new WebConfigProvider());
                })
                .RateLimit(c =>
                {

                })
                .TrackUsage(c =>
                {
                    //c.EnableDashboard("/stats");
                    //c.StoreSettingsIn(new InMemoryProvider());
                });


        }
    }
}