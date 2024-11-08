using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos.Account;

namespace Guest_Memorandum_API.Interface
{
    public interface ILoginService
    {
        Task<ApiResponse> LoginAsync(string Account, string Password);

        Task<ApiResponse> Resgiter(ResgiterDto user);
    }
}