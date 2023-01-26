using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using WebAPI.IService;

namespace WebAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserEntity user)
        {
            _userLogic.InsertUser(user);
            return user.Id;
        }
        public List<UserEntity> GetUsers()
        {
            return _userLogic.GetUsers();
        }
    }
}
