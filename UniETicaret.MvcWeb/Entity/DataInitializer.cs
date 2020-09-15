using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniETicaret.MvcWeb.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext> //Modelde değişiklik olursa database'yi silip baştan yüklüyor
    {
        protected override void Seed(DataContext context) //üstteki şart sağlanırsa bu method çalışıyor. Ve datacontexti override ediyor.
        {

            List<Kategori> kategoriler = new List<Kategori>()  //Databaseyi Inıtilazer çalıştığında dolduralacakları tanımlıyoruz
            {
                new Kategori(){Isim="Kamera", Aciklama="Kamera Ürünleri"},
                new Kategori(){Isim="Bilgisayar", Aciklama="Bilgisayar Ürünleri"},
                new Kategori(){Isim="Televizyon", Aciklama="Televizyon Ürünleri"},
                new Kategori(){Isim="Telefon", Aciklama="Telefon Ürünleri"},
                new Kategori(){Isim="Mutfak Robotları", Aciklama="Mutfak Robotları Ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);   //veritabanına kategori nesnelerini tek tek ekledik
            }
            context.SaveChanges();  //Veri tabanını kaydettik


            List<Urun> urunler = new List<Urun>() //Databaseyi Inıtilazer çalıştığında dolduralacakları tanımlıyoruz
            {

                new Urun(){ Isim = "Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 1, Resim="1.jpg", Anasayfada=true},
                new Urun(){ Isim = "Canon Eos 100D 18-55 mm DC Profesyonel Fotoğraf Makines",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 1, Resim="1.jpg", Anasayfada=true},
                new Urun(){ Isim = "Canon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =1200 , Stok =500 , Satistami =false , KategoriId = 1, Resim="1.jpg", Anasayfada=true},
                new Urun(){ Isim = "Canon Eos 100D 18-55 mm IS STM Kit DSLR Fotoğraf Makinesi",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 1, Resim="1.jpg", Anasayfada=true},
                new Urun(){ Isim = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =1200 , Stok =500 , Satistami =false , KategoriId = 1, Resim="1.jpg", Anasayfada=true},

                new Urun(){ Isim = "Dell Inspiron 5567 Intel Core i5 7200U 8GB 1TB R7 M445 Windows 10 Home 15.6 FHD Taşınabilir Bilgisayar FHDG20W81C", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 2, Resim="2.jpg", Anasayfada=true},
                new Urun(){ Isim = "Lenovo Ideapad 310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10 Home 15.6 Taşınabilir Bilgisayar 80TV028XTX",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =4500 , Stok =1200 , Satistami =true , KategoriId = 2, Resim="2.jpg", Anasayfada=true},
                new Urun(){ Isim = "Asus UX310UQ-FB418T Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =3400 , Stok =0 , Satistami =false , KategoriId = 2, Resim="2.jpg", Anasayfada=true},
                new Urun(){ Isim = "Asus UX310UQ-FB418T Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =2500 , Stok =600 , Satistami =true , KategoriId = 2, Resim="2.jpg", Anasayfada=true},
                new Urun(){ Isim = "Asus N580VD-DM160T Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050 Windows 10 Home",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =5200 , Stok =500 , Satistami =true , KategoriId = 2, Resim="2.jpg", Anasayfada=true},

                new Urun(){ Isim = "LG 49UH610V 49 124 Ekran 4K Uydu Alıcılı Smart LED TV", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 3, Resim="3.jpg", Anasayfada=true},
                new Urun(){ Isim = "Vestel 49UB8300 49 124 Ekran 4K Smart Led Tv",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =5600 , Stok =1200 , Satistami =true , KategoriId = 3, Resim="3.jpg", Anasayfada=true},
                new Urun(){ Isim = "Samsung 55KU7500 55 140 Ekran [4K] Uydu Alıcılı Smart[Tizen] LED TV",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =3400 , Stok =0 , Satistami =false , KategoriId =3, Resim="3.jpg", Anasayfada=true},
                new Urun(){ Isim = "LG 55UH615V 55 140 Ekran 4K Uydu Alıcılı Smart Wi-Fi [webOS 3.0] LED TV",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =2500 , Stok =600 , Satistami =true , KategoriId = 3, Resim="3.jpg", Anasayfada=true},
                new Urun(){ Isim = "Sony Kd-55Xd7005B 55 140 Ekran [4K] Uydu Alıcılı Smart LED TV",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =5200 , Stok =500 , Satistami =true , KategoriId = 3, Resim="3.jpg", Anasayfada=true},

                new Urun(){ Isim = "Apple iPhone 6 32 GB (Apple Türkiye Garantili)", Fiyat =1200 , Stok =500 , Satistami =true , KategoriId = 4, Resim="4.jpg", Anasayfada=true},
                new Urun(){ Isim = "Apple iPhone 7 32 GB (Apple Türkiye Garantili)",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =5600 , Stok =1200 , Satistami =true , KategoriId = 4, Resim="4.jpg", Anasayfada=true},
                new Urun(){ Isim = "Apple iPhone 6S 32 GB (Apple Türkiye Garantili)",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =3400 , Stok =0 , Satistami =false , KategoriId =4, Resim="4.jpg", Anasayfada=true},
                new Urun(){ Isim = "Case 4U Manyetik Mıknatıslı Araç İçi Telefon Tutucu",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =2500 , Stok =600 , Satistami =true , KategoriId = 4, Resim="4.jpg", Anasayfada=true},
                new Urun(){ Isim = "Xiaomi Mi 5S 64GB (İthalatçı Garantili)",Aciklama = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Fiyat =5200 , Stok =500 , Satistami =true , KategoriId = 4, Resim="4.jpg", Anasayfada=true},
            };

            foreach (var urun in urunler)
            {
                context.Urunler.Add(urun);   //veritabanına urun nesnelerini tek tek ekledik
            }
            context.SaveChanges();  //Veri tabanını kaydettik

            base.Seed(context);
        }

    }
}