using Prkn.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prkn.Data;
using Prkn.Model.DbSettings.Entities;
using Prkn.Data.Local.Migrations;
using System.Data.Entity.Infrastructure;

namespace Prkn.Data.Local
{
    public class SettingsDataContext : DbContext
    {
        public SettingsDataContext() : base("name=SettingsDataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SettingsDataContext, SettingsDataConfig>("SettingsDataContext"));
            Configuration.ProxyCreationEnabled = false;
            //// Not initialize database
            //// Database.SetInitializer<ProjectDatabase>(null);
            //// Database initialize
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SettingsDataContext>);
            //Database.SetInitializer<SettingsDataContext>(new DbInitializer());
            //using (SettingsDataContext db = new SettingsDataContext())
            //db.Database.Initialize(false);
        }


        public virtual DbSet<Prg> Prg { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Logs2> Logs2 { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}

        class DbInitializer : DropCreateDatabaseAlways<SettingsDataContext>
        {
            protected override void Seed(SettingsDataContext context)
            {
                //// insert some file generes
                //context.FilmGeneres.Add(new FilmGenere()
                //{
                //    Name = "Action"
                //});
                //context.FilmGeneres.Add(new FilmGenere()
                //{
                //    Name = "SciFi"
                //});
                //context.FilmGeneres.Add(new FilmGenere()
                //{
                //    Name = "Comedy"
                //});
                //context.FilmGeneres.Add(new FilmGenere()
                //{
                //    Name = "Romance"
                //});
                //// some roles
                //context.Roles.Add(new Role()
                //{
                //    Name = "Lead"
                //});
                //context.Roles.Add(new Role()
                //{
                //    Name = "Supporting"
                //});
                //context.Roles.Add(new Role()
                //{
                //    Name = "Background"
                //});
                //// some actors
                //context.Actors.Add(new Actor()
                //{
                //    Name = "Chris",
                //    Surname = "Pine",
                //    Note = "Born in Los Angeles, California"
                //});
                //context.Actors.Add(new Actor()
                //{
                //    Name = "Zachary",
                //    Surname = "Quinto",
                //    Note = "Zachary Quinto graduated from Central Catholic High School in Pittsburgh"
                //});
                //context.Actors.Add(new Actor()
                //{
                //    Name = "Tom",
                //    Surname = "Cruise"
                //});
                //// producers
                //context.Producers.Add(new Producer()
                //{
                //    FullName = "J.J. Abrams",
                //    Email = "jj.adams@producer.com",
                //    Note = "Born: Jeffrey Jacob Abrams"
                //});
                base.Seed(context);
            }
        }
    }
}
