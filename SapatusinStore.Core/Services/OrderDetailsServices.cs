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
    public class OrderDetailsServices : IOrderDetailsServices
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailsServices (ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddOrderDetailsDTO(Guid OrderDetailsID, Guid OrderId, Guid ShoeId, int Quantity)
        {
            var orderDetailsDTOs = new OrderDetailsDTO()
            {
                OrderDetailsID = OrderDetailsID,
                OrderId = OrderId,
                ShoeId = ShoeId,
                Quantity = Quantity
            };
            _context.Add(orderDetailsDTOs);
            _context.SaveChanges();
        }

        public void DeleteOrderDetailsDTO(Guid OrderDetailsID)
        {
            var orderDetailsDTOs = new OrderDetailsDTO()
            {
                OrderDetailsID = OrderDetailsID,
            };
            _context.Attach(orderDetailsDTOs);
            _context.Remove(orderDetailsDTOs);
            _context.SaveChanges();
        }

        public List<OrderDetailsDTO> GetAllOrderDetailsDTOs()
        {
            return _context.OrderDetailsDTOs.ToList();
        }

        public OrderDetailsDTO GetOrderDetailDTOById(Guid OrderDetailsID)
        {
            return _context.OrderDetailsDTOs.FirstOrDefault(o => o.OrderDetailsID == OrderDetailsID);
        }

        public void UpdateOrderDetailsDTO(OrderDetailsDTO orderDetailsDTO)
        {
            _context.OrderDetailsDTOs.Entry(orderDetailsDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
