namespace Documents.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Documents.App_Data.DocumentsDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Documents.App_Data.DocumentsDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.Name,
              new Person { Name = "Andrew Peters" },
              new Person { Name = "Brice Lambson" },
              new Person { Name = "Rowan Miller" }
            );

        }
    }
}
