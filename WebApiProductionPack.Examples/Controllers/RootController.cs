using System.Web.Http;
using WebApiProductionPack.Examples.Models.Root;

namespace WebApiProductionPack.Examples.Controllers
{
    public class RootController : ApiController
    {
        [HttpGet]
        [Route("")]
        public RootResult Get()
        {
            return new RootResult();
        }
    }
}