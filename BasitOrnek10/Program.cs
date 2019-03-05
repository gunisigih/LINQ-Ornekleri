using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitOrnek10
{
    // LINQ - Query Reuse - Sorgunun Yeniden Kullanımı
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var kucukSayilar =
                               from sayi in sayilar
                               where sayi < 5
                               select sayi;
            Console.WriteLine("İlk çalıştırma sonucunda 5'den küçük sayılar :");
            foreach (int sayi in kucukSayilar)
            {
                Console.WriteLine(sayi);
            }
            // Dizideki sayıları değiştir (negatife çevir)
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = sayilar[i] * -1;
            }
            // Sayılar değiştiği için alttaki foreach döngüsünde sorgu tekrar
            // çalıştırılacak ve dolayısıyla farklı sonuçlar görüntülenecektir.
            Console.WriteLine("İkinci çalıştırma sonucunda 5'den küçük sayılar:");
            foreach (int sayi in kucukSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }
    }
}
