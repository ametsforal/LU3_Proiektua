namespace ConsoleApp1;

class Hanburgesak
{
    List<string> hanburgesaenpresak = new List<string>() { "McDonald's", "Burger King" };
    List<string> mcdonalds_menu = new List<string>() { "Big Mac", "Cheeseburger", "Pulled Pork", "Hanburgesa klasikoa" };
    List<string> burgerking = new List<string>() { "Whopper", "Chesseburger", "Double Whopper", "Hanburgesa begetala" };

    public void HanburgesaEnpresak()
    {
        Console.Clear();
        Console.WriteLine("Bi aukera hauek ditugu, mesedez aukeratu bat(1 edo 2)");
        for (int i = 0; i < hanburgesaenpresak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {hanburgesaenpresak[i]}");
            }
    }
}