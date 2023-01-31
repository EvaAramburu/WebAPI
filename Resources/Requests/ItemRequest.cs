using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Requests
{
    public class ItemRequest
    {  
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Scent { get; set; }
        public string Brand { get; set; }
        public decimal RawPrice { get; set; }

        public ItemEntity ToItemEntity()
        {
            var item = new ItemEntity();

            item.Name = Name;
            item.Weight = Weight;
            item.Scent = Scent;
            item.Brand = Brand;
            

            item.Stock = 99;
            item.UpdateDate = DateTime.Now;
            item.IsActive = true;
            item.IsPublic = true;
            return item;
        }
    }
}
