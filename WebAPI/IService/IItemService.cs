using Entities.Entities;
using Resources.Filters;
using Resources.Requests;

namespace WebAPI.IService
{
    public interface IItemService
    {
        int InsertItemEntity(ItemRequest itemRequest);
        List<ItemEntity> GetAllItems();
        List<ItemEntity> GetSelectedItem(int id);
        void DeactivateItem(int id);
        void DeleteItem(int id);
        void UpdateItem(ItemEntity itemEntity);
        List<ItemEntity> GetItemByBrand(string brand);
    }

}
