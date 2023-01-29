using Entities.Entities;
using Resources;

namespace WebAPI.IService
{
    public interface IUserService
    {
        int InsertUser(UserEntity user);
        List<UserEntity> GetAllUsers();
        List<UserEntity> GetSelectedUser(UserFilter userFilter);
        void DeactivateUser(int id);
    }
}
