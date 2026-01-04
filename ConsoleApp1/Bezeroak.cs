namespace ConsoleApp1;

class Bezeroak
{
    string? izena;
    string? abizena1;
    string? abizena2;
    string? helbidea;
    int? zenbakia;
    public void DatuakEzarri()
    {
        Console.Clear();
        Console.Write("Zure izena: ");
        izena = Console.ReadLine();
        Console.Write("Zure lehenengo abizena: ");
        abizena1 = Console.ReadLine();
        Console.Write("Zure bigarren abizena: ");
        abizena2 = Console.ReadLine();
        Console.Write("Zure helbidea: ");
        helbidea = Console.ReadLine();
        Console.Write("Zure mugikor zenbakia: ");
        zenbakia = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{izena} {abizena1} {abizena2} {helbidea} {zenbakia}");
    }
    public bool DatuakDaude()
    {
        return izena == null || abizena1 == null || abizena2 == null || helbidea == null || zenbakia == null;
    }
    public void DatuakDaude2()
    {
        if (DatuakDaude())
        {
            Console.Clear();
            Console.WriteLine("Zure datuak ez daude ezarrita, ezarri nahi dituzu orain? Bai(b)/Ez(e)");
            string? a = Console.ReadLine()!;
            if (a == "b" || a == "B")
            {
            DatuakEzarri();
            }
            else if (a == "e" || a == "E"){}
            else
            {
                Console.Clear();
                Console.WriteLine("'b' edo 'e' letrekion erantzun mesedez");
                DatuakDaude2();
            }
        }
        else
        {
            DatuakIkusi();
        }
    }
    public void DatuakIkusi()
    {
        Console.Clear();
        Console.WriteLine("=== ZURE DATUAK ===");
        Console.WriteLine($"Izena: {izena}");
        Console.WriteLine($"Lehenengo abizena {abizena1}");
        Console.WriteLine($"Bigarren abizena: {abizena2}");
        Console.WriteLine($"Helbidea: {helbidea}");
        Console.WriteLine($"Mugikor zenbakia: {zenbakia}");
        Console.WriteLine("Zure datuak aldatu nahi dituzu? Bai(b)/Ez(e)");

        string? a = Console.ReadLine()!;
        if (a == "b" || a == "B")
        {
            DatuakEzarri();
        }
        else if (a == "e" || a == "E"){}
        else
        {
            Console.Clear();
            Console.WriteLine("'b'edo 'e' letrekion erantzun mesedez");
            DatuakIkusi();
        }
    }
    public void DatuakHustu()
    {
        izena = null;
        abizena1 = null;
        abizena2 = null;
        helbidea = null;
        zenbakia = null;
    }
}