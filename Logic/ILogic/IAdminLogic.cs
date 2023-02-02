using Entities.Entities;
using Resources.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IAdminLogic
    {
        int InsertAdmin(AdminEntity admin);
        List<AdminEntity> GetAllAdmins();
        void DeactivateAdmin(int id);
    }
}
