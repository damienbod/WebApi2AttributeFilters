using System;
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