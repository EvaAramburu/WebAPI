using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Resources.Requests;
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
            return _adminLogic.InsertAdmin(admin);
        }

        public List<AdminEntity> GetAllAdmins()
        {
            return _adminLogic.GetAllAdmins();
        }
        public void DeactivateAdmin(int id)
        {
            _adminLogic.DeactivateAdmin(id);
        }
    }
}
