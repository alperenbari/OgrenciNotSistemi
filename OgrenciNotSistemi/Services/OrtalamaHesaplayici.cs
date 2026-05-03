using OgrenciNotSistemi.Models;

namespace OgrenciNotSistemi.Services;

public class OrtalamaHesaplayici
{
    public double Hesapla(List<Ogrenci> ogrenciler)
    {
        if (ogrenciler == null || ogrenciler.Count == 0)
            return 0;
        
        double vizeNotu = ogrenciler[0].VizeNotu;
        double finalNotu = ogrenciler[0].FinalNotu;
        double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
        
        return ortalama;
    }
}
