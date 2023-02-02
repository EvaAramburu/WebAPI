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
        public int InsertAdmin(AdminRequest adminRequest)
        {
            var newAdminRequest = adminRequest.ToAdminEntity();
            return _adminLogic.InsertAdmin(newAdminRequest);
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
