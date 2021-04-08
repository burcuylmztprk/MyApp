using System;
using CategoryManagement.Categories;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace CategoryManagement.EntityFrameworkCore
{
    public static class CategoryManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureCategoryManagement(
            this ModelBuilder builder,
            Action<CategoryManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new CategoryManagementModelBuilderConfigurationOptions(
                CategoryManagementDbProperties.DbTablePrefix,
                CategoryManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);
            builder.Entity<Category>(b =>
            {
                b.ToTable("Categories");
                b.ConfigureByConvention();
                b.Ignore(x => x.ExtraProperties);
                b.Property(x => x.CategoryName).IsRequired().HasMaxLength(CategoriesConsts.MaxLenght);
            });
            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);

                b.ConfigureByConvention();

                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}