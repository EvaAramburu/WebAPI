using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.Requests;
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

        public int InsertItemEntity([FromBody]ItemRequest itemRequest)
        {
            return _itemService.InsertItemEntity(itemRequest);
        }

        [HttpGet(Name = "GetAllItems")]
        public List<ItemEntity> GetAllItems()
        {
            return _itemService.GetAllItems();
        }
        [HttpGet(Name = "GetSelectedItem")]
        public List<ItemEntity> GetSelectedItem([FromQuery] int id)
        {
            return _itemService.GetSelectedItem(id);
        }

        [HttpDelete(Name = "DeactivateItem")]

        public void DeactivateItem([FromQuery] int id)
        {
            _itemService.DeactivateItem(id);
        }

        [HttpDelete(Name = "DeleteItem")]

        public void DeleteItem([FromQuery] int id)
        {
            _itemService.DeleteItem(id);
        }

        [HttpPatchAttribute(Name = "UpdateItem")]
        public void UpdateItem(ItemEntity itemEntity)
        {
            _itemService.UpdateItem(itemEntity);
        }
    }

}
