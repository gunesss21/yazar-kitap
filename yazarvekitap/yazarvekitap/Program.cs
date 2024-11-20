using System;
using System.Collections.Generic;

// Kitap sınıfı: Bir yazara ait kitabı temsil eder
public class Kitap
{
    public string Baslik { get; private set; }
    public string Tur { get; private set; }
    public int YayimYili { get; private set; }

    // Kitap yapıcısı
    public Kitap(string baslik, string tur, int yayimYili)
    {
        Baslik = baslik;
        Tur = tur;
        YayimYili = yayimYili;
    }

    // Kitap detaylarını görüntüleme metodu
    public override string ToString()
    {
        return $"Başlık: {Baslik}, Tür: {Tur}, Yayım Yılı: {YayimYili}";
    }
}

// Yazar sınıfı: Bir yazarı ve onun yazdığı kitapları temsil eder
public class Yazar
{
    public string Ad { get; private set; }
    public List<Kitap> Kitaplar { get; private set; }

    // Yazar yapıcısı
    public Yazar(string ad)
    {
        Ad = ad;
        Kitaplar = new List<Kitap>();
    }

    // Bir kitabı yazara ekleme metodu
    public void KitapEkle(Kitap kitap)
    {
        if (kitap != null)
        {
            Kitaplar.Add(kitap);
        }
        else
        {
            Console.WriteLine("Geçersiz kitap.");
        }
    }

    // Yazarın detaylarını ve yazdığı kitapları görüntüleme metodu
    public void YazarDetaylariniGoster()
    {
        Console.WriteLine($"Yazar: {Ad}");
        Console.WriteLine("Yazdığı Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"  - {kitap}");
        }
    }
}

// Program sınıfı: Uygulamanın ana giriş noktası
public class Program
{
    public static void Main(string[] args)
    {
        // Bazı kitaplar oluşturuluyor
        var kitap1 = new Kitap("Büyük Macera", "Kurgu", 2020);
        var kitap2 = new Kitap("C# Öğreniyorum", "Eğitim", 2018);
        var kitap3 = new Kitap("Okyanusun Gizemi", "Macera", 2022);

        // Bir yazar oluşturuluyor ve kitapları yazara ekleniyor
        var yazar = new Yazar("John Doe");
        yazar.KitapEkle(kitap1);
        yazar.KitapEkle(kitap2);
        yazar.KitapEkle(kitap3);

        // Yazar detayları ve yazdığı kitapları görüntüleme
        yazar.YazarDetaylariniGoster();
    }
}
