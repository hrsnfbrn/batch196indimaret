using Indimaret.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Repo
{
    public  class clBarangRepo
    {
        public static List <clBarang> GetAll()
        //kalo error, biasanya karena belum ada return
        {
            List<clBarang> result = new List<clBarang>();
            using (clDataContext db = new clDataContext())
            {
                result = db.Barang.ToList();
            }
            return result;
        }

        public static Boolean Createbarang(clBarang barang)
        {
            try
            {
                using (clDataContext db = new clDataContext())
                {
                    db.Barang.Add(barang);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Boolean Deletebarang(int ID)
        {
            try
            {
                clBarang dep;
                using (clDataContext db = new clDataContext())
                {
                    dep = db.Barang.Where(d => d.ID == ID).First();
                    db.Entry(dep).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static clBarang GetByID (int ID)
        {
                clBarang barang=new clBarang();
                using (clDataContext db = new clDataContext())
                {
                    barang = db.Barang.Where(d => d.ID == ID).First();
                    return barang;
                }
     
        }

        public static Boolean UpdateBarang(clBarang barang)
        {
            try
            {
                using (clDataContext db = new clDataContext())
                {
                    db.Entry(barang).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
