using AutoMapper;
using CategoryManagement.Categories;

namespace MyApp
{
    public class MyAppApplicationAutoMapperProfile : Profile
    {
        public MyAppApplicationAutoMapperProfile()
        {

            CreateMap<Category, CategoriesDto>();
            CreateMap<CategoriesCreateUpdateDto, Category>();
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}
