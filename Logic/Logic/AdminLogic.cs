using Data;
using Entities.Entities;
using Logic.ILogic;
using Resources.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class AdminLogic : BaseContextLogic, IAdminLogic
    {
        public AdminLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public int InsertAdmin(AdminEntity admin)
        {
            _serviceContext.Admins.Add(admin);
            _serviceContext.SaveChanges();
            return admin.UserId;
        }
        List<AdminEntity> IAdminLogic.GetAllAdmins()
        {
            return _serviceContext.Set<AdminEntity>().ToList();
        }
        void IAdminLogic.DeactivateAdmin(int id) 
        {
            var adminToDeactivate = _serviceContext.Set<AdminEntity>().Where(a => a.Id == id).First();
            adminToDeactivate.IsActive = false;

            _serviceContext.SaveChanges();

        }

    }
}
