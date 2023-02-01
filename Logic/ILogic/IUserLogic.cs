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
        int InsertUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        List<UserEntity> GetSelectedUser(int id);
        void DeactivateUser(int id);
        void DeleteUser(int id);
        void UpdateUser(int id, UserEntity user);
    }
}
