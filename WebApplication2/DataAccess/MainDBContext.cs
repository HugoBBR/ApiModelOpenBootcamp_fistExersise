using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.DataModels;

namespace WebApplication2.DataAccess
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
