using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniETicaret.MvcWeb.Models
{
    public class UrunModel
    {
        public int Id { get; set; }

        public string Isim { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public string Resim { get; set; }

        public int KategoriId { get; set; }
    }
}