using Entities.Entities;

namespace WebAPI.IService
{
    public interface IBuyerService
    {
        int InsertBuyer(BuyerEntity buyer);

        List<BuyerEntity> GetAllBuyers();
    }
}
