using System;

public class DoorMachine
{
    private enum DoorState {Terkunci, Terbuka};
    private DoorState currentDoorState = DoorState.Terkunci;
    
    public DoorMachine()
    {
            Console.WriteLine("Door Machine terinisialisasi. State saat ini: " + currentDoorState);
    }

    public void OperasikanPintu()
    {
        Console.Write("Masukkan Perintah (BukaPintu/KunciPintu): ");
        string perintah = Console.ReadLine();
        if (perintah == "BukaPintu")
        {
            currentDoorState = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak dikunci.");
        }
        else if (perintah == "KunciPintu")
        {
            currentDoorState = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci.");
        }
    }

    public void getCurrentDoorState()
    {
        Console.WriteLine("State pintu saat ini: " + currentDoorState);
    }
}
