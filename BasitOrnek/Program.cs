using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek
{
    //LINQ (Language Integrated Query - Dile Entegre Edilmiş Sorgu) Nedir?
    class Program
    {
        static void Main(string[] args)
        {
            //Array elemanlarini veritabani tablosu gibi sorgulayabiliyoruz
            var liste = new int[] { 1, 3, 33, 44, 56, 101 };

            var tekler =
                         from sayi in liste
                         where sayi % 2 == 1
                         select sayi;

            foreach (var tekSayi in tekler)
            {
                Console.WriteLine(tekSayi);
            }

            Console.ReadKey();

        }
    }
}
