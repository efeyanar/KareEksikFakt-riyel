
using System;

tepe:
Console.Write("Bir Sayı Giriniz : ");
try
{
    double sayi = Convert.ToDouble(Console.ReadLine());
    if (sayi <= 0)
    {
        Console.WriteLine("Lütfen Pozitif Değer Giriniz.");
        Console.WriteLine("");
        goto tepe;
    }
    else
    {
        double kare = 0;
        double faktoriyel = 1;
        double eksik = 0;

        if (sayi > 5 && sayi <= 10)
        {
            kare = sayi * sayi;
            Console.WriteLine("Sayının karesi = " + kare);
            Console.WriteLine("Uygulamayı Kapatmak İçin 'ENTER' Basınız.");
        }
        else if (sayi <= 5)
        {
            for (double i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;

            }
            Console.WriteLine("Sayının faktöriyeli = " + faktoriyel);
            Console.WriteLine("Uygulamayı Kapatmak İçin 'ENTER' Basınız.");
        }
        else if (sayi > 10)
        {
            eksik = (sayi / 2) - 1;
            Console.WriteLine("Sayının yarısının bir eksiği = " + eksik);
            Console.WriteLine("Uygulamayı Kapatmak İçin 'ENTER' Basınız.");
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
    Console.WriteLine("");
    goto tepe;
}
Console.ReadLine();
