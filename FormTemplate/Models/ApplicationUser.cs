using Microsoft.EntityFrameworkCore;

namespace FormTemplate.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options) { }

        public DbSet<UserReg> UserRegistration { get; set; }
    }
}
