using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;

        public AdminController(ILogger<AdminController> logger, IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }
        [HttpPost(Name = "InsertAdmin")]

        public int Post([FromBody] AdminEntity admin)
        {
            return _adminService.InsertAdmin(admin);
        }

        [HttpGet(Name = "GetAdmins")]
        public List<AdminEntity> GetAdmins()
        {
            return _adminService.GetAdmins();
        }
    }
}
