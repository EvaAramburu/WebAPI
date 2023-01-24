using System;
using System.Collections.Generic;
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
            IsAdmin = false;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime Birthday { get; set; }

        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; private set; }
        public bool IsAdmin { get; private set; }
        private string Password { get; set; }
        private string EncryptedPassword { get; set; }
    }
}
