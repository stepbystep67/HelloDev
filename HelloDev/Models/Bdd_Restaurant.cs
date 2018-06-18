using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.Entity;


namespace HelloDev.Models
{


    public class Bdd_Restaurant : DbContext
    {


        public DbSet<Restaurant> Restaurants { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Bdd_Restaurant>() );
            base.OnModelCreating(modelBuilder);

        }

    }

}