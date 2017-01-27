using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Obrazcovo
{
    public class DbContextObr : DbContext
    {
        public DbContextObr()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Models.Thread> Threads {get; set;}
    }
}