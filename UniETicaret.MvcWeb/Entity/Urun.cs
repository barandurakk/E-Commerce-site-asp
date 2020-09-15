using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UniETicaret.MvcWeb.Entity
{
    public class Urun
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Isim { get; set; }

        [DisplayName("Ürün Açıklama")]
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public string Resim { get; set; }
        public bool Satistami { get; set; }
        public bool Anasayfada { get; set; }


        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}