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
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public void InsertUser(UserEntity user)
        {
            _serviceContext.Users.Add(user);
            _serviceContext.SaveChanges();
        }

        List<UserEntity> IUserLogic.GetAllUsers()
        {
            return _serviceContext.Set<UserEntity>().ToList();
        }

     
    }
}
