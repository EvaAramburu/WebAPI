﻿using Entities.Entities;

namespace WebAPI.IService
{
    public interface IItemService
    {
        int InsertItemEntity(ItemEntity itemEntity);
        List<ItemEntity> GetAllItems();
    }

}
