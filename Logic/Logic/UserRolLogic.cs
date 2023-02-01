using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserRolLogic : BaseContextLogic, IUserRolLogic
    {
        public UserRolLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertUserRol(UserRol userRol)
        {
            _serviceContext.UserRol.Add(userRol);
            _serviceContext.SaveChanges();
            return userRol.Id; 
        }
    }
}
