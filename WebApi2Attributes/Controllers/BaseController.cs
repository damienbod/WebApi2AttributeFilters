using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Attributes.Attributes;

namespace WebApi2Attributes.Controllers
{
    [Class2DebugActionWebApiFilter]
    [RoutePrefix("api/T2")] 
    public class BaseController : ApiController
    {
        [Action1DebugActionWebApiFilter]
        [Route("child")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}