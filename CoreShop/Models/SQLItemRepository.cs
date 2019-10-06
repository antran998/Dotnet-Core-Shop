using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    public class SQLItemRepository : IItemRepository
    {
        private readonly AppDbContext context;

        public SQLItemRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Item Add(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return item;
        }

        public Item Delete(int id)
        {
            Item item = context.Items.Find(id);
            if(item != null)
            {
                context.Items.Remove(item);
                context.SaveChanges();                
            }
            return item;
        }

        public Item GetItem(int id)
        {
            return context.Items.Find(id);            
        }

        public IQueryable<Item> GetAllItems()
        {
            return context.Items;
        }

        public Item Update(Item itemChanges)
        {
            var item = context.Items.Attach(itemChanges);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return itemChanges;
        }
    }
}
