using Entities.Entities;
using Resources;
using Resources.Requests;

namespace WebAPI.IService
{
    public interface IUserService
    {
        int InsertUser(UserRequest userRequest);
        List<UserEntity> GetAllUsers();
        List<UserEntity> GetSelectedUser(int id);
        void DeactivateUser(int id);
        void DeleteUser(int id);
        void UpdateUser(UserEntity user);
    }
}
