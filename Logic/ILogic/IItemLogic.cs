using Entities.Entities;
using Resources.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IItemLogic
    {
        int InsertItemEntity(ItemEntity itemEntity);
        List<ItemEntity> GetAllItems();
        List<ItemEntity> GetSelectedItem(int id);
        void DeactivateItem(int id);
        void DeleteItem(int id);
        void UpdateItem(ItemEntity itemEntity);

    }
}
