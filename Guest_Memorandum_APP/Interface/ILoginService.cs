using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos.Account;

namespace Guest_Memorandum_APP.Interface
{
    public interface ILoginService
    {
        Task<ApiResponse> Login(LoginDto user);

        Task<ApiResponse> Resgiter(ResgiterDto user);
    }
}