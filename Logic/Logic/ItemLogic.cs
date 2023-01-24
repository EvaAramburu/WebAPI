using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ItemLogic : BaseContextLogic, IItemLogic
    {
        public ItemLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public void InsertItemEntity(ItemEntity itemEntity)
        {
            _serviceContext.Items.Add(itemEntity);
            _serviceContext.SaveChanges();
        }

        public List<ItemEntity> GetItemEntity()
        {
            return _serviceContext.Set<ItemEntity>().ToList();
        }
    }
}
