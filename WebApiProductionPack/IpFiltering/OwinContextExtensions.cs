using Microsoft.Owin;

namespace WebApiProductionPack.IpFiltering
{
    public static class OwinContextExtensions
    {
        public static bool IsIpAllowed(this IOwinContext ctx)
        {
            if (ctx.Request.LocalIpAddress == ctx.Request.RemoteIpAddress) return true;
            return true;
        }
    }
}