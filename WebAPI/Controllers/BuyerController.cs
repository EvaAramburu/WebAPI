using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BuyerController : ControllerBase
    {
        private readonly ILogger<BuyerController> _logger;
        private readonly IBuyerService _buyerService;


        public BuyerController(ILogger<BuyerController> logger, IBuyerService buyerService)
        {
            _logger = logger;
            _buyerService = buyerService;
        }

        [HttpPost(Name = "InsertBuyer")]

        public int Post([FromBody] BuyerEntity buyer)
        {
            return _buyerService.InsertBuyer(buyer);
        }

        [HttpGet(Name = "GetAllBuyers")]

        public List<BuyerEntity> GetAllBuyers()
        {
            return _buyerService.GetAllBuyers();
        }

    }
}
