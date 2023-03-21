// See https://aka.ms/new-console-template for more information
using System.Globalization;

class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        Console.WriteLine(a + b + c);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan plus = new Penjumlahan();
        double angka1 = 13;
        double angka2 = 2;
        double angka3 = 21;
        plus.JumlahTigaAngka(angka1, angka2, angka3);
    }
}