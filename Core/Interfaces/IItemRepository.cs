using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IItemRepository
    {
        Task<Item> GetItemByIdAsync(int id);

        //List generic list object, Read only 
        Task<IReadOnlyList<Item>> GetItemsAsync();
        Task<IReadOnlyList<ItemBrand>> GetItemBrandAsync();
        Task<IReadOnlyList<ItemCategory>> GetItemCategoryAsync();


    }
}
