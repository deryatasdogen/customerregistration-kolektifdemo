using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using KolektifHouse.DAL.Entity;

namespace KolektifHouse.DAL.Base
{
    public class KolektifContext : DbContext
    {
        public KolektifContext() : base("KolektifContext")
        {
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
