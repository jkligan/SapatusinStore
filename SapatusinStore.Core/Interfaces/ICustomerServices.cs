using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Interfaces
{
    public interface ICustomerServices
    {
        List<CustomerDTO> GetAllCustomerDTOs();
        CustomerDTO GetCustomerDTOById(Guid CustomerId);
        void AddCustomerDTO(Guid CustomerId, string Firstname, string Lastname, string EmailAddress, string ContactNumber, string Address);
        void UpdateCustomerDTO(CustomerDTO customerDTO);
        void DeleteCustomerDTO(Guid CustomerId);
    }
}
