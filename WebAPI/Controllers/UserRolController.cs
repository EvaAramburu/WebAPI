﻿using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.Requests;
using System.Security.Authentication;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserRolController : ControllerBase
    {
        private readonly ILogger<UserRolController> _logger;
        private readonly IUserRolService _userRolService;
        private ISecurityService _securityService;

        public UserRolController(ILogger<UserRolController> logger, IUserRolService userRolService)
        {
            _logger = logger;
            _userRolService = userRolService;
        }

        [HttpPost(Name = "InsertUserRol")]
        public int InsertUserRol([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] UserRol userRol)
        {

            var validCredentials = _securityService.ValidateUserCredentials(userName, userPassword, 1);
            if (validCredentials == true)
            {
                return _userRolService.InsertUserRol(userRol);
            }
            else
            {
                throw new InvalidCredentialException();
            }


        }
    }
}
