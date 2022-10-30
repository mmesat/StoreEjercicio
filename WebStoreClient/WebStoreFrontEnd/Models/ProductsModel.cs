using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStoreFrontEnd.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name can not be blank")]
        public string ProductName { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Description can not be blank")]
        public string Description { get; set; }
    }
}