/*
//1.Matematiksel Hesaplama Yapan Parametresiz ve Geriye Değer Döndüren Metot
//Soru: Bir metot yazın; bu metot, kullanıcıdan üçgenin taban uzunluğu ve yüksekliğini alıp, üçgenin alanını hesaplayarak geriye döndürsün.
//Alanı hesaplamak için Taban * Yükseklik / 2 formülünü kullanın.
//İpucu: double türünde dönen bir metot tanımlamalı ve kullanıcıdan alınan değerlerle hesaplama yapmalısınız.

using System;
class Program
{
    static double UcgenAlaniHesapla()
    {
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçgenin yüksekliğini girin: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());

        return (taban * yukseklik) / 2;
    }

    static void Main()
    {
        Console.WriteLine("Üçgenin alanı: " + UcgenAlaniHesapla());

    }
}
*/



/*
//2.Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot
//Soru: int türünde bir dizi parametresi alan ve bu dizideki en büyük değeri bulan bir metot yazın.
//İpucu: int dönen bir metot tanımlayıp, foreach döngüsü ile diziyi dolaşarak en büyük değeri bulabilirsiniz.

using System;
class Program
{
    static int EnBuyukDegeriBul(int[] dizi)
    {
        int enBuyuk = dizi[0]; 

        foreach (int sayi in dizi)
        {
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi; 
            }
        }

        return enBuyuk; 
    }

    static void Main()
    {
       
        int[] sayilar = { 5, 12, 7, 21, 14 };

        int enBuyuk = EnBuyukDegeriBul(sayilar); 
        Console.WriteLine("En büyük sayı: " + enBuyuk);
    }
}
*/


/*
//3.Aşırı Yüklenmiş(Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma
//Soru: Aynı isimle üç farklı CalculateSum metodu yazın.
//İlk metot iki int sayıyı toplasın, ikinci metot iki double sayıyı toplasın, üçüncü metot ise üç int sayıyı toplasın.
//İpucu: Metot isimleri aynı olmalı fakat parametre türleri farklı olmalıdır.

using System;

class Program
{
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    
    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    
    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("İki int sayının toplamı: " + CalculateSum(5, 10));

        
        Console.WriteLine("İki double sayının toplamı: " + CalculateSum(5.5, 10.3));

        
        Console.WriteLine("Üç int sayının toplamı: " + CalculateSum(1, 2, 3));
    }
}
*/



/*
//4.Recursive Metot ile Fibonacci Dizisi Hesaplama
//Soru: Bir sayının Fibonacci dizisindeki karşılığını hesaplayan özyinelemeli (recursive) bir metot yazın.
//fibonacci(5) çağrısı, dizideki 5. Fibonacci sayısını döndürmelidir.
//İpucu: int dönen ve kendini çağırarak Fibonacci dizisi üreten bir metot yazmalısınız.

using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n; 
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
    }

    static void Main()
    {
        Console.Write("Fibonacci dizisinde kaçıncı sayının hesaplanmasını istiyorsun? ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci sonucu: " + Fibonacci(sayi));

    }
}
*/


/*
//5.Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
//Soru: params anahtar kelimesini kullanarak sınırsız sayıda double parametre alabilen
//ve bu sayılar arasındaki ortalamayı hesaplayan bir metot yazın.
//İpucu: params ile dizi gibi parametre alabilir ve döngü kullanarak ortalamayı hesaplayabilirsiniz.

using System;
class Program
{
    
    static double OrtalamaHesapla(params double[] sayilar)
    {
        double toplam = 0;
        foreach ( double sayi in sayilar)
            toplam += sayi;

        return toplam / sayilar.Length;
    }

    static void Main()
    {
        
        Console.WriteLine("Ortalama: "+ OrtalamaHesapla(1.5, 2.5, 3.5, 4.5)); 
    }
}

*/


/*
//6.Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
//Soru: int türünde bir dizi ve bir filtre değeri (int) alan bir metot yazın.
//Bu metot, filtre değerinden büyük olan tüm elemanları toplasın ve toplamı döndürsün.
//İpucu: int türünde bir metot tanımlayıp foreach döngüsü ile filtreyi uygulayarak toplamı hesaplayabilirsiniz.

using System;

class Program
{
    static int ElemanlariTopla(int[] dizi, int filtre)
    {
        int toplam = 0;
        foreach (int sayi in dizi)
        {
            if (sayi > filtre) 
                toplam += sayi; 
        }
        return toplam;
    }

    static void Main()
    {
        int[] sayilar = { 1, 5, 8, 3, 12, 7, 6 };
        int filtre = 5;

        Console.WriteLine("Filtre değerinden büyük olan elemanların toplamı: " + ElemanlariTopla(sayilar, filtre));
    }
}
*/


/*
//7.Seçmeli(Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
//Soru: Bir yaş değeri alan bir metot yazın.
//Eğer yaş belirtilmezse varsayılan olarak 18 olsun ve metot, verilen yaşın 18’den ne kadar fazla olduğunu döndürsün.
//İpucu: int türünde bir metot tanımlayıp varsayılan parametre kullanarak yaşı hesaplayabilirsiniz.

using System;

class Program
{
    static int YasFarkiniHesapla(int yas = 18)
    {
        return yas - 18; 
    }
    static void Main()
    {
        
        Console.WriteLine("18'den fazla yıl: " + YasFarkiniHesapla()); 

       
        Console.WriteLine("Yaş 21 olduğunda 18'den fazla yıl: " + YasFarkiniHesapla(21));
    }
}
*/


/*
//8.Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
//Soru: string türünde bir dizi alan bir metot yazın.
//Bu metot, sadece uzunluğu 5 karakterden büyük olan elemanları içeren bir List<string> döndürsün.
//İpucu: List<string> türünde bir metot tanımlayarak döngü ile filtreleme yapabilirsiniz.

using System;

class Program
{
  
    static List<string> FiltreleVeListele(string[] dizi)
    {
        List<string> sonuc = new List<string>();

        foreach (string eleman in dizi)
        {
            if (eleman.Length > 5) 
            {
                sonuc.Add(eleman);
            }
        }

        return sonuc;
    }
    static void Main()
    {
        string[] kelimeler = { "elma", "çilek", "muz", "şeftali", "karpuz", "portakal" };

        
        List<string> filtreliKelimeler = FiltreleVeListele(kelimeler);

        foreach (string kelime in filtreliKelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
}
*/







