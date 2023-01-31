using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Filters
{
    public class OrderFilter
    { 
        public OrderFilter()
         {
             IsPaid = true; 
            IsShipped= true;
         }
    
        public bool IsPaid { get; set; }
        public bool IsShipped { get; set; }
    }
}
