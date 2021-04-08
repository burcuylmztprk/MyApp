using Volo.Abp.Modularity;

namespace CategoryManagement
{
    [DependsOn(
        typeof(CategoryManagementApplicationModule),
        typeof(CategoryManagementDomainTestModule)
        )]
    public class CategoryManagementApplicationTestModule : AbpModule
    {

    }
}
