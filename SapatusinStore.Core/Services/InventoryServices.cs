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
    public class InventoryServices : IInventoryServices
    {
        private readonly ApplicationDbContext _context;
        public InventoryServices(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void AddInventoryDTO(Guid InventoryId, Guid ShoeId, int StockQuantity)
        {
            var inventoryDTOs = new InventoryDTO()
            {
                InventoryId = InventoryId,
                ShoeId = ShoeId,
                StockQuantity = StockQuantity
            };
            _context.Add(inventoryDTOs);
            _context.SaveChanges();
        }

        public void DeleteInventoryDTO(Guid InventoryId)
        {
            var inventoryDTOs = new InventoryDTO()
            {
                InventoryId = InventoryId
            };
            _context.Attach(inventoryDTOs);
            _context.Remove(inventoryDTOs);
            _context.SaveChanges();
        }

        public List<InventoryDTO> GetAllInventoryDTOs()
        {
            return _context.InventoryDTOs.ToList();
        }

        public InventoryDTO GetInventoryDTOById(Guid InventoryId)
        {
            return _context.InventoryDTOs.FirstOrDefault(i => i.InventoryId == InventoryId);
        }

        public void UpdateInventoryDTO(InventoryDTO InventoryDTO)
        {
            _context.InventoryDTOs.Entry(InventoryDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
