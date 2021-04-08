using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CategoryManagement
{
    [DependsOn(
        typeof(CategoryManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CategoryManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
