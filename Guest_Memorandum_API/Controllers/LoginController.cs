using Guest_Memorandum_API.Interface;
using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos.Account;
using Microsoft.AspNetCore.Mvc;

namespace Guest_Memorandum_API.Controllers
{
    /// <summary>
    /// 账户控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService service;

        public LoginController(ILoginService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<ApiResponse> Login([FromBody] LoginDto param) =>
            await service.LoginAsync(param.Account, param.PassWord);

        [HttpPost]
        public async Task<ApiResponse> Resgiter([FromBody] ResgiterDto param) =>
            await service.Resgiter(param);
    }
}