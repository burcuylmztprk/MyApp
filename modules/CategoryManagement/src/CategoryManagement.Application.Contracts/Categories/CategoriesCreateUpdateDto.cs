using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CategoryManagement.Categories
{
   public class CategoriesCreateUpdateDto
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
