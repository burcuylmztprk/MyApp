using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace CategoryManagement
{
    [DependsOn(
        typeof(CategoryManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class CategoryManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "CategoryManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(CategoryManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
