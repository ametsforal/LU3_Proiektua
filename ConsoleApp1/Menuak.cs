namespace ConsoleApp1;

class Menuak
{
    //Hasierako menua
    public Eskaerak eskaera = new Eskaerak();
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("===========================");
        Console.WriteLine("Ongi etorri Taxi's App-era!");
        Console.WriteLine("===========================");
        Console.WriteLine("Zer egin nahi duzu?");
        Console.WriteLine("1. Eskaera bat egin edo eskaerarekin jarraitu.");
        Console.WriteLine("2. Eskaerak ikusi. ");
        Console.WriteLine("3. Irten. ");
        Console.WriteLine("4. Eskaera bukatu");
        Console.WriteLine("5. Eskaera hustu");
        Console.WriteLine("Mesedez, aukeratu zer egin nahi duzun:(aukeratu zenbakiekin: 1, 2, 3...)");
        Aukerak();
    }
    public void Aukerak() //Hasierako menuaren aukerak erabiltzeko
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);

        switch (auk)
        {
            case 1:
                janariazkarra();
                break;
            case 2:
                eskaera.EskaeraErakutsi();
                Run();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Irtetzen...");
                break;
            case 4:
                //konfirmazioa();
                break;
            case 5:
                eskaera.EskaeraHustu();
                Console.Clear();
                Console.ReadLine();
                Run();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                Aukerak();
                break;
        }
    }
    List<string> janariamotak = new List<string>() { "1. Pizza", "2. Hanburguesa", };
    public void janariazkarra() //Aukeratu pizza edo hanburgesa nahi duzun 
    {
        Console.Clear();
        Console.WriteLine("Zer jan nahi duzu?");
        for (int i = 0; i < janariamotak.Count; i++)
        {
            Console.WriteLine(janariamotak[i]);
        }
        Console.WriteLine("3. Aurreko menura itzuli.");
        Console.WriteLine("Mesedez, aukeratu bat:");
        janariaukera();
    }

    Hanburgesak hanburgesa = new Hanburgesak();
    Pizzak pizza = new Pizzak();
    public void janariaukera()
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Bi aukera hauek ditugu, mesedez aukeratu bat (1 edo 2)");
                pizza.PizzaEnpresak();
                Console.WriteLine("3 sakatu atzera joateko");
                Pizza_Aukera();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Bi aukera hauek ditugu, mesedez aukeratu bat (1 edo 2)");
                hanburgesa.HanburgesaEnpresak();
                Console.WriteLine("3 sakatu atzera joateko");
                Hanburgesa_aukera();
                break;
            case 3:
                Run();
                break;
            default:
                Console.WriteLine("Aukera baliogabea, saiatu berriro mesedez");
                janariaukera();
                break;
        }
    }
    public void Hanburgesa_aukera()
    {
        string? aukera2 = Console.ReadLine();
        int auk2 = int.Parse(aukera2!);
        switch (auk2)
        {
            case 1:
                hanburgesa.Mcdonalds();
                int aukera = int.Parse(Console.ReadLine()!);
                eskaera.EskaeraGehitu(hanburgesa.MCHanburgesaAukeratu(aukera));
                break;
            case 2:
                hanburgesa.Burgerking();
                int aukera1 = int.Parse(Console.ReadLine()!);
                eskaera.EskaeraGehitu(hanburgesa.BKHanburgesaAukeratu(aukera1));
                break;
            case 3:
                janariazkarra();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                Hanburgesa_aukera();
                break;
        }
    }
    public void Pizza_Aukera()
    {
        string? aukera2 = Console.ReadLine();
        int auk2 = int.Parse(aukera2!);
        switch (auk2)
        {
            case 1:
                pizza.Telepizza();
                int aukera = int.Parse(Console.ReadLine()!);
                eskaera.EskaeraGehitu(pizza.TelepizzaAukeratu(aukera));
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Ongi etorri Pizza Hut-era!");
                Console.WriteLine("*Pizza-Hut-en ezaugarri bat da zuk zure pizza egin dezakezula*");
                Console.WriteLine("Menua ikusi nahi duzu edo zuk pizza egin nahi duzu?");
                Console.WriteLine("1. Menua ikusi");
                Console.WriteLine("2. Pizza 0-tik egin");
                Console.WriteLine("Aukeratu mesedez:");
                int auk = int.Parse(Console.ReadLine()!);
                switch (auk)
                {
                    case 1:
                        pizza.PizzaHut();
                        int aukera1 = int.Parse(Console.ReadLine()!);
                        eskaera.EskaeraGehitu(pizza.PizzaHutAukeratu(aukera1));
                        eskaera.EskaeraErakutsi();
                        break;
                    case 2:
                        pizza.Pizza_egin();
                        eskaera.PizzaPertsonalizatua(pizza.BueltatuPertsonalizatua(aukera2));
                        eskaera.EskaeraErakutsi();
                        break;
                    default:
                        Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                        Pizza_Aukera();
                        break;
                }
                break;
            case 3:
                janariazkarra();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                Pizza_Aukera();
                break;
        }
    }
    
}
