using System.Web.Http;

namespace WebApiProductionPack.Examples
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}