namespace ConsoleApp1;

class Postreak
{
    List<string> postreak = new List<string>() { "Izozkia", "Pastela", "Fruitua", "Donut" };

    public void PostreakErakutsi()
    {
        Console.Clear();
        Console.WriteLine("Zer postre nahi duzu?");
        for (int i = 0; i < postreak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {postreak[i]}");
        }
        Console.WriteLine("5. Ez dut postrerik nahi");
        Console.WriteLine("Aukeratu bat mesedez:");
    }
     public string PostreaAukeratu(int aukera)
    {
        return postreak[aukera - 1] + " (Postrea)";
    }
}