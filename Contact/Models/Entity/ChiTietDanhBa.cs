using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Models.Entity
{
    public class ChiTietDanhBa
    {
        private static Form1 form1 = new Form1();
        public ChiTietDanhBa()
        {

        }
        [Key]
        public string TenGoi { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string TenNhom { get; set; }
        [ForeignKey("TenNhom")]
        public virtual NhomDanhBa NhomDanhBa { get; set; }
        public static List<ChiTietDanhBa> GetListFromDB(string Tennhom)
        {
            return new KiemTraDBContext().ChiTietDanhBaDbSet.Where(e => e.TenNhom == Tennhom).ToList();
        }
        //aasdasd
        public static void Remove(ChiTietDanhBa ten)
        {
            var db = new KiemTraDBContext();
            var ojbSV = db.ChiTietDanhBaDbSet.Where(e => e.TenGoi == ten.TenGoi).FirstOrDefault();
            if (ojbSV != null)
            {
                db.ChiTietDanhBaDbSet.Remove(ojbSV);

            }
            db.SaveChanges();
        }
        public static void Add(ChiTietDanhBa nhom)
        {
            var db = new KiemTraDBContext();
            db.ChiTietDanhBaDbSet.Add(nhom);
            db.SaveChanges();

        }
        public static void Edit(ChiTietDanhBa ten)
        {
            using (var db = new KiemTraDBContext())
            {
                var result = db.ChiTietDanhBaDbSet.SingleOrDefault(b => b.TenGoi == ten.TenGoi);
                if (result != null)
                {
                    result.TenNhom = ten.TenNhom;
                    result.SDT = ten.SDT;
                    result.Email = ten.Email;
                    db.SaveChanges();
                    form1.Load();
                }
            }
        }
    }
}
