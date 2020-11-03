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
           
        }
    }
}
