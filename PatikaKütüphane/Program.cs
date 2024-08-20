using PatikaKütüphane;
using System;

namespace PatikaKutuphane
{
    class Program
    {
        static void Main()
        {
            // Default constructor ile kitap nesnesi oluşturma
            Kitap kitap1 = new Kitap();
            kitap1.Ad = "Adı Aylin";
            kitap1.YazarAdi = "Ayşe";
            kitap1.YazarSoyadi = "Kulin";
            kitap1.SayfaSayisi = 398;
            kitap1.Yayinevi = "Remzi Kitabevi";
            kitap1.PrintInfo();

            // Parametreli constructor ile kitap nesnesi oluşturma
            Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            kitap2.PrintInfo();
        }
    }
}

// Class (Sınıf): Kitap, belirli bir türdeki nesneleri modellemek için kullanılan bir sınıftır. 
// Property (Özellik): Kitap sınıfındaki her bir özellik (property) kitap nesnesinin verilerini tutar. 
// New: Yeni bir Kitap nesnesi oluşturmak için new anahtar kelimesi kullanılır. Bu, sınıfın bir örneğini (nesnesini) oluşturur ve hafızada bir yer ayırır.
// Constructor (Kurucu Metot): Sınıfın bir nesnesi oluşturulurken çağrılan özel metotlardır.