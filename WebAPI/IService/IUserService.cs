using Entities.Entities;

namespace WebAPI.IService
{
    public interface IUserService
    {
        int InsertUser(UserEntity user);
        List<UserEntity> GetAllUsers();
    }
}
