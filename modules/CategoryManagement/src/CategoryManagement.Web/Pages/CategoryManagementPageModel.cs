using CategoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CategoryManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CategoryManagementPageModel : AbpPageModel
    {
        protected CategoryManagementPageModel()
        {
            LocalizationResourceType = typeof(CategoryManagementResource);
            ObjectMapperContext = typeof(CategoryManagementWebModule);
        }
    }
}