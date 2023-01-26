using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminLogic _adminLogic; 

        public AdminService(IAdminLogic adminLogic) 
        {
            _adminLogic= adminLogic;
        }
        public int InsertAdmin(AdminEntity admin)
        {
            _adminLogic.InsertAdmin(admin);
            return admin.Id;
        }

        public List<AdminEntity> GetAdmin()
        {
            return _adminLogic.GetAdmin();
        }
    }
}
