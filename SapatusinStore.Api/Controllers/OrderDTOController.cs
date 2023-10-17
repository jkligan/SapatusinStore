using Microsoft.AspNetCore.Mvc;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapatusinStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDTOController : ControllerBase
    {
        private readonly OrderServices _orderServices;
        public OrderDTOController (OrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        // GET: api/<OrderDTOController>
        [HttpGet]
        public List<OrderDTO>Get()
        {
            return _orderServices.GetAllOrderDTOs();
        }

        // GET api/<OrderDTOController>/5
        [HttpGet("{id}")]
        public OrderDTO Get(Guid OrderId)
        {
            return _orderServices.GetOrderDTOById(OrderId);
        }

        // POST api/<OrderDTOController>
        [HttpPost]
        public void Post(Guid CustomerId, Guid ShoeId, DateTime OrderDate, decimal TotalAmount)
        {
            _orderServices.AddOrderDTO(new Guid(), CustomerId, ShoeId, OrderDate, TotalAmount);
        }

        // PUT api/<OrderDTOController>/5
        [HttpPut("{id}")]
        public void Put(OrderDTO orderDTO)
        {
            _orderServices.UpdateOrderDTO(orderDTO);
        }

        // DELETE api/<OrderDTOController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid OrderId)
        {
            _orderServices.DeleteOrderDTO(OrderId);
        }
    }
}
