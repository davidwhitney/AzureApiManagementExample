using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace WebApiProductionPack.IpFiltering
{
    public class IpFilterMiddleware : OwinMiddleware
    {
        public IpFilterMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            if (context.IsIpAllowed())
            {
                await Next.Invoke(context);
            }

            context.Response.StatusCode = 403;
        }
    }
}
