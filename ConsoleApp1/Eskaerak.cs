using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

class Eskaerak
{
    public List<string> Menu_eskaerak = new List<string>();
    public List<string> Pizza_eskaera = new List<string>();

    public void EskaeraGehitu(string produktua)
    {
        Menu_eskaerak.Add(produktua);
    }
    public void PizzaPertsonalizatua(string osagaiak)
    {
        Pizza_eskaera.AddRange(osagaiak);
    }
    public bool Hutsik()
    {
        return Menu_eskaerak.Count == 0;
    }
    public bool PizzaHutsik()
    {
        return Pizza_eskaera.Count == 0;
    }
    public bool BiakHutsik()
    {
        return Hutsik() && PizzaHutsik();
    }
    public void EskaeraErakutsi()
    {
        Console.Clear();
        if (BiakHutsik())
        {
            Console.Clear();
            Console.WriteLine("Zure eskaera hutsik dago! (Intro sakatu jarraitzeko)");
        }
        if (Hutsik() == false)
        {
            Console.WriteLine("=== ZURE ESKAERA ===");
            for (int i = 0; i < Menu_eskaerak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu_eskaerak[i]}");
            }
        }
        if (PizzaHutsik() == false)
        {
            Console.WriteLine("\n=== PIZZA HUT PERTSONALIZATUA ===");
            for (int i = 0; i < Pizza_eskaera.Count; i++)
            {
                Console.WriteLine($"{1 + i}. {Pizza_eskaera[i]}");
            }
        }
        Console.ReadLine();
    }


    public void EskaeraHustu()
    {
        if (BiakHutsik())
        {
            Console.Clear();
            Console.WriteLine("Zure eskaera hutsik dago! (Intro sakatu jarraitzeko)");
            Console.ReadLine();
        }
        else
        {
                    Console.Clear();
        Console.WriteLine("Zein hustu nahi duzu?");
        Console.WriteLine("1. Menu eskaera");
        Console.WriteLine("2. Pizza pertsonalizatua");
        Console.WriteLine("3. Biak");
        Console.WriteLine("4. Atzera joan");
        int aukera = int.Parse(Console.ReadLine()!);
        switch (aukera)
        {
            case 1:
                Menu_eskaerak.Clear();
                Console.WriteLine("Eskaera hustuta! (Intro sakatu jarraitzeko)");
                Console.ReadLine();
                break;
            case 2:
                Pizza_eskaera.Clear();
                Console.WriteLine("Eskaera hustuta! (Intro sakatu jarraitzeko)");
                Console.ReadLine();
                break;
            case 3:
                Menu_eskaerak.Clear();
                Pizza_eskaera.Clear();
                Console.WriteLine("Eskaera hustuta! (Intro sakatu jarraitzeko)");
                Console.ReadLine();
                break;
            case 4:
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat. (Intro sakatu)");
                EskaeraHustu();
                Console.ReadLine();
                break;
        }
        }

    }
    public void EskaeraGarbitu()
    {
        Menu_eskaerak.Clear();
        Pizza_eskaera.Clear();
    }
}