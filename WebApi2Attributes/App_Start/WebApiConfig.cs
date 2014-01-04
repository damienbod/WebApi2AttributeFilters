using System.Web.Http;
using Microsoft.Practices.Unity.WebApi;
using WebApi2Attributes.App_Start;

namespace WebApi2Attributes
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.DependencyResolver = new UnityDependencyResolver(UnityConfig.GetConfiguredContainer());
 
            // Web API routes
            config.MapHttpAttributeRoutes();

            WebApiUnityActionFilterProvider.RegisterFilterProviders(config);

        }
    }
}
