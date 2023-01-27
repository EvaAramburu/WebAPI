using Entities.Entities;

namespace WebAPI.IService
{
    public interface IAdminService
    {
        int InsertAdmin(AdminEntity admin);
        List<AdminEntity> GetAllAdmins();
    }
}
