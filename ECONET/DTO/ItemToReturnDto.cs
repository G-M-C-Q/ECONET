namespace ECONET.DTO
{
    public class ItemToReturnDto
    {
        //return flat object to client containing the properties
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public string ItemCategory { get; set; }

        public string ItemBrand { get; set; }

    }
}
