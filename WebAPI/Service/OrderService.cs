using Entities.Entities;
using Logic.ILogic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }

        public int InsertOrder(OrderEntity order)
        {
            _orderLogic.InsertOrder(order);
            return order.Id;
        }

        public List<OrderEntity> GetAllOrders()
        {
            return _orderLogic.GetAllOrders();
        }
    }
}
