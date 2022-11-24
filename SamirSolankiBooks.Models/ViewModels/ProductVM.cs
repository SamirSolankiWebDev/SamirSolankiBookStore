using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamirSolankiBooks.Models.ViewModels
{
    class ProductVM
    {
        public Product Product { get; set; } // Display all the product deytails 
        public IEnumerable<SelectListItem> CategoryList { get; set; } // install pacckage 'Microsoft.AspNetCore.Mvc.View
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
