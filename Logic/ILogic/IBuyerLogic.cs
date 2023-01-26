using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IBuyerLogic
    {
        void InsertBuyer(BuyerEntity buyer);
        List<BuyerEntity> GetBuyers();
    }
}
