using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources.Requests
{
        public class AdminRequest
        {
            public AdminRequest() { }
            public string Name { get; set; }
            public string CompanyName { get; set; }
            public string CompanyEmail { get; set; }

        public AdminEntity ToAdminEntity()
        {
            var admin = new AdminEntity();

            admin.Name = Name;
            admin.CompanyName = CompanyName;
            admin.CompanyEmail = CompanyEmail;
            

            admin.IdRol = 1; 

            return admin;
        }
    }
 }

