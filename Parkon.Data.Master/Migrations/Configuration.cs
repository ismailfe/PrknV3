using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Prkn.Data.Master.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PrknDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Myproject2";
        }

        protected override void Seed(PrknDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
