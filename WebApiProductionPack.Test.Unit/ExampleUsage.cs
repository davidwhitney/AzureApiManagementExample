using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebApiProductionPack.Test.Unit
{
    [TestFixture]
    public class ExampleUsage
    {
        [Test]
        public void A()
        {
            WebApiProductionPackConfig.EnableIpFilter(filterCfg => filterCfg.);
        }
    }
}
