using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace WebApi2Attributes.Attributes
{
    public class MyOverrideDebugActionWebApiFilter : ActionFilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get
            {
                return typeof(IActionFilter);
            }
        }
    }
}