using LFGo.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LFGo.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<LFGo.Models.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<LFGo.Models.Group> Groups { get; set; }

    }
}