namespace ConsoleApp1;

class Eskaerak
{
    public List<string> Menu_eskaerak = new List<string>();
    public List<string> Pizza_eskaera = new List<string>();

    public void MenuGehitu(string produktua)
    {
        Menu_eskaerak.Add(produktua);
    }
    public void PizzaPertsonalizatua(List<string> osagaiak)
    {
        Pizza_eskaera.AddRange(osagaiak);
    }
    public bool Hutsik()
    {
        return Menu_eskaerak.Count == 0 && Pizza_eskaera.Count == 0;
    }
    public void EskaeraErakutsi()
    {
        
        if (Hutsik())
        {
            Console.WriteLine("Zure eskaera hutsik dago");
        }
        else
        {
            Console.WriteLine("=== ZURE ESKAERA ===");
            for (int i = 0; i < Menu_eskaerak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu_eskaerak[i]}");
            }

            Console.WriteLine("\n=== PIZZA PERTSONALIZATUA ===");
            for (int i = 0; i < Pizza_eskaera.Count; i++)
            {
                Console.WriteLine($"{1 + i}. {Pizza_eskaera[i]}");
            }
        }
    }


    public void EskaeraHustu()
    {
        Menu_eskaerak.Clear();
        Pizza_eskaera.Clear();
    }
}