using System;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AdminEntity 
    {
    public AdminEntity() {
            IsActive = true;
        }

    
    public int Id { get; set; }

    public int IdRol { get; set; }
    public string Name { get; set; }
    public string CompanyName { get; set; }
    public string CompanyEmail { get; set; } 
    public bool IsActive { get; set; }

    }

}
