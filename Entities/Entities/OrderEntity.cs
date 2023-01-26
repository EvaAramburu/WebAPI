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
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public int Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsPaid { get; private set; }
        public bool IsShipped { get; private set; }

    }
}
