using Microsoft.AspNetCore.Mvc;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapatusinStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsDTOController : ControllerBase
    {
        private readonly OrderDetailsServices _orderDetailsServices;
        public OrderDetailsDTOController (OrderDetailsServices orderDetailsServices)
        {
            _orderDetailsServices = orderDetailsServices;
        }
        // GET: api/<OrderDetailsDTOController>
        [HttpGet]
        public List<OrderDetailsDTO> Get()
        {
            return _orderDetailsServices.GetAllOrderDetailsDTOs();
        }

        // GET api/<OrderDetailsDTOController>/5
        [HttpGet("{id}")]
        public OrderDetailsDTO Get(Guid OrderDetailsID)
        {
            return _orderDetailsServices.GetOrderDetailDTOById(OrderDetailsID);
        }

        // POST api/<OrderDetailsDTOController>
        [HttpPost]
        public void Post(Guid OrderId, Guid ShoeId, int Quantity)
        {
            _orderDetailsServices.AddOrderDetailsDTO(new Guid(), OrderId, ShoeId, Quantity);
        }

        // PUT api/<OrderDetailsDTOController>/5
        [HttpPut("{id}")]
        public void Put(OrderDetailsDTO orderDetailsDTO)
        {
            _orderDetailsServices.UpdateOrderDetailsDTO(orderDetailsDTO);
        }

        // DELETE api/<OrderDetailsDTOController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid OrderDetailsID)
        {
            _orderDetailsServices.DeleteOrderDetailsDTO(OrderDetailsID);
        }
    }
}
