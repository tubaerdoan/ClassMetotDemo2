using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class MusteriManager
    {
        // Musteri ekleme, listeleme,silme gibi metotları 

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Kaydı Başarılı");
        }


        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }

        public void Sil(int musteriID)
        {
            Console.WriteLine("Müşteri Silme İşlemi Başarılı");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var m in musteriler)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Müşteri ID : " + m.id);
                Console.WriteLine("Müşteri Adı : " + m.Ad);
                Console.WriteLine("Müşteri Soyadı : " + m.Soyad);
                Console.WriteLine("Müşteri Yaşı : " + m.Yas);
                Console.WriteLine("Müşteri Cinsiyeti : " + m.Cinsiyet);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
