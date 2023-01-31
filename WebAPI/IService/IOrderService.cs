using Entities.Entities;

namespace WebAPI.IService
{
    public interface IOrderService
    {
        int InsertOrder(OrderEntity order);
        List<OrderEntity> GetAllOrders();
        List<OrderEntity> GetSelectedOrder(int id);
        void DeactivateOrder(int id);
        void DeleteOrder(int id);
    }
}
