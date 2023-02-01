using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderEntity
    { 
        public OrderEntity()
        {
            IsPaid = false; 
            IsShipped = false;
            IsActive = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public int ItemId { get; set; }
        public int BuyerId { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsPaid { get;  set; }
        public bool IsShipped { get;  set; }
        public bool IsActive { get;  set; }

        //public int ProductId { get; set; }
        //public ItemEntity item { get; set; }

        //public ICollection<BuyerEntity> Buyers { get; set; }

        //public int UserId { get; set; }
        //public UserEntity Users { get; set; }
    }
}
