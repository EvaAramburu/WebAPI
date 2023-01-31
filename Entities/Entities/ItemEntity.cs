using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
    [Required]
    public string Name { get; set; }
    [Required]
    public int Weight { get; set; }
    [Required]
    public string Scent { get; set; }
    public string Brand { get; set; }
    public int Stock { get; set; }
    public decimal RawPrice { get; set; }
    //public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool IsActive { get;  set; }
    public bool IsPublic { get; set; }

    }
}