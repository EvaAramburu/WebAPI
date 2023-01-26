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
    public class BuyerLogic : BaseContextLogic, IBuyerLogic
    {
        public BuyerLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertBuyer(BuyerEntity buyer)
        {
            _serviceContext.Buyers.Add(buyer);
            _serviceContext.SaveChanges();
        }

        List<BuyerEntity> IBuyerLogic.GetBuyers()
        {
            return _serviceContext.Set<BuyerEntity>().ToList();
        }
    }
}
