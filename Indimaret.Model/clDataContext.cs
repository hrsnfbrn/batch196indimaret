using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class clDataContext : DbContext
    {
        public clDataContext() : base("Name=IndimaretConn")
        {
            Database.SetInitializer <clDataContext> (null);
            //selesaikan initializer terlebih dahulu
        }
        public virtual DbSet<clBarang> Barang { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
