using Data;
using Entities.Entities;
using Logic.ILogic;
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
        public void InsertAdmin(AdminEntity admin)
        {
            _serviceContext.Admins.Add(admin);
            _serviceContext.SaveChanges();
        }
        List<AdminEntity> IAdminLogic.GetAdmin()
        {
            return _serviceContext.Set<AdminEntity>().ToList();
        }
    }
}
