namespace OgrenciNotSistemi.Services;

public class HarfNotuHesaplayici
{
    public string Hesapla(double ortalama)
    {
        if (ortalama >= 90)
            return "A";
        else if (ortalama >= 80)
            return "B";
        else if (ortalama >= 70)
            return "C";
        else if (ortalama >= 60)
            return "D";
        else
            return "F";
    }
}
