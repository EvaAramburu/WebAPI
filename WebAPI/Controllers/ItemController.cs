using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] 
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService; 

        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }
        [HttpPost(Name = "InsertItem")]

        public int Post([FromBody]ItemEntity itemEntity)
        {
            return _itemService.InsertItemEntity(itemEntity);
        }

        [HttpGet(Name = "GetAllItems")]
        public List<ItemEntity> GetAllItems()
        {
            return _itemService.GetAllItems();
        }
     }

}
