using System;
using System.Collections.Generic;

namespace _6.WebApiEntityFramework.Models
{
    public partial class Products
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
       
    }
}
