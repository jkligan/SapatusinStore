using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.DTOs
{
    public class InventoryDTO
    {
        public Guid InventoryId { get; set; }

        [ForeignKey("ShoeId")]
        public Guid ShoeId { get; set; }
        public int StockQuantity { get; set; }
    }
}
