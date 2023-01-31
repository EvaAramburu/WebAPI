using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
    public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public void InsertOrder(OrderEntity order)
            {
                _serviceContext.Orders.Add(order);
                _serviceContext.SaveChanges();
            }

            List<OrderEntity> IOrderLogic.GetAllOrders()
            {
                return _serviceContext.Set<OrderEntity>().ToList();
            }

        void IOrderLogic.DeactivateOrder(int id)
        {
            var orderToDeactivate = _serviceContext.Set<OrderEntity>()
           .Where(o => o.Id == id).First();

            orderToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();
        }
        void IOrderLogic.DeleteOrder(int id)
        { 
            _serviceContext.Orders.Remove(_serviceContext.Set<OrderEntity>().Where(o => o.Id == id).First());

            _serviceContext.SaveChanges();

        }

        List<OrderEntity> IOrderLogic.GetSelectedOrder(int id)
        {
            var selectedOrder = _serviceContext.Set<OrderEntity>()
               .Where(o => o.Id == id).ToList();
            return selectedOrder;
        }
    }
 }

