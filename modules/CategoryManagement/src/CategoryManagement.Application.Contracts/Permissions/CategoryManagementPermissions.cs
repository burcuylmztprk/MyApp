using Volo.Abp.Reflection;

namespace CategoryManagement.Permissions
{
    public class CategoryManagementPermissions
    {
        public const string GroupName = "CategoryManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(CategoryManagementPermissions));
        }
    }
}