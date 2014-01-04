using System.Diagnostics;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApi2Attributes.Attributes
{
    public class Class1DebugActionWebApiFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // pre-processing
            Debug.WriteLine("CLASS 1 DEBUG pre-processing logging");
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var objectContent = actionExecutedContext.Response.Content as ObjectContent;
            if (objectContent != null)
            {
                var type = objectContent.ObjectType; //type of the returned object
                var value = objectContent.Value; //holding the returned value
            }

            Debug.WriteLine("CLASS 1 DEBUG OnActionExecuted Response " + actionExecutedContext.Response.StatusCode.ToString());
        }
    }
}