using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using Resources.Requests;
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

        public int InsertItemEntity(ItemEntity itemEntity)
        {
            _serviceContext.Items.Add(itemEntity);
            _serviceContext.SaveChanges();
            return itemEntity.Id;
            
        }

        public List<ItemEntity> GetAllItems()
        {
            //FUNCIONAMIENTO DEL MÉTODO
            return _serviceContext.Set<ItemEntity>().ToList();


            //EJEMPLOS CÓDIGO. VER LINQ. NO VAN ACÁ

            //filtra
            //var selectedItems = _serviceContext.Set<ItemEntity>().Where(i => i.IsActive).ToList();

            //trae el primero
            //var firstItem = _serviceContext.Set<ItemEntity>().First();
            //firstItem.Brand = "Sasasasa";

            //lo modifica
            //_serviceContext.SaveChanges();
        }

        List<ItemEntity> IItemLogic.GetSelectedItem(int id)
        {
            var selection = _serviceContext.Set<ItemEntity>()
                .Where(i => i.Id == id).ToList();
            return selection;


        }

        void IItemLogic.DeactivateItem(int id)
        {
            var itemToDeactivate = _serviceContext.Set<ItemEntity>()
           .Where(i => i.Id == id).First();

            itemToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }
        void IItemLogic.DeleteItem(int id)
        {
            //var userToDelete = _serviceContext.Set<UserEntity>().Where(u => u.Id == id).First();

            _serviceContext.Items.Remove(_serviceContext.Set<ItemEntity>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();

        }
    }
}
