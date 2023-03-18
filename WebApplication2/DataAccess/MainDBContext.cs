using Microsoft.EntityFrameworkCore;
using APIOpenBootcamp.Models.DataModels;

namespace APIOpenBootcamp.DataAccess
{
    public class MainDBContext:DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {

        }
        // TODO: Add DbSets

        public DbSet<User>? Users { get; set; }

    }
}
