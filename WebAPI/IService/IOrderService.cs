using Entities.Entities;
using Resources.Filters;

namespace WebAPI.IService
{
    public interface IOrderService
    {
        int InsertOrder(OrderEntity order);
        List<OrderEntity> GetAllOrders();
        List<OrderEntity> GetSelectedOrder(int id);
        void DeactivateOrder(int id);
        void DeleteOrder(int id);
        //List<OrderEntity> GetPendingShippingOrders(OrderFilter orderFilter);
    }
}
