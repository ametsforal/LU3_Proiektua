namespace ConsoleApp1;

class Bezeroak
{
    string? izena;
    string? abizena1;
    string? abizena2;
    string? helbidea;
    int zenbakia;
    public void DatuakEzarri()
    {
        Console.Write("Zure izena: ");
        izena = Console.ReadLine();
        Console.Write("Zure lehenengo abizena: ");
        abizena1 = Console.ReadLine();
        Console.Write("Zure bigarren abizena: ");
        abizena2 = Console.ReadLine();
        Console.Write("Zure helbidea: ");
        helbidea = Console.ReadLine();
        Console.Write("Zure mugikor zenbakia: ");
        zenbakia = int.Parse(Console.ReadLine());
        Console.WriteLine($"{izena} {abizena1} {abizena2} {helbidea} {zenbakia}");
    }
}