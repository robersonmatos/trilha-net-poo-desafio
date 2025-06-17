using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Samsung S25");
        Smartphone nokia = new Nokia("12345678", "Samsung S25", "0123451234512345", 256);
        nokia.Ligar();
        nokia.InstalarAplicativo("Linkedin");

        Console.WriteLine();

        Console.WriteLine("Smartphone Xiaomi 12x");
        Smartphone iphone = new Iphone("12345678", "Xiaomi 12x", "0123451234512345", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Linkedin");

        Console.ReadLine(); 
    }
}