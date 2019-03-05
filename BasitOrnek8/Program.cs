using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek8
{
    // LINQ - Deferred Execution - Ertelenmiş Çalıştırma
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var iler =
                       from n in sayilar
                       select ++i;
            // Burada ertelenmiş çalıştırmanın bir yan etkisi olarak,
            // i değişkeninin değeri de her bir eleman foreach içinde
            // kullanıldığında (döngü içinde) arttırılacaktır.
            foreach (var biri in iler)
            {
                Console.WriteLine("biri = {0}, i = {1}", biri, i);
            }

            Console.WriteLine("Ikinci dongu sirasinda i kaldigi yerden devam ediyor:");
            i = 90;
            foreach (var biri in iler)
            {
                Console.WriteLine("biri = {0}, i = {1}", biri, i);
            }

            Console.ReadKey();
        }
    }
}
