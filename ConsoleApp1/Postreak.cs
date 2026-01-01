namespace ConsoleApp1;

class Postreak
{
    List<string> postreak = new List<string>() { "1. Izozkia", "2. Pastela", "3. Fruitua", "4. Donut" };

    public void PostreakErakutsi()
    {
        Console.Clear();
        Console.WriteLine("Zer postre nahi duzu?");
        for (int i = 0; i < postreak.Count; i++)
        {
            Console.WriteLine(postreak[i]);
        }
        Console.WriteLine("5. Ez dut postrerik nahi");
        Console.WriteLine("Aukeratu bat mesedez:");
    }

}