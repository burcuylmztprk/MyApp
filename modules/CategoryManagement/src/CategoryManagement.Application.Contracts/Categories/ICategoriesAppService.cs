using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CategoryManagement.Categories
{
   public interface ICategoriesAppService : ICrudAppService<CategoriesDto, Guid, PagedAndSortedResultRequestDto, CategoriesCreateUpdateDto, CategoriesCreateUpdateDto>
    {
    }
}
