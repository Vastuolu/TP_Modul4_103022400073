using System;

public class Program
{
       public static void Main()
    {
        Console.WriteLine("++Teknik Table Driven Construction++");
        Console.Write("Masukkan Kelurahan: ");
        string kelurahan = Console.ReadLine();
        int kodePos = KodePos.getKodePos(kelurahan);
        Console.WriteLine("Kode Pos Kelurahan " + kelurahan + ": "+kodePos);

        Console.WriteLine("\n++Teknik State Based Construction++");
        DoorMachine mesinPintu = new DoorMachine();
        mesinPintu.OperasikanPintu();
        mesinPintu.getCurrentDoorState();
    }
}