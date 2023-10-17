using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Interfaces
{
    public interface IProductServices
    {
        List<ProductDTO> GetAllProductDTOs();
        ProductDTO GetProductDTOById(Guid ShoeId);
        void AddProductDTO(Guid ShoeId, string Brand, string Model, decimal Price, string Color, string Description, int ProductQuantity);
        void UpdateProductDTO(ProductDTO productDTO);
        void DeleteProductDTO(Guid ShoeId);
    }
}
