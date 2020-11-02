namespace BitcoinLogger.Database.Migrations
{
    using BitcoinLogger.Entites;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BitcoinLogger.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BitcoinLogger.Database.ApplicationDbContext context)
        {


            var PasswordHash = new PasswordHasher();


            
            if (!context.Users.Any(x => x.UserName == "dm@mail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "Dimitris",
                    Email = "dm@mail.com",
                    PasswordHash = PasswordHash.HashPassword("D1m1tr1s!")
                };
                manager.Create(user);    
            }


            if (!context.Users.Any(x => x.UserName == "pf@mail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    UserName = "Panagiotis",
                    Email = "pf@mail.com",
                    PasswordHash = PasswordHash.HashPassword("Pan0s!")
                };
                manager.Create(user);
            }


            context.Users.AddOrUpdate(x => x.Email);
        }
    }
}
