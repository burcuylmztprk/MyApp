using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CategoryManagement.EntityFrameworkCore
{
    public class CategoryManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public CategoryManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}