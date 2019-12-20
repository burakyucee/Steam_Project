using Steam_Project.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Project.DAL.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=Steam_Project;Integrated Security = True;";

            //Database.Connection.ConnectionString = "Server=.;Database=Steam_Project;uid=sa;pwd=123;";
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<Game> Games { get; set; }

    }
}
