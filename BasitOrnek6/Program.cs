using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace BasitOrnek6
{
    //LINQ - Temel İşlemler - Gruplama(Grouping)
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> Ogrenciler = Class1.OgrencileriGetir();
            var ogrenciGruplari =
                                  from ogr in Ogrenciler
                                  where ogr.Yasi > 30
                                  group ogr by ogr.Soyadi[0] into basHarfGrubu
                                  where basHarfGrubu.Count() > 1
                                  orderby basHarfGrubu.Key
                                  select basHarfGrubu;
            //basHarfGrubu.Key - Sorgu için grup olusturma gostergesı
            //var ogrenciGruplari =
            //         from ogr in Ogrenciler
            //         group ogr by ogr.Soyadi[0];

            // LINQ Yöntem Sözdizimi ile sorgu :
            /*
            var ogrenciGruplari = Ogrenciler.GroupBy(ogr => ogr.Soyadi[0])
                                            .Where(basHarfGrubu => basHarfGrubu.Count() > 1)
                                            .OrderBy(basHarfGrubu => basHarfGrubu.Key);
            */
            foreach (var ogrenciGrubu in ogrenciGruplari)
            {
                Console.WriteLine(ogrenciGrubu.Key);
                foreach (var ogr in ogrenciGrubu)
                {
                    Console.WriteLine("{0}, {1}, {2}", ogr.Soyadi, ogr.Adi, ogr.Yasi);
                }
            }
            Console.ReadKey();
        }
    }
}
