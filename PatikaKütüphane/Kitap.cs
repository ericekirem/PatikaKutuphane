using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKütüphane
{
    public class Kitap
    {
        // Property'ler
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        // Default Constructor
        public Kitap()
        {
            KayitTarihi = DateTime.Now;
        }

        // Parametreli Constructor
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now;
        }

        // Kitap bilgilerini yazdırmak için bir metot
        public void PrintInfo()
        {
            Console.WriteLine($"Ad: {Ad}, Yazar: {YazarAdi} {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayınevi: {Yayinevi}, Kayıt Tarihi: {KayitTarihi}");
        }
    }
}
