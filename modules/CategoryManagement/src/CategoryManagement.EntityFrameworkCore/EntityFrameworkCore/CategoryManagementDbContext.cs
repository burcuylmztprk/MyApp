using CategoryManagement.Categories;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CategoryManagement.EntityFrameworkCore
{
    [ConnectionStringName(CategoryManagementDbProperties.ConnectionStringName)]
    public class CategoryManagementDbContext : AbpDbContext<CategoryManagementDbContext>, ICategoryManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Category> Categories { get; set; }

        public CategoryManagementDbContext(DbContextOptions<CategoryManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureCategoryManagement();
        }
    }
}