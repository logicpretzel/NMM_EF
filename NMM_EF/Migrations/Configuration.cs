namespace NMM_EF.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NMM_EF.Models.NMMDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NMM_EF.Models.NMMDB";
        }

        protected override void Seed(NMM_EF.Models.NMMDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
           

            context.Breweries.AddOrUpdate(
                 b => b.Name ,
                 new Brewery { Name = "Johnny's Hops", City="Empire", State = "MI", Address="101 Main St", Zip="49630" },
                 new Brewery { Name = "Billy's Brew", City = "Empire", State = "MI", Address = "201 Main St", Zip = "49630" },
                 new Brewery { Name = "Suzy's Suds", City = "Empire", State = "MI", Address = "301 Main St", Zip = "49630" }

               );


        }
    }
}
