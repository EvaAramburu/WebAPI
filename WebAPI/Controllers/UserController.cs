using Azure.Identity;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resources;
using Resources.Requests;
using System.Security.Authentication;
using WebAPI.IService;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        //private ISecurityService _securityService;
        //private ISecurityService? securityService;

        public UserController(IUserService userService)
        {
      
            _userService = userService;
            
        }

        [HttpPost(Name = "InsertUser")]
        public int InsertUser([FromBody] UserRequest userRequest)
        {
                return _userService.InsertUser(userRequest);  
        }

        [HttpGet(Name = "GetAllUsers")]
        public List<UserEntity> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet(Name = "GetSelectedUser")]
        public List<UserEntity> GetSelectedUser([FromQuery] int id)
        {
            //var selectedItems = _serviceContext.Set<ItemEntity>().Where(i => i.IsActive).ToList();

            //var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            //if (validCredentials == true)
            //{

            return _userService.GetSelectedUser(id);
            //}
            //else
            //{
            // throw new InvalidCredentialException();
            //}
        }

        [HttpDelete(Name = "DeactivateUser")]

        public void DeactivateUser([FromQuery] int id)
        {

            //var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            //if (validCredentials == true)
            //{
            _userService.DeactivateUser(id);


            //}
            //else
            //{
            //throw new InvalidCredentialException();
            //}
        }

        [HttpDelete(Name = "DeleteUser")]

        public void DeleteUser([FromQuery] int id)
        {
            _userService.DeleteUser(id);

        }

        [HttpPatch(Name = "UpdateUser")]

        public void UpdateUser(UserEntity user)
        {
            _userService.UpdateUser(user);
        }
    }
}
