using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
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
    }
}
