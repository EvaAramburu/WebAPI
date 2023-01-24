using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class OrderEntity
    { 
        public OrderEntity()
        {
            IsPaid = false; 
            IsShipped = false; 
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public bool IsPaid { get; private set; }
        public bool IsShipped { get; private set; }
    }
}
