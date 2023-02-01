using Data;
using Logic.ILogic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class SecurityService : ISecurityService
    {
        //private readonly ServiceContext _serviceContext;
        private readonly ISecurityLogic _securityLogic;
        public SecurityService(ServiceContext serviceContext, ISecurityLogic securityLogic)
        {
            _securityLogic = securityLogic;
        }

        bool ISecurityService.ValidateUserCredentials(string userName, string userPassWord, int idRol)
        {
            return _securityLogic.ValidateUserCredentials(userName, userPassWord, idRol);
        }
       
    }
}
