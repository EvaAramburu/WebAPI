using Entities.Entities;
using Logic.ILogic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerLogic _buyerLogic;

        public BuyerService(IBuyerLogic buyerLogic)
        {
            _buyerLogic = buyerLogic;
        }
        public int InsertBuyer(BuyerEntity buyer)
        {
            _buyerLogic.InsertBuyer(buyer);
            return buyer.Id;
        }
    }
}
