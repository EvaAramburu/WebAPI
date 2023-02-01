using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.Filters;
using WebAPI.IService;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]

        public int InsertOrder([FromBody]OrderEntity order)
        {
            return _orderService.InsertOrder(order);
        }

        [HttpGet(Name = "GetAllOrders")]

        public List<OrderEntity> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        [HttpGet(Name = "GetSelectedOrder")]
        public List<OrderEntity> GetSelectedItem([FromQuery] int id)
        {
            return _orderService.GetSelectedOrder(id);
        }

        [HttpDelete(Name = "DeactivateOrder")]

        public void DeactivateOrder([FromQuery] int id)
        {
            _orderService.DeactivateOrder(id);
        }

        [HttpDelete(Name = "DeleteOrder")]

        public void DeleteOrder([FromQuery] int id)
        {
            _orderService.DeleteOrder(id);
        }

        //[HttpGet(Name = "GetPendingShippingOrders")]

        //public List<OrderEntity> GetPendingShippingOrders([FromQuery] OrderFilter orderFilter)
        //{
        //    return _orderService.GetPendingShippingOrders(orderFilter);
        //}
    }
}
