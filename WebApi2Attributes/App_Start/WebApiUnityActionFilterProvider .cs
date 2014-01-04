using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Microsoft.Practices.Unity;

namespace WebApi2Attributes.App_Start
{
    public class WebApiUnityActionFilterProvider : ActionDescriptorFilterProvider, IFilterProvider
    {
        private readonly IUnityContainer container;

        public WebApiUnityActionFilterProvider(IUnityContainer container)
        {
            this.container = container;
        }

        public new IEnumerable<FilterInfo> GetFilters(HttpConfiguration configuration, HttpActionDescriptor actionDescriptor)
        {
            var filters = base.GetFilters(configuration, actionDescriptor);
            var filterInfoList = new List<FilterInfo>();

            foreach (var filter in filters)
            {
                container.BuildUp(filter.Instance.GetType(), filter.Instance);
            }

            return filters;
        }

        public  static void RegisterFilterProviders(HttpConfiguration config)
        {
            // Add Unity filters provider
            var providers = config.Services.GetFilterProviders().ToList();
            config.Services.Add(typeof(System.Web.Http.Filters.IFilterProvider), new WebApiUnityActionFilterProvider(UnityConfig.GetConfiguredContainer()));
            var defaultprovider = providers.First(p => p is ActionDescriptorFilterProvider);
            config.Services.Remove(typeof(System.Web.Http.Filters.IFilterProvider), defaultprovider);
        }
    }
}