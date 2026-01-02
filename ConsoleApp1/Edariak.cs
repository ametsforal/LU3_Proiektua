namespace ConsoleApp1;

class Edariak
{
    List<string> edariak = new List<string>() {"Coca-cola", "Fanta", "Sprite",
    "Aquarius","Ura" };
    public void EdariakErakutsi()
    {
        Console.Clear();
        Console.WriteLine("Zer edari nahi duzu?");
        for (int i = 0; i < edariak.Count; i++)
        {
            Console.WriteLine($"{1 + i}. {edariak[i]}");
        }
        Console.WriteLine("6. Ez dut edaririk nahi");
    }
    public string EdariaAukeratu(int aukera)
    {
        return edariak[aukera - 1] + " (Edaria)";
    }
}