using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrnekleri_VeriKaynagi
{
    //LINQ Örnekleri makalelerinde kullanılan verikaynağı
    //--http://yazilim.cevapsitesi.com/EtiketMakalesi/linq_11/4/linq-ornekleri-makalelerinde-kullanilan-verikaynagi

    // Öğrenci kaydı olarak kullanılan sınıf...
    public class Kayit
    {
        public int No { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Sinif { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yasi { get; set; }
        public int Kulup { get; set; }
        public int[] Notlar { get; set; }
        public double Ortalama { get; set; }
        public bool Basarili { get; set; }
        public int OkunanKitapSayisi { get; set; }
    }

    // Kulup kaydı olarak kullanılan sınıf...
    public class KulupKaydi
    {
        public int KayitNo { get; set; }
        public string Adi { get; set; }
        public string Sorumlu { get; set; }
    }

    public class Class1
    {
        // Öğrenci kaydı tutan Kayit isimli sınıfın bir listesini döndüren yöntem...
        public static List<Kayit> OgrencileriGetir()
        {
            List<Kayit> Ogrenciler = new List<Kayit>();
            Ogrenciler.Add(new Kayit()
            {
                No = 2,
                Adi = "Tuncay",
                Soyadi = "Çağrı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(2002, 2, 27),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 75, 70, 75 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 4,
                Adi = "Jale",
                Soyadi = "İkinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1970, 1, 28),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 100, 95, 97, 96 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 7,
                Adi = "Tekin",
                Soyadi = "Uğurlu",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1955, 3, 26),
                Sinif = 1,
                Kulup = 1,
                OkunanKitapSayisi = 4,
                Notlar = new int[] { 30, 40, 20 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 8,
                Adi = "Mesut",
                Soyadi = "Bahtiyar",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1980, 4, 25),
                Sinif = 4,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 70, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 12,
                Adi = "Veli",
                Soyadi = "Canlı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1993, 5, 24),
                Sinif = 4,
                Kulup = 2,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 80, 40, 10 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 6,
                Adi = "Ahmet",
                Soyadi = "Geçe",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1958, 6, 23),
                Sinif = 2,
                Kulup = 2,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 70, 80, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 15,
                Adi = "Fatma",
                Soyadi = "Teyze",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1972, 7, 22),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 12,
                Notlar = new int[] { 70, 98, 97, 92 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 14,
                Adi = "Mehmet",
                Soyadi = "Emre",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1970, 8, 21),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 80, 22, 97 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 3,
                Adi = "Hale",
                Soyadi = "Birinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1982, 9, 20),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 20, 40, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 13,
                Adi = "Ayşe",
                Soyadi = "Hanım",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1983, 10, 19),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 5,
                Notlar = new int[] { 100, 40, 100 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 11,
                Adi = "Cevdet",
                Soyadi = "Döğer",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1967, 11, 18),
                Sinif = 3,
                Kulup = 2,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 20, 0, 30, 15 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 1,
                Adi = "Nuri",
                Soyadi = "Babayiğit",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1998, 12, 17),
                Sinif = 2,
                Kulup = 2,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 55, 75, 65 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 5,
                Adi = "Kenan",
                Soyadi = "Oran",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1961, 1, 16),
                Sinif = 1,
                Kulup = 0,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 50, 70, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 9,
                Adi = "Lale",
                Soyadi = "Üçüncü",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1990, 2, 15),
                Sinif = 3,
                Kulup = 0,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 20, 0, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 10,
                Adi = "Erhan",
                Soyadi = "Erkanlı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1958, 3, 14),
                Sinif = 1,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 90, 90, 90 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 16,
                Adi = "Erhan",
                Soyadi = "Fidan",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1968, 4, 13),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 95, 70, 100, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 17,
                Adi = "Erhan",
                Soyadi = "Çelik",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1978, 5, 12),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 55, 90 }
            });

            foreach (var Ogrenci in Ogrenciler)
            {
                Ogrenci.Ortalama = Ogrenci.Notlar.Average();
                Ogrenci.Basarili = Ogrenci.Ortalama >= 55;
                Ogrenci.Yasi = DateTime.Now.Year - Ogrenci.DogumTarihi.Year;
            }

            return Ogrenciler;

        }

        // Kulüp kaydı tutan KulupKaydi isimli sınıfın bir listesini döndüren yöntem.
        public static List<KulupKaydi> KulupleriGetir()
        {
            List<KulupKaydi> Kulupler = new List<KulupKaydi>();
            Kulupler.Add(new KulupKaydi() { KayitNo = 0, Adi = "Gezi", Sorumlu = "Tanju Bülbül" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 1, Adi = "Tiyatro", Sorumlu = "Metin Öztürk" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 2, Adi = "Müzik", Sorumlu = "Nuri Sezer" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 3, Adi = "Kitap", Sorumlu = "Kazım Ünlüol" });
            return Kulupler;
        }
    }
}
