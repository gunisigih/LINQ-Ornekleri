using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace BasitOrnek4
{
    //LINQ - Temel İşlemler - Süzme (Filtering)
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> ogrenciler = Class1.OgrencileriGetir();

            //(1. yazılı sınav notu 55 ve daha büyük olan öğrencilerin soyadlarını seç.)
            var query = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55
                        select ogrenci.Soyadi;
            foreach (var s in query)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = ogrenciler.Where(ogr => ogr.YaziliSinavlar[0] >= 55)
                                  .Select(ogr => ogr.Soyadi);
            */

            Console.WriteLine("---------------");

            var query2 = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55 && ogrenci.Basarili == false
                        select ogrenci;
            foreach (var s in query2)
            {
                Console.WriteLine(s.Soyadi);
            }
            Console.ReadKey();

            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = ogrenciler.Where(ogr => ogr.YaziliSinavlar[0] >= 55 && ogr.Basarili == false);
            */
        }
    }
}
