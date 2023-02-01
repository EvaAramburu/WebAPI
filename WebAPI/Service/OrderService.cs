using Entities.Entities;
using Logic.ILogic;
using Resources.Filters;
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
        public List<OrderEntity> GetSelectedOrder(int id)
        {
            return _orderLogic.GetSelectedOrder(id);
        }
        public void DeactivateOrder(int id)
        {
            _orderLogic.DeactivateOrder(id);
        }
        public void DeleteOrder(int id)
        {
            _orderLogic.DeleteOrder(id);
        }

        //public List<OrderEntity> GetPendingShippingOrders(OrderFilter orderFilter)
        //{
        //    return _orderLogic.GetPendingShippingOrders(orderFilter);
        //}
    }
}
