using System;

class Araba
{
    public string Marka { get; set; }
    public string VitesTuru { get; set; }
    public string Tavan { get; set; }
    public string YakıtTürü { get; set; }

    public void BilgiGoster()
    {
        Console.WriteLine($"{Marka}:{VitesTuru} : {Tavan} :{YakıtTürü}");

    }
}

class BMW : Araba
{
    public BMW()
    {
        Marka = "BMW";
        VitesTuru = "düz viteslidir";
        Tavan = "sunroof";
        YakıtTürü = "benzinli";
    }
}

class porche : Araba
{
    public porche()
    {
        Marka = "porche";
        VitesTuru = "otomatik vitesli";
        Tavan = "cam tavan";
        YakıtTürü = "elektrikli";

    }
}

class mercedes : Araba
{
    public mercedes()
    {
        Marka = "mercedes";
        VitesTuru = "düz viteslidir";
        Tavan = "sunroof";
        YakıtTürü = "motorin";


    }
}

class audi : Araba
{
    public audi()
    {
        Marka = "audi";
        VitesTuru = "otomatik vitesli";
        Tavan = "kapalı tavan";
        YakıtTürü = "elektrikli";


    }
}

class Program
{
    static void Main()
    {
        BMW bmw = new BMW();
        porche porche = new porche();
        mercedes mercedes = new mercedes();
        audi audi = new audi();


        bmw.BilgiGoster();
        porche.BilgiGoster();
        mercedes.BilgiGoster();
        audi.BilgiGoster();
    }
}
