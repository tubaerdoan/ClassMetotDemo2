using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.Ad = "Tuğba";
            musteri.Soyad = "Erdoğan";
            musteri.Yas = 23;
            musteri.Cinsiyet = "Kadın";


            Musteri[] musteriler = new Musteri[] { musteri };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Guncelle(musteri);
            musteriManager.Sil(musteri.id);
            musteriManager.Listele(musteriler);


        }
    }
}
