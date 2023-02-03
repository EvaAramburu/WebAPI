using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Requests
{
    public class UserRequest
    {
        
        public string Document { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public DateTime Birthday { get; set; }
        public int Phone { get; set; }
        
        //public int IdRol { get; set; }
        public string Password { get; set; }


        public UserEntity ToUserEntity()
        {
            var user = new UserEntity();

         user.Document = Document;
         user.Name = Name;
         user.UserEmail = UserEmail;
         user.Birthday = Birthday;
         user.Phone = Phone;
         //user.IdRol = IdRol;
         user.password = Password;


         user.InsertDate = DateTime.Now;
         user.UpdatedDate = DateTime.Now;
         user.IsActive = true;

            return user;
        }
    }
}
