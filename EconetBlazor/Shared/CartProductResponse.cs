using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconetBlazor.Shared
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<Image> Images { get; set; } = new List<Image>();
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}