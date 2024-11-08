using Guest_Memorandum_APP.Interface;
using Guest_Memorandum_Shared.Dtos;
using MyToGuest_Memorandum_APPDo.Service;

namespace Guest_Memorandum_APP.Service
{
    public class MemoService : BaseService<MemoDto>, IMemoService
    {
        public MemoService(HttpRestClient client) : base(client, "Memo")
        {
        }
    }
}