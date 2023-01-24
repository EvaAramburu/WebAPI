using Entities.Entities;

namespace WebAPI.IService
{
    public interface IOrderService
    {
        int InsertOrder(OrderEntity order);
    }
}
