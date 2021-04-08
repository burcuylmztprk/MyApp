using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CategoryManagement
{
    [DependsOn(
        typeof(CategoryManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class CategoryManagementApplicationContractsModule : AbpModule
    {

    }
}
