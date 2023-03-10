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
        public List<BuyerEntity> GetAllBuyers()
        {
            return _serviceContext.Set<BuyerEntity>().ToList();
        }

         void IBuyerLogic.DeactivateBuyer(int id)
        {
            var buyerToDeactivate = _serviceContext.Set <BuyerEntity>().Where(b => b.Id == id).First();
            buyerToDeactivate.IsActive = false; 
            _serviceContext.SaveChanges();
        }

    }
}
