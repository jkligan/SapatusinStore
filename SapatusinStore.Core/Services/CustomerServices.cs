using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Interfaces;
using SapatusinStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ApplicationDbContext _context;
        public CustomerServices(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void AddCustomerDTO(Guid CustomerId, string Firstname, string Lastname, string EmailAddress, string ContactNumber, string Address)
        {
            var customerDTOs = new CustomerDTO()
            {
                CustomerId = CustomerId,
                Firstname = Firstname,
                Lastname = Lastname,
                EmailAddress = EmailAddress,
                ContactNumber = ContactNumber,
                Address = Address
            };
            _context.Add(customerDTOs);
            _context.SaveChanges();
        }

        public void DeleteCustomerDTO(Guid CustomerId)
        {
            var customerDTOs = new CustomerDTO()
            {
                CustomerId = CustomerId
            };
            _context.Attach(customerDTOs);
            _context.Remove(customerDTOs);
            _context.SaveChanges();
        }

        public List<CustomerDTO> GetAllCustomerDTOs()
        {
            return _context.CustomerDTOs.ToList();
        }

        public CustomerDTO GetCustomerDTOById(Guid CustomerId)
        {
            return _context.CustomerDTOs.FirstOrDefault(c => c.CustomerId == CustomerId);
        }

        public void UpdateCustomerDTO(CustomerDTO customerDTO)
        {
            _context.CustomerDTOs.Entry(customerDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
