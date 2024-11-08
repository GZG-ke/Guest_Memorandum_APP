using Microsoft.EntityFrameworkCore;

namespace Guest_Memorandum_API.Context.Repositorys
{
    public class DbContextProvider : IDbContextProvider
    {
        private readonly MemorandumDbContext _context;

        public DbContextProvider(MemorandumDbContext context)
        {
            _context = context;
        }

        public DbContext GetDbContext()
        {
            return _context;
        }
    }
}