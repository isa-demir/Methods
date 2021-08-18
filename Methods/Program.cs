using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Sulu Amasya Elması";

            Product urun2 = new Product();
            urun2.Id = 2;
            urun2.Adi = "Fındık";
            urun2.Fiyati = 23.50;
            urun2.Aciklama = "Doğal Ordu Fındığı";

            Product[] products = new Product[] { urun1, urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("\n-------------METODLAR-------------\n");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

        }
    }
}
