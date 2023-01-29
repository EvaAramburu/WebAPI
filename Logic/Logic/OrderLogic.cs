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
    }
 }

