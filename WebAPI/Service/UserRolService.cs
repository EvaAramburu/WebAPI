using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Resources.Requests;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class UserRolService : IUserRolService
    {
        private readonly IUserRolLogic _userRolLogic;

        public UserRolService(IUserRolLogic userRolLogic)
        {
            _userRolLogic = userRolLogic;
        }

        public List<UserRol> GetAllUserRol()
        {
            return _userRolLogic.GetAllUserRol();
        }

        int IUserRolService.InsertUserRol(UserRol userRol)
        {
            _userRolLogic.InsertUserRol(userRol);
            return userRol.Id; 
        }
    }
        
}
