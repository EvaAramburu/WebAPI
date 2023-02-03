using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.Requests;
using WebAPI.IService;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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

        public int InsertAdmin([FromBody] AdminEntity admin)
        {
            return _adminService.InsertAdmin(admin);
        }

        [HttpGet(Name = "GetAllAdmins")]
        public List<AdminEntity> GetAllAdmins()
        {
            return _adminService.GetAllAdmins();
        }

        [HttpDelete(Name = "DeactivateAdmin")]
        public void DeactivateAdmin([FromQuery] int id)
        {
            _adminService.DeactivateAdmin(id);
        }
    }
}
