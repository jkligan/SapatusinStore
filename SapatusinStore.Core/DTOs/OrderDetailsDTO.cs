using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.DTOs
{
    public class OrderDetailsDTO
    {
        public Guid OrderDetailsID { get; set;}

        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }

        [ForeignKey("ShoeId")]
        public Guid ShoeId { get; set; }

        public int Quantity { get; set; }
    }
}
