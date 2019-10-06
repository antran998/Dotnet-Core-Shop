using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreShop.Models;
using CoreShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IItemRepository _itemRepository;        
        
        public ProductsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;    
        }

        [Route("products")]
        public async Task<IActionResult> Products(string sortOrder,int? pageNumber)
        {
            var _items = _itemRepository.GetAllItems();
            switch (sortOrder)
            {
                case "price_desc":
                    _items = _items.OrderByDescending(i => i.Price);
                    break;
                case "price_asc":
                    _items = _items.OrderBy(i => i.Price);
                    break;
                default:
                    _items = _items.OrderByDescending(i => i.Id);
                    break;
            }

            int pageSize = 10;
            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                items = await PaginatedList<Item>.CreateAsync(_items.AsNoTracking(), pageNumber ?? 1, pageSize),
                TotalItem = _itemRepository.GetAllItems()
            };

            return View("Views/Client/Product/Products.cshtml", productsViewModel);
        }

        public IActionResult ProductDetail()
        {
            return View("Views/Client/Product/ProductDetail.cshtml");
        }
    }
}