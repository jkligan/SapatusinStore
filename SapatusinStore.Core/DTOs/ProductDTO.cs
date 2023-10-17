using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.DTOs
{
    public class ProductDTO
    {
        public Guid ShoeId { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public decimal Price { get; set; }
        public string Color { get; set; } = "";
        public string Description { get; set; } = "";
        public int ProductQuantity { get; set; }
    }
}
