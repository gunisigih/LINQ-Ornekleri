using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace BasitOrnek5
{
    //LINQ - Temel İşlemler - Sıralama (Ordering)
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> ogrenciler = Class1.OgrencileriGetir();

            // Bu örnek, 1.yazılı sınav notu 55 ve daha büyük olan öğrencileri 
            //1.sınav notlarına göre artan sırada(küçükten büyüğe) seçer.
            var query = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55
                        orderby ogrenci.Notlar[0]
                        select ogrenci;

            foreach (var ogrenci in query)
            {
                Console.WriteLine(ogrenci.Adi);
            }

            Console.ReadKey();
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = ogrenciler.Where(ogr => ogr.Yazililar[0] >= 55)
                                  .OrderBy(ogr => ogr.Yazililar[0]);
            */
            Console.WriteLine("---------------");

            //Eğer tersine bir sıralama isteniyorsa descending ifadesi 
            //cümleciğin sonuna eklenir.
            var query2 = from ogrenci in ogrenciler
                        where ogrenci.Notlar[0] >= 55
                        orderby ogrenci.Notlar[0] descending
                        select ogrenci;

            foreach (var ogrenci in query2)
            {
                Console.WriteLine(ogrenci.Adi);
            }

            Console.ReadKey();
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = ogrenciler.Where(ogr => ogr.Yazililar[0] >= 55)
                                  .OrderByDescending(ogr => ogr.Yazililar[0]);
            */

        }
    }
}
