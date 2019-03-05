using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek2
{
    // Bir onceki örneğin yöntem sözdizimi ile yazılmış hali şöyledir. 
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new int[] { 1, 3, 33, 44, 56, 101 };

            var tekler = liste.Where(sayi => sayi % 2 == 1);

            foreach (var tekSayi in tekler)
            {
                Console.WriteLine(tekSayi);
            }
            Console.ReadKey();
        }
    }
}
