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
    public class OrderServices : IOrderServices
    {
        private readonly ApplicationDbContext _context;
        public OrderServices(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void AddOrderDTO(Guid OrderId, Guid CustomerId, Guid ShoeId, DateTime OrderDate, decimal TotalAmount)
        {
            var orderDTOs = new OrderDTO()
            {
                OrderId = OrderId,
                CustomerId = CustomerId,
                ShoeId = ShoeId,
                OrderDate = OrderDate,
                TotalAmount = TotalAmount
            };
            _context.Add(orderDTOs);
            _context.SaveChanges();
        }

        public void DeleteOrderDTO(Guid OrderId)
        {
            var orderDTOs = new OrderDTO()
            {
                OrderId = OrderId,
            };
            _context.Attach(orderDTOs);
            _context.Remove(orderDTOs);
            _context.SaveChanges();
        }

        public List<OrderDTO> GetAllOrderDTOs()
        {
            return _context.OrderDTOs.ToList();
        }

        public OrderDTO GetOrderDTOById(Guid OrderId)
        {
            return _context.OrderDTOs.FirstOrDefault(o => o.OrderId == OrderId);
        }

        public void UpdateOrderDTO(OrderDTO orderDTO)
        {
            _context.OrderDTOs.Entry(orderDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
