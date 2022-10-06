using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ItemsWithCategoriesAndBrandsSpecififcation : BaseSpecification<Item>
    {
        public ItemsWithCategoriesAndBrandsSpecififcation()
        {
            //Expression replace generic expression 
            AddInclude(x => x.ItemCategory);
            AddInclude(x => x.ItemCategory);
        }


        //criteria is int of item 
        public ItemsWithCategoriesAndBrandsSpecififcation(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ItemCategory);
            AddInclude(x => x.ItemBrand);
        }
        

           
    }
}