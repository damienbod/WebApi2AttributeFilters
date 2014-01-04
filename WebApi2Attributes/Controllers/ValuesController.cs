using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using WebApi2Attributes.Attributes;

namespace WebApi2Attributes.Controllers
{
    [Class1DebugActionWebApiFilter]
    [Class2DebugActionWebApiFilter]
    [RoutePrefix("api/MyExamples")] 
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Basic filters class and then action
        /// </summary>
        /// <returns></returns>
        [Route("test1")]
        [AcceptVerbs("GET")]
        [Action1DebugActionWebApiFilter]
        public IEnumerable<string> UsesBothAttributes()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Framework OverrideActionFiltersAttribute turns off class filters of type IActionFilter
        /// </summary>
        /// <returns></returns>
        [Route("test2")]
        [AcceptVerbs("GET")]
        [Action1DebugActionWebApiFilter]
        [OverrideActionFiltersAttribute]
        public IEnumerable<string> UsesJustActionDebugAttribute()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// MyOverrideDebugActionWebApiFilter turns off class filters of type IActionFilter
        /// </summary>
        /// <returns></returns>
        [Route("test3")]
        [AcceptVerbs("GET")]
        [Action1DebugActionWebApiFilter]
        [MyOverrideDebugActionWebApiFilter]
        [Action2DebugActionWebApiFilter]
        public IEnumerable<string> UseActionOverrideActionDebugAttribute()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Class filters are wrapped around action filters
        /// </summary>
        /// <returns></returns>
        [Route("test4")]
        [AcceptVerbs("GET")]
        [Action1DebugActionWebApiFilter]
        [Action2DebugActionWebApiFilter]
        [Action3DebugActionWebApiFilter]
        [Action4DebugActionWebApiFilter]
        public IEnumerable<string> Use4ActionsDebugAttribute()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Class filters are wrapped around action filters
        /// </summary>
        /// <returns></returns>
        [RouteAttribute("test5/{data}")]
        [AcceptVerbs("GET")]
        [ActionEditDataDebugActionWebApiFilter]
        public IEnumerable<string> Use4ActionsDebugAttribute(string data)
        {
            return new string[] { "value1", data };
        }

        [PropertyInjectionDebugActionWebApiFilter]
        [RouteAttribute("test6")]
        [AcceptVerbs("GET")]
        [ActionEditDataDebugActionWebApiFilter]
        public IEnumerable<string> PropertyInjectionAttributeActionsDebugAttribute()
        {
            return new string[] { "value1" };
        }
    }
}
