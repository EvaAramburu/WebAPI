using Entities.Entities;
using Logic.ILogic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemLogic _itemLogic; 

        public ItemService(IItemLogic itemLogic)
        {
            _itemLogic = itemLogic; 
        }
        public int InsertItemEntity(ItemEntity itemEntity)
        {
            _itemLogic.InsertItemEntity(itemEntity);
            return itemEntity.Id;
        }

        public List<ItemEntity> GetItemEntity()
        {
            //var resultList = _itemLogic.GetItemEntity();
            //return resultList;

            return _itemLogic.GetItemEntity();
        }
    }
}
