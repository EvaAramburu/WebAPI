using Entities.Entities;
using Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        void InsertUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        List<UserEntity> GetSelectedUser(UserFilter userFilter);
        void DeactivateUser(int id);
    }
}
