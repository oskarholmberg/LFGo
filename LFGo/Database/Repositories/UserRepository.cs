using LFGo.Models;
using System.Data.Entity;

namespace LFGo.Database.Repositories
{
    public class UserRepository : Repository<ApplicationUser>
    {
        public UserRepository(DbContext dataContext)
            : base(dataContext)
        {
        }

        public string GetTeamURL(ApplicationUser user)
        {
            Team team = dataContext.Set<Team>().Find(user.TeamId);

            return team != null ? team.LogoUrl : "No team found";
        }
    }
}