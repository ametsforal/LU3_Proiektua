namespace ConsoleApp1;

class Hanburgesak
{
    List<string> hanburgesaenpresak = new List<string>() { "McDonald's", "Burger King" };
    List<string> mcdonalds_menu = new List<string>() { "Big Mac", "Cheeseburger", "Pulled Pork", "Hanburgesa klasikoa" };
    List<string> burgerking = new List<string>() { "Whopper", "Chesseburger", "Double Whopper", "Hanburgesa begetala" };

    public void HanburgesaEnpresak()
    {
        for (int i = 0; i < hanburgesaenpresak.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {hanburgesaenpresak[i]}");
        }
    }
    public void Mcdonalds()
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri McDonald's-era!");
        Console.WriteLine("Hona Hemen menua:");
        for (int i = 0; i < mcdonalds_menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {mcdonalds_menu[i]}");
        }

    }
    public string MCHanburgesaAukeratu(int aukera)
    {
        return mcdonalds_menu[aukera - 1] + " (McDonald's)";

    }
    public void Burgerking()
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri BurgerKing-era!");
        Console.WriteLine("Hona hemen menua:");

        for (int i = 0; i < burgerking.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {burgerking[i]}");
        }
    }
    public string BKHanburgesaAukeratu(int aukera)
    {
        return burgerking[aukera - 1] + " (Burger King)";
    }
}