using System;
using System.Web.Http;

namespace Api.Controllers
{
    public class RootController : ApiController
    {
        [HttpGet]
        [Route("")]
        public Result Get()
        {
            return new Result();
        }
    }

    public class Result
    {
        public Guid Id { get; set; }

        public Result()
        {
            Id = Guid.NewGuid();
        }
    }
}