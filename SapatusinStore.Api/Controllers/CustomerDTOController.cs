using Microsoft.AspNetCore.Mvc;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapatusinStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDTOController : ControllerBase
    {
        private readonly CustomerServices _customerServices;
        public CustomerDTOController (CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }
        // GET: api/<CustomerDTOController>
        [HttpGet]
        public List<CustomerDTO> Get()
        {
            return _customerServices.GetAllCustomerDTOs();
        }

        // GET api/<CustomerDTOController>/5
        [HttpGet("{id}")]
        public CustomerDTO Get(Guid CustomerId)
        {
            return _customerServices.GetCustomerDTOById(CustomerId);
        }

        // POST api/<CustomerDTOController>
        [HttpPost]
        public void Post(string Firstname, string Lastname, string EmailAddress, string ContactNumber, string Address)
        {
            _customerServices.AddCustomerDTO(new Guid(), Firstname, Lastname, EmailAddress, ContactNumber, Address);
        }

        // PUT api/<CustomerDTOController>/5
        [HttpPut("{id}")]
        public void Put(CustomerDTO customerDTO)
        {
            _customerServices.UpdateCustomerDTO(customerDTO);
        }

        // DELETE api/<CustomerDTOController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid CustomerId)
        {
           _customerServices.DeleteCustomerDTO(CustomerId);
        }
    }
}
