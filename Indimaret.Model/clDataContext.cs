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
            //Database.SetInitializer(new clInitializer());
            Database.SetInitializer<clDataContext>(null);
        }
        public virtual DbSet<clBarang> Barang { get; set; }

        public virtual DbSet<MasterTransaction> MasterTransaction { get; set; }

        public virtual DbSet<DetailTransaction> DetailTransaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
