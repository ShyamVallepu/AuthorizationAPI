using AuthorizationAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorizationAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Credentials { get; set; }
    }
}
