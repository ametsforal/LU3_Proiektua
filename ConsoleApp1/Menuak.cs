namespace ConsoleApp1;

class Menuak
{
    //Hasierako menua
    Eskaerak eskaera = new Eskaerak();
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("===========================");
        Console.WriteLine("Ongi etorri Taxi's App-era!");
        Console.WriteLine("===========================");
        Console.WriteLine("Zer egin nahi duzu?");
        Console.WriteLine("1. Eskaera bat egin.");
        Console.WriteLine("2. Eskaerak ikusi. ");
        Console.WriteLine("3. Irten. ");
        Console.WriteLine("4. Eskaera bukatu");
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
    public void janariaukera() // goikoa aukeratu
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                //Pizza();
                break;
            case 2:
                hanburgesa.HanburgesaEnpresak();
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
}
