using System;

public class Program
{
       public static void Main()
    {
        Console.WriteLine("++Teknik Table Drive Construction++");
        Console.Write("Masukkan Kelurahan: ");
        string kelurahan = Console.ReadLine();
        int kodePos = new KodePos().getKodePos(kelurahan);
        Console.WriteLine("Kode Pos Kelurahan " + kelurahan + ": "+kodePos);
    }
}