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

        public List<ItemEntity> GetAllItems()
        {
            //FUNCIONAMIENTO DEL MÉTODO
            return _serviceContext.Set<ItemEntity>().ToList();


            //EJEMPLOS CÓDIGO. VER LINQ. NO VAN ACÁ

            //filtra
            //var selectedItems = _serviceContext.Set<ItemEntity>().Where(i => i.IsActive).ToList();

            //trae el primero
            var firstItem = _serviceContext.Set<ItemEntity>().First();
            firstItem.Brand = "Sasasasa";

            //lo modifica
            _serviceContext.SaveChanges();
        }
    }
}
