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
        [Required]
        public string Document { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        public int Phone { get; set; }
        public DateTime Birthday { get; set; }
        //[Required]
        //public int IdRol { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        
        

        //public ICollection<OrderEntity> Orders { get; set; }
        
    }
}
