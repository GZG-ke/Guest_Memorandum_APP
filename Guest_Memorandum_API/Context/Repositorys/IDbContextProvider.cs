using Microsoft.EntityFrameworkCore;

namespace Guest_Memorandum_API.Context.Repositorys
{
    public interface IDbContextProvider
    {
        DbContext GetDbContext();
    }
}