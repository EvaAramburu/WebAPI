using Entities.Entities;
using Resources.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        int InsertOrder(OrderEntity order);
        List<OrderEntity> GetAllOrders();
        List<OrderEntity> GetSelectedOrder(int id);
        void DeactivateOrder(int id);
        void DeleteOrder(int id);
        //List<OrderEntity> GetPendingShippingOrders(OrderFilter orderFilter);
    }
}
