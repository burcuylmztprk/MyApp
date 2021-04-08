using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CategoryManagement.Categories
{
   public class CategoriesDto : EntityDto<Guid>
    {
        public string CategoryName { get; set; }
    }
}
