using CoreShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.ViewModels
{
    public class ProductsViewModel
    {        
        public PaginatedList<Item> items { get; set; }
        public int PageFrom { get { return items.PageIndex * 10 - 9; } }
        public int PageTo { get {
            int count = 0;
            foreach (Item item in items)
            {
                count++;
            }
            return PageFrom+count-1; 
        } }
        public IQueryable<Item> TotalItem { get; set; }
    }
}
