partial class Program
{
    static void Main(string[] args)
    {
        List<Ogrenci> ogrencibilgileri = OgrenciBilgileriAl();
        double ortalama = OrtalamaHesapla(ogrencibilgileri);
        string harfNotu = HarfNotuHesapla(ortalama);
        Console.WriteLine($"Ortalama: {ortalama}, Harf Notu: {harfNotu}, Öğrenci Bilgileri: {ogrencibilgileri[0].Adi} {ogrencibilgileri[0].Soyadi}");
    }

    static List<Ogrenci> OgrenciBilgileriAl()
    {   
        Console.WriteLine("Öğrenci adını giriniz:");
        string ogrenciAdi = Console.ReadLine();
        Console.WriteLine("Öğrenci soyadını giriniz:");
        string ogrenciSoyadi = Console.ReadLine();
        Console.WriteLine("Öğrenci vize notunu giriniz:");
        double ogrenciVizeNotu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Öğrenci final notunu giriniz:");
        double ogrenciFinalNotu = Convert.ToDouble(Console.ReadLine());
        
        return new List<Ogrenci> { new Ogrenci { Adi = ogrenciAdi, Soyadi = ogrenciSoyadi, VizeNotu = ogrenciVizeNotu, FinalNotu = ogrenciFinalNotu } };
    }

    static double OrtalamaHesapla(List<Ogrenci> ogrenciler)
    {
        if (ogrenciler.Count == 0) return 0;
        double vizeNotu = ogrenciler[0].VizeNotu;
        double finalNotu = ogrenciler[0].FinalNotu;
        double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
        return ortalama;
    }

    static string HarfNotuHesapla(double ortalama)
    {
        if (ortalama >= 90)
        {
            return "A";
        }
        else if (ortalama >= 80)
        {
            return "B";
        }
        else if (ortalama >= 70)
        {
            return "C";
        }
        else if (ortalama >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

