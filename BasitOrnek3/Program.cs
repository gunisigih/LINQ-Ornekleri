using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek3
{
    //LINQ - Temel İşlemler - Bir Veri Kaynağı Bildirme ve Seçme (From ve Select)
    class Program
    {
        public class Ogrenci
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int No { get; set; }
        }
        static void Main(string[] args)
        {
            var ogrenciler = new List<Ogrenci>
            {
                new Ogrenci() { Adi = "Ali", Soyadi = "Ünlü", No = 112 },
                new Ogrenci() { Adi = "Veli", Soyadi = "Yeşil", No = 116 },
                new Ogrenci() { Adi = "Selami", Soyadi = "Sağlam", No = 132 }
            };
 
            var query = from ogrenci in ogrenciler
                        select ogrenci.Soyadi;
            /*
            // LINQ Yöntem Sözdizimi ile sorgu :
            var query = ogrenciler.Select(ogr => ogr.Soyadi);
            */
            foreach (var ogrenci in query)
            {
                Console.WriteLine(ogrenci);
            }
            Console.ReadKey();
        }
    }
}