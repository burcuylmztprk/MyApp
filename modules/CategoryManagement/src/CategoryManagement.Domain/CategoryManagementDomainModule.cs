using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CategoryManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(CategoryManagementDomainSharedModule)
    )]
    public class CategoryManagementDomainModule : AbpModule
    {

    }
}
