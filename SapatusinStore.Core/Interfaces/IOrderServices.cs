using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Interfaces
{
    public interface IOrderServices
    {
        List<OrderDTO> GetAllOrderDTOs();
        OrderDTO GetOrderDTOById(Guid OrderId);
        void AddOrderDTO(Guid OrderId, Guid CustomerId, Guid ShoeId, DateTime OrderDate, decimal TotalAmount);
        void UpdateOrderDTO(OrderDTO orderDTO);
        void DeleteOrderDTO(Guid OrderId);
    }
}
