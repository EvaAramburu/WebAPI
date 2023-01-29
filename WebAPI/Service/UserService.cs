using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Resources;
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
        public List<UserEntity> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public List<UserEntity> GetSelectedUser(UserFilter userFilter)
        {
            return _userLogic.GetSelectedUser(userFilter);
        }
        public void DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }

    }
}
