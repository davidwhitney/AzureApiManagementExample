using System;

namespace WebApiProductionPack
{
    public class WebApiProductionPackConfiguration
    {
        public IpFilterConfiguration IpFilterCfg { get; set; }
        public object StatisticsCfg { get; set; }
        public object RateLimitCfg { get; set; }

        public WebApiProductionPackConfiguration IpFilter(Action<IpFilterConfiguration> action)
        {
            action(IpFilterCfg);
            return this;
        }

        public WebApiProductionPackConfiguration RateLimit(Action<object> action)
        {
            action(RateLimitCfg);
            return this;
        }

        public WebApiProductionPackConfiguration TrackUsage(Action<object> action)
        {
            action(StatisticsCfg);
            return this;
        }
    }
}
