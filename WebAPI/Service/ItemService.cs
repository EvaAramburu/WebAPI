using Entities.Entities;
using Logic.ILogic;
using Resources.Requests;
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
        public int InsertItemEntity(ItemRequest itemRequest)
        {
            var newItemRequest = itemRequest.ToItemEntity();
            return _itemLogic.InsertItemEntity(newItemRequest);


        }

        public List<ItemEntity> GetAllItems()
        {
            //var resultList = _itemLogic.GetItemEntity();
            //return resultList;

            return _itemLogic.GetAllItems();
        }

        List<ItemEntity> IItemService.GetSelectedItem(int id)
        {
            return _itemLogic.GetSelectedItem(id);
        }

        void IItemService.DeactivateItem(int id)
        {
            _itemLogic.DeactivateItem(id);
        }

        void IItemService.DeleteItem(int id)
        {
            _itemLogic.DeleteItem(id);
        }

        void IItemService.UpdateItem(ItemEntity itemEntity)
        {
            _itemLogic.UpdateItem(itemEntity);
        }

    }
}
