using CategoryManagement.Localization;
using Volo.Abp.Application.Services;

namespace CategoryManagement
{
    public abstract class CategoryManagementAppService : ApplicationService
    {
        protected CategoryManagementAppService()
        {
            LocalizationResource = typeof(CategoryManagementResource);
            ObjectMapperContext = typeof(CategoryManagementApplicationModule);
        }
    }
}
