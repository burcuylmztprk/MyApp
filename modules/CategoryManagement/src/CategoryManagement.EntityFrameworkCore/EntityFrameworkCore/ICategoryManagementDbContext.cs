using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CategoryManagement.EntityFrameworkCore
{
    [ConnectionStringName(CategoryManagementDbProperties.ConnectionStringName)]
    public interface ICategoryManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}