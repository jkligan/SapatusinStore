using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Interfaces;
using SapatusinStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ApplicationDbContext _context;
        public ProductServices(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void AddProductDTO(Guid ShoeId, string Brand, string Model, decimal Price, string Color, string Description, int ProductQuantity)
        {
            var productDTOs = new ProductDTO()
            {
                ShoeId = ShoeId,
                Brand = Brand,
                Model = Model,
                Price = Price,
                Color = Color,
                Description = Description,
                ProductQuantity = ProductQuantity
            };
            _context.Add(productDTOs);
            _context.SaveChanges();
        }

        public void DeleteProductDTO(Guid ShoeId)
        {

            var productDTOs = new ProductDTO()
            {
                ShoeId = ShoeId
            };
            _context.Attach(productDTOs);
            _context.Remove(productDTOs);
            _context.SaveChanges();
        }

        public List<ProductDTO> GetAllProductDTOs()
        {
            return _context.ProductDTO.ToList();
        }

        public ProductDTO GetProductDTOById(Guid ShoeId)
        {
            return _context.ProductDTO.FirstOrDefault(p => p.ShoeId == ShoeId);
        }

        public void UpdateProductDTO(ProductDTO productDTO)
        {
            _context.ProductDTO.Entry(productDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
