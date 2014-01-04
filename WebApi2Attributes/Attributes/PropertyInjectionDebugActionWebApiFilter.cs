using System.Diagnostics;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Microsoft.Practices.Unity;

namespace WebApi2Attributes.Attributes
{
    public class PropertyInjectionDebugActionWebApiFilter : ActionFilterAttribute
    {
        [Dependency]
        internal IDummyBusinessClass MyDummyBusinessClass { get; set; }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Debug.WriteLine("ACTION 1 DEBUG pre-processing logging and IoC:" + MyDummyBusinessClass.GetSomething());
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var objectContent = actionExecutedContext.Response.Content as ObjectContent;
            if (objectContent != null)
            {
                var type = objectContent.ObjectType; //type of the returned object
                var value = objectContent.Value; //holding the returned value
            }

            Debug.WriteLine("ACTION 1 DEBUG  OnActionExecuted Response " + actionExecutedContext.Response.StatusCode.ToString());
        }
    }
}