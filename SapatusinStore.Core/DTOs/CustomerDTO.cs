using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.DTOs
{
    public class CustomerDTO
    {
        public Guid CustomerId { get; set; }
        public string Firstname { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public string ContactNumber { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
