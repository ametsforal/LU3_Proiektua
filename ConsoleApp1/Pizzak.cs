using System.Collections;

namespace ConsoleApp1;

class Pizzak
{
    List<string> pizzaenpresak = new List<string>() { "Telepizza", "Pizza Hut" };
    List<string> pizzamotak = new List<string> { "Lau gazta pizza", "Pepperoni pizza",
    "Barbakoa pizza", "Anana pizza", "Urdaiazpiko eta gazta pizza" };
    List<string> osagaiak = new List<string>() { "Gazta", "Urdaiazpikoa", "Pepperoni", "Burrata", "Saltxitxa", "Oilaskoa", "Txanpioia", "Tipula", "Anana" };
    List<string> pizza = new List<string>();

    public void PizzaEnpresak()
    {
        for (int i = 0; i < pizzaenpresak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pizzaenpresak[i]}");
        }
    }
    public void Telepizza()
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri Telepizza-ra!");
        Console.WriteLine("Hona hemen menua:");
        for (int i = 0; i < pizzamotak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pizzamotak[i]}");
        }
        Console.WriteLine("Mesedez, aukeratu bat");
    }
    public string TelepizzaAukeratu(int aukera)
    {
        return pizzamotak[aukera - 1] + " (Telepizza)";
    }
    public void PizzaHut()
    {
        Console.Clear();
        Console.WriteLine("Hona hemen menua:");
        for (int i = 0; i < pizzamotak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {pizzamotak[i]}");
        }
        Console.WriteLine("Mesedez, aukeratu bat");
    }
    public string PizzaHutAukeratu(int aukera)
    {
        return pizzamotak[aukera - 1] + " (Pizza Hut)";
    }

    public void Pizza_egin()
    {
        Console.Clear();
        Console.WriteLine("*Pizzaren basea tomatea izango da*");
        Console.WriteLine("Hauek dira osagaiak, gutxienez 3 aukeratu");
        for (int i = 0; i < osagaiak.Count; i++)
        {
            Console.WriteLine($"{1 + i}. {osagaiak[i]}");
        }
        Console.WriteLine("10. Amaitu eta ikusi zure pizza");
        int auk = int.Parse(Console.ReadLine()!);
        switch (auk)
        {
            case 1:
                pizza.Add(osagaiak[0]);
                break;
            case 2:
                pizza.Add(osagaiak[1]);
                break;
            case 3:
                pizza.Add(osagaiak[2]);
                break;
            case 4:
                pizza.Add(osagaiak[3]);
                break;
            case 5:
                pizza.Add(osagaiak[4]);
                break;
            case 6:
                pizza.Add(osagaiak[5]);
                break;
            case 7:
                pizza.Add(osagaiak[6]);
                break;
            case 8:
                pizza.Add(osagaiak[7]);
                break;
            case 9:
                pizza.Add(osagaiak[8]);
                break;
            case 10:             
                break;
            default:
                Console.WriteLine("Aukera baliogabea, mesedez saiatu berriro (1-11)");
                Pizza_egin();
                break;
        }
        osagai_gehiago();
    }
    public void osagai_gehiago() //hemen galdetuko dizu osagai gehiago nahi badituzu, "ez" aukeratzen baduzu osagai guztiak pizzara gehituko dira eta edaria eskatzeko galdetuko dizu
    {
        Console.WriteLine("Osagai gehigo nahi dituzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine();

        if (aukera == "b" || aukera == "B")
        {
            Pizza_egin();
        }
        else if (aukera == "e" || aukera == "E")
        {
            if (pizza.Count < 3)
            {
                Console.WriteLine("Pizza gutxienez 3 osagai gehitu behar dituzu (Intro sakatu)");
                Console.ReadLine();
                Pizza_egin();
            }
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            osagai_gehiago();
        }
    }
    public string BueltatuPertsonalizatua(string aukera)
    {
        string emaitza = "";

        for (int i = 0; i < pizza.Count; i++)
        {
            emaitza += pizza[i] + " ";
        }
        return emaitza;
    }
}