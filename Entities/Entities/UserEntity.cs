using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserEntity
    {
        public UserEntity()
        {
            IsActive = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        
        public string Document { get; set; }
        
        public string Name { get; set; }
        
        public string UserEmail { get; set; }
        public int Phone { get; set; }
        public DateTime Birthday { get; set; }
        //public int IdRol { get; set; }
        [Required]
        public string password { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; } 
    }
}
