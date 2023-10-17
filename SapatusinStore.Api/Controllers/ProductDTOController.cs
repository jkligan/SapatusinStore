using Microsoft.AspNetCore.Mvc;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SapatusinStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDTOController : ControllerBase
    {
        private ProductServices _productServices;
        public ProductDTOController (ProductServices productServices)
        {
            _productServices = productServices;
        }
        // GET: api/<ProductDTOController>
        [HttpGet]
        public List<ProductDTO> Get()
        {
            return _productServices.GetAllProductDTOs();
        }

        // GET api/<ProductDTOController>/5
        [HttpGet("{id}")]
        public ProductDTO Get(Guid ShoeId)
        {
            return _productServices.GetProductDTOById(ShoeId);
        }

        // POST api/<ProductDTOController>
        [HttpPost]
        public void Post(string Brand, string Model, decimal Price, string Color, string Description, int ProductQuantity)
        {
            _productServices.AddProductDTO(new Guid(), Brand, Model, Price, Color, Description, ProductQuantity);
        }

        // PUT api/<ProductDTOController>/5
        [HttpPut("{id}")]
        public void Put(ProductDTO productDTO)
        {
            _productServices.UpdateProductDTO(productDTO);
        }

        // DELETE api/<ProductDTOController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid ShoeId)
        {
            _productServices.DeleteProductDTO(ShoeId);
        }
    }
}
