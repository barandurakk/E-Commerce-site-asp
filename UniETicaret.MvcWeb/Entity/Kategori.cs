using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniETicaret.MvcWeb.Entity
{
    public class Kategori
    {
        public int Id { get; set; }

        //Data annotations
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength: 20, ErrorMessage = "en fazla 20 karakter girebilirsiniz.")]
        public string Isim { get; set; }

        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }

        public List<Urun> Urunler { get; set; }
    }
}