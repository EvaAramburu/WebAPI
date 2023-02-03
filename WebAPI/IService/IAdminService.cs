using Entities.Entities;
using Resources.Requests;

namespace WebAPI.IService
{
    public interface IAdminService
    {
        int InsertAdmin(AdminEntity admin);
        List<AdminEntity> GetAllAdmins();
        void DeactivateAdmin(int id);
    }
}
