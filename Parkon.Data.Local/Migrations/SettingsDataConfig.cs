using Prkn.Data.Local;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Prkn.Data.Local.Migrations
{
    internal sealed class SettingsDataConfig : DbMigrationsConfiguration<SettingsDataContext>
    {
        public SettingsDataConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Myproject";
        }

        protected override void Seed(SettingsDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
