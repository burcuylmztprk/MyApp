using CategoryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CategoryManagement.Permissions
{
    public class CategoryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CategoryManagementPermissions.GroupName, L("Permission:CategoryManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CategoryManagementResource>(name);
        }
    }
}