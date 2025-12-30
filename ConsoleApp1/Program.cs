using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace ConsoleApp1;
class Program
{
    public static void Main(string[] args)
    {
        /* Eskaerak l = new Eskaerak();
        l.MenuGehitu("Pizza");
        l.MenuGehitu("Pasta");
        l.PizzaPertsonalizatua(new List<string> { "Tomate", "Gazta", "Olibak" });
        l.EskaeraErakutsi();
        Console.WriteLine();
        l.EskaeraHustu();
        l.EskaeraErakutsi(); */

        Menuak l = new Menuak();
        l.Run();
    }
}
