using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuree.Data
{
    //ABSTRCTING DATA ACCESS METHODS FROM CONTROLLER 
    public class ItemRepository : IItemRepository
    {
        private readonly MarketContext _context;
        public ItemRepository(MarketContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<ItemBrand>> GetItemBrandAsync()
        {
            return await _context.ItemBrands.ToListAsync();
        }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await _context.Items
                .Include(p => p.ItemCategory)
                .Include(p => p.ItemBrand)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<ItemCategory>> GetItemCategoryAsync()
        {
            return await _context.ItemCategories.ToListAsync();
        }

        public async Task<IReadOnlyList<Item>> GetItemsAsync()
        {
            return await _context.Items
                .Include(p => p.ItemCategory)
                .Include(p => p.ItemBrand)
                .ToListAsync();
        }
    }
}
