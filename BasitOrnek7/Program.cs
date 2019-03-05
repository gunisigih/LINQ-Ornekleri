using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek7
{
    //LINQ - Temel İşlemler - Birleştirme(Joining)
    class Program
    {

        public class Musteri
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Sehir { get; set; }
        }

        public static List<Musteri> MusterileriDoldur()
        {
            List<Musteri> Musteriler = new List<Musteri>
            {
               new Musteri {Adi="Kenan", Soyadi="Oran", Sehir="Muğla"},
               new Musteri {Adi="Erhan", Soyadi="Erkanlı", Sehir="Ankara"},
               new Musteri {Adi="Ercan", Soyadi="Orak", Sehir="Ankara"},
               new Musteri {Adi="Yaşar", Soyadi="Yılmaz", Sehir="Manisa"}
            };
            return Musteriler;
        }
        public class Dagitici
        {
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public string Sehir { get; set; }
        }
        public static List<Dagitici> DagiticilariGetir()
        {
            List<Dagitici> Dagiticilar = new List<Dagitici>
            {
               new Dagitici {Adi="Tekin", Soyadi="Uğurlu", Sehir="Van"},
               new Dagitici {Adi="Hasan", Soyadi="Ünlü", Sehir="Ankara"},
               new Dagitici {Adi="Tuncay", Soyadi="Çağrı", Sehir="Manisa"},
               new Dagitici {Adi="Mehmet", Soyadi="Emre", Sehir="Muğla"}
            };
            return Dagiticilar;
        }

        static void Main(string[] args)
        {
            List<Musteri> musteriler = MusterileriDoldur();
            List<Dagitici> dagiticilar = DagiticilariGetir();
            var birlestirmeSorgusu =
                from musteri in musteriler
                join dagitici in dagiticilar on musteri.Sehir equals dagitici.Sehir
                select new
                {
                    MusteriSehir = musteri.Sehir,
                    MusteriAdi = musteri.Adi,
                    DagiticiAdi = dagitici.Adi
                };
            // LINQ Yöntem Sözdizimi ile sorgu :
            /*
            var birlestirmeSorgusu = musteriler.Join(
                                         dagiticilar,
                                         musteri => musteri.Sehir,
                                         dagitici => dagitici.Sehir,
                                         (musteri, dagitici) => new { Sehir = musteri.Sehir,
                                                                      MusteriAdi = musteri.Adi,
                                                                      DagiticiAdi = dagitici.Adi
                                                                    }
                                                    );
            */
            Console.WriteLine("Şehir, Dağıtıcı - Müşteri");
            Console.WriteLine("-------------------------");
            foreach (var satir in birlestirmeSorgusu)
            {
                Console.WriteLine("{0}, {1} - {2}",   satir.MusteriSehir,
                                                    satir.DagiticiAdi,
                                                    satir.MusteriAdi);
            }
            Console.ReadKey();
        }
    }
}
