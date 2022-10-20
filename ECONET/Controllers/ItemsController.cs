using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using ECONET.Controllers;
using ECONET.DTO;
using Infrastructuree.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infrastructuree.Controllers
{
    
    public class ItemsController : BaseApiController
    {
      
        /// Type Parameter
    
        private readonly IGenericRepository<Item> _itemsRepo;
        private readonly IGenericRepository<ItemBrand> _itemBrandRepo;
        private readonly IGenericRepository<ItemCategory> _itemCategoryRepo;
        private readonly IMapper _mapper;
        public ItemsController(IGenericRepository<Item> itemsRepo,
            IGenericRepository<ItemBrand> itemBrandRepo, IGenericRepository<ItemCategory> itemCategoryRepo, IMapper mapper)
        {
            _mapper = mapper;
            _itemsRepo = itemsRepo;
            _itemBrandRepo = itemBrandRepo;
            _itemCategoryRepo = itemCategoryRepo;

        }

        [HttpGet]
        //
        public async Task<ActionResult<List<ItemToReturnDto>>> GetItems()
        {
            var spec = new ItemsWithCategoriesAndBrandsSpecififcation();
            //Database
            var items = await _itemsRepo.ListAsync(spec);
            //Properties from item to List In memory
            return Ok(_mapper.Map<IReadOnlyList<Item>, IReadOnlyList<ItemToReturnDto>>(items));

        }

     
        //Utilises the Constructor that takes a parameter and using this constructor 
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemToReturnDto>> GetItem(int id)
        {

            var spec = new ItemsWithCategoriesAndBrandsSpecififcation(id);

           //return dto
           var item = await _itemsRepo.GetEntityWithSpec(spec);
            return _mapper.Map<Item, ItemToReturnDto>(item);
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

        //create product fix method 
        //[HttpPost("item")]
       // public async Task<ActionResult> Create(Item)
       // {
          //  return Ok(await _itemsRepo.AddNewItemAsync(item));
        //}


        //deleteProduct method 

        //UpdateProduct method
        


    }
}
