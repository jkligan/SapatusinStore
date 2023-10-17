using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.DTOs
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }

        [ForeignKey ("CustomerId")]
        public Guid CustomerId { get; set; }

        [ForeignKey("ShoeId")]
        public Guid ShoeId { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
