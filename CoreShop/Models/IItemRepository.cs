using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    public interface IItemRepository
    {
        Item GetItem(int id);
        IQueryable<Item> GetAllItems();
        Item Add(Item item);
        Item Update(Item itemChanges);
        Item Delete(int id);
    }
}
