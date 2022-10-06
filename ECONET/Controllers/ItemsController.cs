using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Infrastructuree.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infrastructuree.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
      
        /// Type Parameter
    
        private readonly IGenericRepository<Item> _itemsRepo;
        private readonly IGenericRepository<ItemBrand> _itemBrandRepo;
        private readonly IGenericRepository<ItemCategory> _itemCategoryRepo;
        public ItemsController(IGenericRepository<Item> itemsRepo,
            IGenericRepository<ItemBrand> itemBrandRepo, IGenericRepository<ItemCategory> itemCategoryRepo)
        {
            _itemsRepo = itemsRepo;
            _itemBrandRepo = itemBrandRepo;
            _itemCategoryRepo = itemCategoryRepo;

        }

        [HttpGet]
        //
        public async Task<ActionResult<List<Item>>> GetItems()
        {
            var spec = new ItemsWithCategoriesAndBrandsSpecififcation();

            var items = await _itemsRepo.ListAsync(spec);

            return Ok(items);   
        }

     
        //Utilises the Constructor that takes a parameter and using this constructor 
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {

            var spec = new ItemsWithCategoriesAndBrandsSpecififcation(id);

            return await _itemsRepo.GetEntityWithSpec(spec);
        }

        //return directly 
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ItemBrand>>> GetItemBrands()
        {
            return Ok(await _itemBrandRepo.ListAllAsync());
        }


        //return directly 
        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<ItemCategory>>> GetItemCategories()
        {
            return Ok(await _itemCategoryRepo.ListAllAsync());
        }
    }
}
