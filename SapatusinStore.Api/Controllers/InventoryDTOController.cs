using Microsoft.AspNetCore.Mvc;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Interfaces;
using SapatusinStore.Core.Services;
using System.Net.Mail;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapatusinStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryDTOController : ControllerBase
    {
        private readonly InventoryServices _inventoryServices;
        public InventoryDTOController (InventoryServices inventoryServices)
        {
            _inventoryServices = inventoryServices;
        }
        // GET: api/<InventoryDTOController>
        [HttpGet]
        public List<InventoryDTO> Get()
        {
            return _inventoryServices.GetAllInventoryDTOs();
        }

        // GET api/<InventoryDTOController>/5
        [HttpGet("{id}")]
        public InventoryDTO Get(Guid InventoryId)
        {
            return _inventoryServices.GetInventoryDTOById(InventoryId);
        }

        // POST api/<InventoryDTOController>
        [HttpPost]
        public void Post(Guid ShoeId, int StockQuantity)
        {
            _inventoryServices.AddInventoryDTO(new Guid(), ShoeId, StockQuantity);
        }

        // PUT api/<InventoryDTOController>/5
        [HttpPut("{id}")]
        public void Put(InventoryDTO inventoryDTO)
        {
            _inventoryServices.UpdateInventoryDTO(inventoryDTO);
        }

        // DELETE api/<InventoryDTOController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid InventoryId)
        {
            _inventoryServices.DeleteInventoryDTO(InventoryId);
        }
    }
}
