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
            Bitcoin b1 = new Bitcoin() { Id = 1, Price = 1366, Source = "Dymmy content from Seeding", Date = DateTime.UtcNow};
            Bitcoin b2 = new Bitcoin() { Id = 2, Price = 1359, Source = "Dymmy content from Seeding", Date = DateTime.UtcNow};
            Bitcoin b3 = new Bitcoin() { Id = 3, Price = 1355, Source = "Dymmy content from Seeding", Date = DateTime.UtcNow};
            Bitcoin b4 = new Bitcoin() { Id = 4, Price = 1351, Source = "Dymmy content from Seeding", Date = DateTime.UtcNow};
            
            context.bitcoins.AddOrUpdate(x => x.Id, b1,b2,b3,b4);
        }
    }
}
