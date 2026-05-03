using OgrenciNotSistemi.Services;

class Program
{
    static void Main(string[] args)
    {
        var alici = new OgrenciBilgileriAlici();
        var ortalamaHesaplayici = new OrtalamaHesaplayici();
        var harfHesaplayici = new HarfNotuHesaplayici();

        var ogrenciler = alici.BilgileriAl();
        double ortalama = ortalamaHesaplayici.Hesapla(ogrenciler);
        string harfNotu = harfHesaplayici.Hesapla(ortalama);

        Console.WriteLine($"\n--- Sonuç ---");
        Console.WriteLine($"Adı Soyadı: {ogrenciler[0].Adi} {ogrenciler[0].Soyadi}");
        Console.WriteLine($"Ortalama: {ortalama:F2}");
        Console.WriteLine($"Harf Notu: {harfNotu}");
    }
}

