using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CategoryManagement.Categories
{
    public class CategoriesAppService : CrudAppService<Category, CategoriesDto, Guid, PagedAndSortedResultRequestDto, CategoriesCreateUpdateDto, CategoriesCreateUpdateDto>, ICategoriesAppService
    {
        public CategoriesAppService(IRepository<Category, Guid> repository) : base(repository)
        {
        }
    }
}
