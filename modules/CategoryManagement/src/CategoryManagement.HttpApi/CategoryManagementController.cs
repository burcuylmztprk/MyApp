using CategoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CategoryManagement
{
    public abstract class CategoryManagementController : AbpController
    {
        protected CategoryManagementController()
        {
            LocalizationResource = typeof(CategoryManagementResource);
        }
    }
}
