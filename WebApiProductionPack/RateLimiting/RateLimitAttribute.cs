using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebApiProductionPack.RateLimiting
{
    public class RateLimitAttribute : AuthorizeAttribute
    {
        public string[] Scope { get; set; }
        public int Rate { get; set; }
        public int RefreshWindow { get; set; }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            return true;
        }
    }
}
