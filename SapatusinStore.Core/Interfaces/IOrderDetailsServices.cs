using SapatusinStore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatusinStore.Core.Interfaces
{
    public interface IOrderDetailsServices
    {
        List<OrderDetailsDTO> GetAllOrderDetailsDTOs();
        OrderDetailsDTO GetOrderDetailDTOById(Guid OrderDetailsID);
        void AddOrderDetailsDTO(Guid OrderDetailsID, Guid OrderId, Guid ShoeId, int Quantity);
        void UpdateOrderDetailsDTO(OrderDetailsDTO OrderDetails);
        void DeleteOrderDetailsDTO(Guid OrderDetailsID);
    }
}
