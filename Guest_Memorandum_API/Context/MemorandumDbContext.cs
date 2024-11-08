using Guest_Memorandum_API.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Guest_Memorandum_API.Context
{
    public class MemorandumDbContext : DbContext
    {
        public MemorandumDbContext(DbContextOptions<MemorandumDbContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Memo> Memo { get; set; }
    }
}