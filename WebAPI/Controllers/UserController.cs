using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources;
using System.Security.Authentication;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpPost(Name = "InsertUser")]

        public int Post([FromBody] UserEntity user)
        {
            return _userService.InsertUser(user);
        }

        [HttpGet(Name = "GetUsers")]
        public List<UserEntity> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet(Name = "GetSelectedUser")]
        public List<UserEntity> GetSelectedUser([FromQuery] UserFilter userFilter)
        {
            //var selectedItems = _serviceContext.Set<ItemEntity>().Where(i => i.IsActive).ToList();

            //var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            //if (validCredentials == true)
            //{

            return _userService.GetSelectedUser(userFilter);
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

        
    }
}
