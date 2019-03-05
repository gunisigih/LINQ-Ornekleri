using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek9
{
    // LINQ - Immediate Execution - Anında Çalıştırma
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int i = 0;
            var liste = (from sayi in sayilar select ++i).ToList();
            // Sorgu bu döngüye gelmeden çalıştırıldığı için aşağıda
            // hep i'nin son aldığı değer (10) çıktıya yazılır.
            foreach (var eleman in liste)
            {
                Console.WriteLine("Sayı = {0}, i = {1}", eleman, i);
            }
            Console.ReadKey();
        }
    }
}
