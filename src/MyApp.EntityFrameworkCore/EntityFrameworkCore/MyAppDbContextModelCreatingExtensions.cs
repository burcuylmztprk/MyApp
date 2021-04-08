using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MyApp.EntityFrameworkCore
{
    public static class MyAppDbContextModelCreatingExtensions
    {
        public static void ConfigureMyApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyAppConsts.DbTablePrefix + "YourEntities", MyAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}