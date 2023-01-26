using System;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BuyerEntity 
    {
        public BuyerEntity() { }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }

    }
}
