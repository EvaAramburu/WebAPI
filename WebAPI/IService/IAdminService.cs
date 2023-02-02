using Entities.Entities;
using Resources.Requests;

namespace WebAPI.IService
{
    public interface IAdminService
    {
        int InsertAdmin(AdminRequest adminRequest);
        List<AdminEntity> GetAllAdmins();
        void DeactivateAdmin(int id);
    }
}
