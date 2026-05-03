using OgrenciNotSistemi.Models;

namespace OgrenciNotSistemi.Services;

public class OgrenciBilgileriAlici
{
    public List<Ogrenci> BilgileriAl()
    {
        Console.WriteLine("Öğrenci adını giriniz:");
        string ogrenciAdi = Console.ReadLine() ?? "";
        
        Console.WriteLine("Öğrenci soyadını giriniz:");
        string ogrenciSoyadi = Console.ReadLine() ?? "";
        
        Console.WriteLine("Öğrenci vize notunu giriniz:");
        if (!double.TryParse(Console.ReadLine(), out double ogrenciVizeNotu))
        {
            Console.WriteLine("Geçersiz vize notu. Lütfen geçerli bir sayı giriniz.");
            ogrenciVizeNotu = 0; // Varsayılan değeri atayabilirsiniz
        }

        ogrenciVizeNotu = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Öğrenci final notunu giriniz:");
        if (!double.TryParse(Console.ReadLine(), out double ogrenciFinalNotu))
        {
            Console.WriteLine("Geçersiz final notu. Lütfen geçerli bir sayı giriniz.");
            ogrenciFinalNotu = 0; // Varsayılan değeri atayabilirsiniz
        }

        return new List<Ogrenci> 
        { 
            new Ogrenci 
            { 
                Adi = ogrenciAdi, 
                Soyadi = ogrenciSoyadi, 
                VizeNotu = ogrenciVizeNotu, 
                FinalNotu = ogrenciFinalNotu 
            } 
        };
    }
}
