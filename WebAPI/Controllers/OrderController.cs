using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IService;

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

        public int Post([FromBody]OrderEntity order)
        {
            return _orderService.InsertOrder(order);
        }

        [HttpGet(Name = "GetAllOrders")]

        public List<OrderEntity> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
    }
}
