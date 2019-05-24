
using Microsoft.EntityFrameworkCore;

namespace DBModels
{
    public class ForumDB : DbContext
    {
        public ForumDB(DbContextOptions<ForumDB> options)
            : base(options)
        {

        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
