using Entities.Entities;
using Resources.Requests;

namespace WebAPI.IService
{
    public interface IUserRolService
    {
        int InsertUserRol(UserRol userRol);
        List<UserRol> GetAllUserRol();
    }
}
