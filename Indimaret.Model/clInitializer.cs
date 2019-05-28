using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class clInitializer : DropCreateDatabaseAlways<clDataContext>
    {
        protected override void Seed(clDataContext context)
        {
            List<clBarang> barang = new List<clBarang>();
            barang.Add(new clBarang { TokoID = 1, KodeBarang = "KD001", NamaBarang = "Bodrex", AsalPabrik = "Jakarta", JmlBarang = 50, LamaKadaluarsa = 30 });
            base.Seed(context);

            foreach (var item in barang)
            {
                context.Barang.Add(item);
            }
        }
    }
}
