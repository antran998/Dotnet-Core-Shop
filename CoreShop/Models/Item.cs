using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        public int DiscountPrice { get; set; }
        public int Price { get; set; }
    }
}
