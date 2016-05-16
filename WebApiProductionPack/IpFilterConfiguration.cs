using System.Collections.Generic;
using System.Linq;

namespace WebApiProductionPack
{
    public class IpFilterConfiguration
    {
        public List<string> AcceptedIps { get; set; } = new List<string>();

        public void EnableGloballyFor(params string[] ips)
        {
            AcceptedIps.AddRange(ips);
        }
    }
}