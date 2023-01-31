using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using Resources;
using Resources.Requests;
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
        public int InsertUser(UserRequest userRequest)
        {

            var newUserRequest = userRequest.ToUserEntity();
            return _userLogic.InsertUser(newUserRequest);

            //_userLogic.InsertUser(user);
            //return user.Id;
        }
        public List<UserEntity> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }

        public List<UserEntity> GetSelectedUser(int id)
        {
            return _userLogic.GetSelectedUser(id);
        }
        public void DeactivateUser(int id)
        {
            _userLogic.DeactivateUser(id);
        }
        public void DeleteUser(int id)
        {
            _userLogic.DeleteUser(id);
        }

        //public void UpdateUser(UserEntity user)
        //{
        //    _userLogic.UpdateUser(user);
        //}
    }
}
