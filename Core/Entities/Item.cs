namespace Core.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; } 

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public int ItemCategoryID { get; set; }

        public ItemBrand ItemBrand { get; set; }
      //  public object ItemBrand { get; set; }
        public int ItemBrandId { get; set; }

    }
}
