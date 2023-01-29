using Entities.Entities;
using Resources;

namespace WebAPI.IService
{
    public interface IUserService
    {
        int InsertUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        List<UserEntity> GetSelectedUser(int id);
        void DeactivateUser(int id);
        void DeleteUser(int id);
    }
}
