using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Attributes.Attributes;

namespace WebApi2Attributes.Controllers
{
    [Class1DebugActionWebApiFilter]
    [RoutePrefix("api/T2")] 
    public class Values2Controller : BaseController
    {
        [Action1DebugActionWebApiFilter]
        [Route("parent")]
        public IEnumerable<string> GetParent()
        {
            return new string[] { "value1", "value2" };
        }

        [Action1DebugActionWebApiFilter]
        [OverrideActionFiltersAttribute]
        [Route("parent2")]
        public IEnumerable<string> GetParentOverride()
        {
            return new string[] { "value1", "value2" };
        }


    }
}