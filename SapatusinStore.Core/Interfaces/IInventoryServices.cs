using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Interfaces
{
    public interface IInventoryServices
    {
        List<InventoryDTO> GetAllInventoryDTOs();
        InventoryDTO GetInventoryDTOById(Guid InventoryId);
        void AddInventoryDTO(Guid InventoryId, Guid ShoeId, int StockQuantity);
        void UpdateInventoryDTO(InventoryDTO InventoryDTO);
        void DeleteInventoryDTO(Guid InventoryId);
    }
}
