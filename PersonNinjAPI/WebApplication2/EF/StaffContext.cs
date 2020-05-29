using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.EF
{
    public class StaffContext: DbContext
    {
        public StaffContext() : base()
        {
            Database.SetInitializer<StaffContext>(new StaffInitializer());
            Database.Initialize(true);
        }

        public DbSet<Person> People { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new StaffInitializer());
        }
    }
}