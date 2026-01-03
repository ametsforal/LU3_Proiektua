namespace ConsoleApp1;

class Menuak
{
    //Hasierako menua
    public Eskaerak eskaera = new Eskaerak();
    Bezeroak bezeroa = new Bezeroak();

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
        Console.WriteLine("6. Nire datuak ikusi");
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
                Konfirmazioa();
                break;
            case 5:
                eskaera.EskaeraHustu();
                Console.Clear();
                Run();
                break;
            case 6:
                bezeroa.DatuakDaude2();
                Run();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, 1-6 dagoen zenbaki bat sartu:");
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
                Console.WriteLine("3. atzera joan");
                Pizza_Aukera();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Bi aukera hauek ditugu, mesedez aukeratu bat (1 edo 2)");
                hanburgesa.HanburgesaEnpresak();
                Console.WriteLine("3. Atzera joan");
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
        Edaria();
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
                        break;
                    case 2:
                        pizza.Pizza_egin();
                        eskaera.PizzaPertsonalizatua(pizza.BueltatuPertsonalizatua(aukera2));
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Aukera ez da zuzena. Mesedez, berriro aukeratu:");
                        pizza.PizzaEnpresak();
                        Console.WriteLine("3. Atzera joan");
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
        Edaria();
    }
    Edariak edaria = new Edariak();
    public void Edaria()
    {
        Console.WriteLine("Edaririk nahi duzu? Bai(b)/Ez(e)");
        string a = Console.ReadLine()!;

        if (a == "b" || a == "B")
        {
            edaria.EdariakErakutsi();
            int aukera = int.Parse(Console.ReadLine()!);
            switch (aukera)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    eskaera.EskaeraGehitu(edaria.EdariaAukeratu(aukera));
                    Postrea();
                    break;
                case 6:
                    Console.Clear();
                    Postrea();
                    break;
                default:
                    Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                    Edaria();
                    break;
            }
        }
        else if (a == "e" || a == "E")
        {
            Postrea();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e ");
            Edaria();
        }

    }
    Postreak postre = new Postreak();
    public void Postrea()
    {
        Console.Clear();
        Console.WriteLine("Postrerik nahi duzu? Bai(b)/Ez(e)");
        string? a = Console.ReadLine()!;
        if (a == "b" || a == "B")
        {
            postre.PostreakErakutsi();
            int aukera = int.Parse(Console.ReadLine()!);
            switch (aukera)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    eskaera.EskaeraGehitu(postre.PostreaAukeratu(aukera));
                    Eskaeragehiago();

                    break;
                case 5:
                    Console.Clear();
                    Eskaeragehiago();
                    break;
                default:
                    Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                    Postrea();
                    break;
            }
        }
        else if (a == "e" || a == "E")
        {
            Eskaeragehiago();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            Postrea();
        }
    }
    public void Eskaeragehiago() //Zerbait gehiago egin nahi duzun galdetuko du, erantzuna bai bada, hasierako menura eramango dizu
    {
        Console.WriteLine("Zerbait gehiago egin nahi duzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine();
        if (aukera == "b" || aukera == "B")
        {
            Run();
        }
        else if (aukera == "e" || aukera == "E")
        {
            Konfirmazioa();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            Eskaeragehiago();
        }
    }
    public void Konfirmazioa()
    {
        if (eskaera.BiakHutsik() == true)
        {
            Console.WriteLine("Zure eskaera hustik dago! (Intro sakatu)");
            Console.ReadLine();
            Run();
        }
        else if (eskaera.BiakHutsik() == false)
        {
            Console.Clear();
            Console.WriteLine("Zure eskaera honako hau da:");
            eskaera.EskaeraErakutsi();
            bezeroa.DatuakEzarri();
            Console.WriteLine("\nZure eskaera arrakastatsua izan da! Eskerrik asko gure zerbitzua erabiltzeagatik. (Intro sakatu)");
            Console.ReadLine();
            
        }
    }
    public void BesteEskaera()
    {
        Console.WriteLine("Eskaera berri bat egin nahi duzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine()!;
        if (aukera == "b" || aukera == "B")
        {
            eskaera.EskaeraGarbitu();
            Run();
        }
        else if (aukera == "e" || aukera == "E")
        {
            Console.Clear();
            Console.WriteLine("Eskerrik asko Taxi's erabiltzeagatik. Ongi Izan!");
        }
        else
        {
            Console.WriteLine("Aukera baliogabea, mesedez berriro saiatu (Intro sakatu)");
            Console.ReadLine();
            BesteEskaera();
        }
    }
}
