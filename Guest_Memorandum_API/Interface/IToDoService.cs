using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos;
using Guest_Memorandum_Shared.Parameters;

namespace Guest_Memorandum_API.Interface
{
    public interface IToDoService : IBaseService<ToDoDto>
    {
        Task<ApiResponse> GetAllAsync(ToDoParameter query);

        Task<ApiResponse> Summary();
    }
}