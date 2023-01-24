using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IItemLogic
    {
        void InsertItemEntity(ItemEntity itemEntity);
        List<ItemEntity> GetItemEntity();
    }
}
