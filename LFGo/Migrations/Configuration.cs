namespace LFGo.Migrations
{
    using LFGo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LFGo.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LFGo.Database.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(
                t => t.Name,
                new Team { Name = "No Team", LogoUrl = ""},
                new Team { Name = "Valor", LogoUrl = "/Assets/Images/valor-logo.png"},
                new Team { Name = "Mystic", LogoUrl = "/Assets/Images/mystic-logo.png" },
                new Team { Name = "Instinct", LogoUrl = "/Assets/Images/instinct-logo.png" }
            );
        }
    }
}
