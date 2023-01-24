using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ItemEntity
    {
        public ItemEntity()
        { 
            IsActive = true; 
            IsPublic = true; 
        }
    public int Id { get; set; }
    public Guid IdWeb { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public int Stock { get; set; }
    private DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get; private set; }
    public bool IsPublic { get; private set; }
    public decimal RawPrice { get; set; }
    }
}