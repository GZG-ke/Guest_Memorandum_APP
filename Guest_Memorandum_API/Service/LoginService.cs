using AutoMapper;
using Guest_Memorandum_API.Context;
using Guest_Memorandum_API.Context.Models;
using Guest_Memorandum_API.Context.Repositorys;
using Guest_Memorandum_API.Interface;
using Guest_Memorandum_API.UnitOfWorks;
using Guest_Memorandum_Shared;
using Guest_Memorandum_Shared.Dtos;
using Guest_Memorandum_Shared.Dtos.Account;

namespace Guest_Memorandum_API.Service
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork work;
        private readonly IMapper mapper;
        private readonly IRepository<MemorandumDbContext, User> _repository;

        public LoginService(IUnitOfWork work, IMapper mapper, IRepository<MemorandumDbContext, User> repository)
        {
            this.work = work;
            this.mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse> LoginAsync(string Account, string Password)
        {
            try
            {
                Password = Password.GetMD5();

                var model = await _repository.GetFirstOrDefaultAsync(predicate:
                    x => (x.Account.Equals(Account)) &&
                    (x.PassWord.Equals(Password)));

                if (model == null)
                    return new ApiResponse("账号或密码错误,请重试！");

                return new ApiResponse(true, new UserDto()
                {
                    Account = model.Account,
                    UserName = model.UserName,
                    Id = model.Id
                });
            }
            catch (Exception ex)
            {
                return new ApiResponse(false, "登录失败！");
            }
        }

        public async Task<ApiResponse> Resgiter(ResgiterDto user)
        {
            try
            {
                var model = mapper.Map<User>(user);
                var userModel = await _repository.GetFirstOrDefaultAsync(predicate: x => x.Account.Equals(model.Account));

                if (userModel != null)
                    return new ApiResponse($"当前账号:{model.Account}已存在,请重新注册！");

                model.CreateDate = DateTime.Now;
                model.PassWord = model.PassWord.GetMD5();
                await _repository.InsertAsync(model);

                if (await work.SaveChangesAsync() > 0)
                    return new ApiResponse(true, model);

                return new ApiResponse("注册失败,请稍后重试！");
            }
            catch (Exception ex)
            {
                return new ApiResponse("注册账号失败！");
            }
        }
    }
}