using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 200;

            ///Urun urun2 = new Urun("Çilek", 10, "Çileek");

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 3;

            Urun urun3 = new Urun();
            urun3.Adi = "Kayısı";
            urun3.Fiyati = 40;
            urun3.StokAdedi = 40;


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı:"+urun.Adi);
                Console.WriteLine("Ürün Fiyatı:"+urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması:"+urun.Aciklama);
                Console.WriteLine("****************************************");
            }

            Console.WriteLine("*****************************************************");
              
            SepetManager sepetManager = new SepetManager();

            foreach (Urun urun in urunler)
            {
                sepetManager.Ekle(urun);
            }

        }
    }
}
