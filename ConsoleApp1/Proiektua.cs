using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

class Proiektua
{
    //Hasierako menua
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
                ikusi_eskaerak();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Irtetzen...");
                break;
            case 4:
                konfirmazioa();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                Aukerak();
                break;
        }
    }
    //
    List<string> menu_eskaerak = new List<string>();
    List<string> pizza_eskaera = new List<string>();

    public void ikusi_eskaerak() // Goiko bi zerrendak erakusteko
    {
        if (menu_eskaerak.Count == 0 && pizza_eskaera.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Oraindik ez dituzu eskaerarik egin! (Intro sakatu)");
            Console.ReadLine();
            Run();
        }
        else if (menu_eskaerak.Count != 0)
        {
            Console.WriteLine("Hauek dira gordetako menu eskaerak:");
            for (int i = 0; i < menu_eskaerak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu_eskaerak[i]}");
            }
            Console.Clear();
            Run();
        }
        if (pizza_eskaera.Count != 0)
        {
            Console.WriteLine("Zuk egindako pizza osagai hauek ditu: (intro sakatu aurrera joateko)");
            for (int i = 0; i < pizza_eskaera.Count; i++)
            {
                Console.WriteLine($"{1 + i}. {pizza_eskaera[i]}");
            }
            Console.ReadLine();
        }
    }
    List<string> janariamotak = new List<string>() { "1. Pizza", "2. Hanburguesa", };
    List<string> hanburgesaenpresak = new List<string>() { "1. McDonald's", "2. Burger King" };
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
    public void janariaukera() // goikoa aukeratu
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                Pizza();
                break;
            case 2:
                Hanburgesa();
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
    List<string> pizzaenpresak = new List<string>() { "1. Telepizza", "2. Pizza Hut" };
    public void Pizza() //pizza aukeratzen baduzu hemen eramango dizu, eta aukerak erakutsiko ditu
    {
        Console.Clear();
        Console.WriteLine("Enpresa hauek ditugu pizza erosteko:");
        for (int i = 0; i < pizzaenpresak.Count; i++)
        {
            Console.WriteLine(pizzaenpresak[i]);
        }
        Console.WriteLine("3. Itzuli aurreko menura.");
        Console.WriteLine("Mesedez, aukeratu bat:");
        pizzaaukera();
    }
    public void pizzaaukera() //aukeratu goiko menutik
    {
        string? aukera3 = Console.ReadLine();
        int auk3 = int.Parse(aukera3!);
        switch (auk3)
        {
            case 1:
                Telepizza();
                break;
            case 2:
                Pizza_hut();
                break;
            case 3:
                janariazkarra();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat(1, 2, 3 edo 4)");
                pizzaaukera();
                break;
        }
    }
    List<string> pizzamotak = new List<string> { "1. Lau gazta pizza", "2. Pepperoni pizza",
    "3. Barbakoa pizza", "4. Anana pizza", "5. Urdaiazpiko eta gazta pizza" };
    public void Telepizza() //telepizza aukeratzen baduzu hemen eramango dizu
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri Telepizza-ra!");
        Console.WriteLine("Hemen daukazu menua");
        for (int i = 0; i < pizzamotak.Count; i++)
        {
            Console.WriteLine(pizzamotak[i]);
        }
        Console.WriteLine("6. Atzera joan");
        Console.WriteLine("Mesedez, aukeratu bat");
        Telepizza_aukeratu();
    }
    public void Telepizza_aukeratu() // goikoa aukeratu eta eskaerara gehituko da
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);

        switch (auk)
        {
            case 1:
                Console.WriteLine("Lau gazta pizza eskaerara gehituta!");
                menu_eskaerak.Add("Lau gazta pizza (Telepizza)");
                edaria();
                break;
            case 2:
                Console.WriteLine("Pepperoni pizza eskaerara gehituta");
                menu_eskaerak.Add("Pepperoni pizza (Telepizza)");
                edaria();
                break;
            case 3:
                Console.WriteLine("Barbakoa pizza eskarira gehituta!");
                menu_eskaerak.Add("Barbakoa pizza (Telepizza)");
                edaria();
                break;
            case 4:
                Console.WriteLine("Anana pizza eskaerara gehituta!");
                menu_eskaerak.Add("Anana pizza (Telepizza)");
                edaria();
                break;
            case 5:
                Console.WriteLine("Urdaiazpiko eta gazta pizza eskarira gehituta!");
                menu_eskaerak.Add("Urdaiazpiko eta gazta pizza (Telepizza)");
                edaria();
                break;
            case 6:
                Pizza();
                break;
            default:
                Console.WriteLine("Aukera baliogabea, mesedez sartu gaituta dagoen zenbaki bat");
                Telepizza_aukeratu();
                break;
        }
    }
    List<string> pizza = new List<string>();
    public void Pizza_hut() // Pizza hut erabakitzen baduzu hemen eramango dizu
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri Pizza Hut-era!");
        Console.WriteLine("*Pizza-Hut-en ezaugarri bat da zuk zure pizza egin dezakezula*");
        Console.WriteLine("Menua ikusi nahi duzu edo zuk pizza egin nahi duzu?");
        Console.WriteLine("1. Menua ikusi");
        Console.WriteLine("2. Pizza 0-tik egin");
        Console.WriteLine("3. Atzera joan");
        Console.WriteLine("Aukeratu mesedez:");
        Pizza_hut_aukeratu();
    }
    public void Pizza_hut_aukeratu() //Goikoa aukeratu
    {

        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);

        switch (auk)
        {
            case 1:
                Console.WriteLine("Hemen daukazu menua");
                for (int i = 0; i < pizzamotak.Count; i++)
                {
                    Console.WriteLine(pizzamotak[i]);
                }
                Console.WriteLine("6. Atzera joan");
                Console.WriteLine("Mesedez, aukeratu bat");
                Pizza_hut_aukeratu_menua();
                break;
            case 2:
                pizza_egin1();
                break;
            case 3:
                Pizza();
                break;
            default:
                Console.WriteLine("Aukera baliogabea, mesez saiatu berrio.");
                Pizza_hut_aukeratu();
                break;
        }
    }
    public void pizza_egin1() //0tik pizza egin nahi baduzu hemen eramango dizu
    {
        Console.Clear();
        Console.WriteLine("*Pizzaren basea tomatea izango da*");
        Console.WriteLine("Hauek dira osagaiak, gutxienez 3 aukeratu");
        for (int i = 0; i < osagaiak.Count; i++)
        {
            Console.WriteLine($"{1 + i}. {osagaiak[i]}");
        }
        Console.WriteLine("10. Atzera joan");
        pizza_egin();
    }
    List<string> osagaiak = new List<string>() { "Gazta", "Urdaiazpikoa", "Pepperoni", "Burrata", "Saltxitxa", "Oilaskoa", "Txanpioia", "Tipula", "Anana" };
    public void pizza_egin() // hemen goiko osagaiak aukeratuko duzu eta gehituko dituzu pizzara
    {
        Console.WriteLine("Bat aukeratu mesedez:");
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);

        switch (auk)
        {
            case 1:
                pizza.Add(osagaiak[0]);
                osagai_gehiago();
                break;
            case 2:
                pizza.Add(osagaiak[1]);
                osagai_gehiago();
                break;
            case 3:
                pizza.Add(osagaiak[2]);
                osagai_gehiago();
                break;
            case 4:
                pizza.Add(osagaiak[3]);
                osagai_gehiago();
                break;
            case 5:
                pizza.Add(osagaiak[4]);
                osagai_gehiago();
                break;
            case 6:
                pizza.Add(osagaiak[5]);
                osagai_gehiago();
                break;
            case 7:
                pizza.Add(osagaiak[6]);
                osagai_gehiago();
                break;
            case 8:
                pizza.Add(osagaiak[7]);
                osagai_gehiago();
                break;
            case 9:
                pizza.Add(osagaiak[8]);
                osagai_gehiago();
                break;
            case 10:
                pizza.Clear();
                Pizza_hut();
                break;
            default:
                Console.WriteLine("Aukera baliogabea, mesedez saiatu berriro (1-10)");
                pizza_egin();
                break;
        }
    }
    public void osagai_gehiago() //hemen galdetuko dizu osagai gehiago nahi badituzu, "ez" aukeratzen baduzu osagai guztiak pizzara gehituko dira eta edaria eskatzeko galdetuko dizu
    {
        Console.WriteLine("Osagai gehigo nahi dituzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine();

        if (aukera == "b" || aukera == "B")
        {
            pizza_egin();
        }
        else if (aukera == "e" || aukera == "E")
        {
            if (pizza.Count < 3)
            {
                Console.WriteLine("Pizza gutxienez 3 osagai gehitu behar dituzu (Intro sakatu)");
                Console.ReadLine();
                pizza_egin1();
            }
            pizza_eskaera.AddRange(pizza);
            Console.WriteLine("Zure pizza osagai hauek ditu (intro sakatu aurrera joateko)");
            for (int i = 0; i < pizza.Count; i++)
            {
                Console.WriteLine($"{1 + i}. {pizza[i]}");
            }
            Console.ReadLine();
            edaria();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            osagai_gehiago();
        }
    }

    public void Pizza_hut_aukeratu_menua() //Pizza hut-ren menuan eskatu nahi baduzu hemen eramango dizu, aukeratutakoa gehituko da
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);

        switch (auk)
        {
            case 1:
                Console.WriteLine("Lau gazta pizza eskaerara gehituta!");
                menu_eskaerak.Add("Lau gazta pizza (Pizza Hut)");
                edaria();
                break;
            case 2:
                Console.WriteLine("Pepperoni pizza eskaerara gehituta");
                menu_eskaerak.Add("Pepperoni pizza (Pizza Hut)");
                edaria();
                break;
            case 3:
                Console.WriteLine("Barbakoa pizza eskarira gehituta!");
                menu_eskaerak.Add("Barbakoa pizza (Pizza Hut)");
                edaria();
                break;
            case 4:
                Console.WriteLine("Anana pizza eskaerara gehituta!");
                menu_eskaerak.Add("Anana pizza (Pizza Hut)");
                edaria();
                break;
            case 5:
                Console.WriteLine("Urdaiazpiko eta gazta pizza eskarira gehituta!");
                menu_eskaerak.Add("Urdaiazpiko eta gazta pizza (Pizza Hut)");
                edaria();
                break;
            case 6:
                Pizza();
                break;
            default:
                Console.WriteLine("Aukera baliogabea, mesedez sartu gaituta dagoen zenbaki bat.");
                Pizza_hut_aukeratu();
                break;
        }
    }
    public void Hanburgesa() //hanburgesa jan nahi baduzu hemen eramango dizu eta aukerak erakutsiko ditu
    {
        Console.Clear();
        Console.WriteLine("Enpresa hauek ditugu hanburgesa erosteko:");
        for (int i = 0; i < hanburgesaenpresak.Count; i++)
        {
            Console.WriteLine(hanburgesaenpresak[i]);
        }
        Console.WriteLine("3. Itzuli aurreko menura.");
        Console.WriteLine("Mesedez, aukeratu bat:");
        Hanburgesa_aukera();
    }
    public void Hanburgesa_aukera() //goiko menuko aukerak aukeratzeko
    {
        string? aukera2 = Console.ReadLine();
        int auk2 = int.Parse(aukera2!);
        switch (auk2)
        {
            case 1:
                McDonalds();
                break;
            case 2:
                BurgerKing();
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


    List<string> mcdonalds_menu = new List<string>() { "Big Mac", "Cheeseburger", "Pulled Pork", "Hanburgesa klasikoa" };
    public void McDonalds() // Mcdonalds-en jan nahi baduzu hemen eramango dizu
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri McDonald's-era!");
        Console.WriteLine("Hona hemen menua:");
        for (int i = 0; i < mcdonalds_menu.Count; i++)
        {
            Console.WriteLine($"{1 + i}. {mcdonalds_menu[i]}");
        }
        Console.WriteLine("5. Itzuli aurreko menura");
        Console.WriteLine("Mesedez, aukeratu bat:");
        McDonalds_aukeratu();
    }
    public void McDonalds_aukeratu() //mcdonalds-eko janari aukerak, eta eskarira gehitu-ko dira aukeratutako gauzak
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                Console.WriteLine($"{mcdonalds_menu[0]} eskarira gehituta!.");
                menu_eskaerak.Add($"{mcdonalds_menu[0]} (McDonald's)");
                edaria();
                break;
            case 2:
                Console.WriteLine($"{mcdonalds_menu[1]} eskarira gehituta!");
                menu_eskaerak.Add($"{mcdonalds_menu[1]} (McDonald's)");
                edaria();
                break;
            case 3:
                Console.WriteLine($"{mcdonalds_menu[2]} eskarira gehituta!");
                menu_eskaerak.Add($"{mcdonalds_menu[2]} (McDonald's)");
                edaria();
                break;
            case 4:
                Console.WriteLine($"{mcdonalds_menu[3]} eskarira gehituta!");
                menu_eskaerak.Add($"{mcdonalds_menu[3]} (McDonald's)");
                edaria();
                break;
            case 5:
                Hanburgesa();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                McDonalds();
                break;
        }
    }
    List<string> burgerking = new List<string>() { "Whopper", "Chesseburger", "Double Whopper", "Hanburgesa begetala" };
    public void BurgerKing() // Burger king-en jan nahi baduzu hemen eramango dizu
    {
        Console.Clear();
        Console.WriteLine("Ongi etorri BurgerKing-era!");
        Console.WriteLine("Hona hemen menua:");
        for (int i = 0; i < burgerking.Count; i++)
        {
            Console.WriteLine($"{1 + i}. {burgerking[i]}");
        }
        Console.WriteLine("5. Itzuli aurreko menura");
        Console.WriteLine("Mesedez, aukeratu bat:");
        BurgerKing_aukeratu();
    }
    public void BurgerKing_aukeratu() //hemen burgerking-eko zer jan nahi duzun aukeratuko duzu eta eskarira gehituko da
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                Console.Clear();
                Console.WriteLine($"{burgerking[0]} eskarira gehituta!.");
                menu_eskaerak.Add($"{burgerking[0]} (Burger King)");
                edaria();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine($"{burgerking[1]} eskarira gehituta");
                menu_eskaerak.Add($"{burgerking[1]} (Burger King)");
                edaria();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine($"{burgerking[2]} eskarira gehituta!");
                menu_eskaerak.Add($"{burgerking[2]} (Burger King)");
                edaria();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine($"{burgerking[3]}eskarira gehituta!");
                menu_eskaerak.Add($"{burgerking[3]} (Burger King)");
                edaria();
                break;
            case 5:
                Hanburgesa();
                break;
            default:
                Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                McDonalds();
                break;
        }

    }

    List<string> edariak = new List<string>() {"1. Coca-cola", "2. Fanta", "3. Sprite",
    "4. Aquarius","5. Ura" };
    public void edaria() //menu guztietatik hemen eramango dizu, edaria aukeratzeko
    {
        Console.Clear();
        Console.WriteLine("Edaririk nahi duzu? Bai(b)/Ez(e)");
        string? aukera1 = Console.ReadLine();
        if (aukera1 == "b" || aukera1 == "B")
        {
            Console.Clear();
            Console.WriteLine("Zer edari nahi duzu?");
            for (int i = 0; i < edariak.Count; i++)
            {
                Console.WriteLine(edariak[i]);
            }
            Console.WriteLine("6. Ez dut edaririk nahi");
            Console.WriteLine("Mesedez, aukeratu bat:");
            string? aukera = Console.ReadLine();
            int auk = int.Parse(aukera!);
            switch (auk)
            {
                case 1:
                    Console.WriteLine("Coca-cola eskarira gehituta!");
                    menu_eskaerak.Add("Coca-cola");
                    break;
                case 2:
                    Console.WriteLine("Fanta eskarira gehituta!");
                    menu_eskaerak.Add("Fanta");
                    break;
                case 3:
                    Console.WriteLine("Sprite eskarira gehituta!");
                    menu_eskaerak.Add("Sprite");
                    break;
                case 4:
                    Console.WriteLine("Aquarius eskarira gehituta!");
                    menu_eskaerak.Add("Aquarius");
                    break;
                case 5:
                    Console.WriteLine("Ura eskarira gehituta!");
                    menu_eskaerak.Add("Ura");
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu gaituta dagoen zenbaki bat.");
                    edaria();
                    break;
            }
            postreanahi();
        }
        else if (aukera1 == "e" || aukera1 == "E")
        {
            postreanahi();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e ");
        }
    }
    public void postreanahi() //edaria ondoren postrea nahi duzun galdetuko du
    {
        Console.Clear();
        Console.WriteLine("Postrerik nahi duzu? Bai(b)/Ez(e)");

        string? aukera = Console.ReadLine();
        if (aukera == "b" || aukera == "B")
        {
            postrea();
        }
        else if (aukera == "e" || aukera == "E")
        {
            eskaeragehiago();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            postreanahi();
        }
    }
    List<string> postreak = new List<string>() { "1. Izozkia", "2. Pastela", "3. Fruitua", "4. Donut" };
    public void postrea() //Postreak erakutsiko ditu
    {
        Console.Clear();
        Console.WriteLine("Hemen daude gure postreak");
        for (int i = 0; i < postreak.Count; i++)
        {
            Console.WriteLine(postreak[i]);
        }
        Console.WriteLine("5. Ez dut postrerik nahi");
        Console.WriteLine("Aukeratu bat mesedez:");
        postrea_aukeratu();
    }
    public void postrea_aukeratu() //postrea aukeratuko duzu
    {
        string? aukera = Console.ReadLine();
        int auk = int.Parse(aukera!);
        switch (auk)
        {
            case 1:
                Console.WriteLine("Izozkia eskarira gehituta!");
                menu_eskaerak.Add("Izozkia");
                break;
            case 2:
                Console.WriteLine("Pastela eskarira gehituta!");
                menu_eskaerak.Add("Pastela");
                break;
            case 3:
                Console.WriteLine("Fruitua eskarira gehituta!");
                menu_eskaerak.Add("Fruitua");
                break;
            case 4:
                Console.WriteLine("Donut-a eskarira gehituta!");
                menu_eskaerak.Add("Donut");
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Aukera baliogabea mesedez sartu gaituta dagoen zenbaki bat");
                postrea();
                break;
        }
        eskaeragehiago();
    }
    public void eskaeragehiago() //Zerbait gehiago egin nahi duzun galdetuko du, erantzuna bai bada, hasierako menura eramango dizu
    {
        Console.WriteLine("Zerbait gehiago egin nahi duzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine();
        if (aukera == "b" || aukera == "B")
        {
            Run();
        }
        else if (aukera == "e" || aukera == "E")
        {
            konfirmazioa();
        }
        else
        {
            Console.WriteLine("Aukera ez da zuzena. Mesedez, sartu b edo e "); ;
            eskaeragehiago();
        }
    }
    public void konfirmazioa() // Zure eskaerak erakutsiko ditu eta zuk esango duzu konforme zauden edo ez
    {
        Console.Clear();
        if (menu_eskaerak.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Ez dituzu Eskaerarik egin! (Intro sakatu)");
            Console.ReadLine();
            Console.Clear();
            Run();
        }
        else
        {
            Console.WriteLine("Hau erabaki duzu erostea, zerbait gehitu nahi duzu? Bai(b)/Ez(e)");
            for (int i = 0; i < menu_eskaerak.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menu_eskaerak[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Pizza pertsonalizatua:");
            for (int i = 0; i<pizza_eskaera.Count; i++)
            {
                Console.WriteLine(pizza_eskaera[i]);
            }
            Console.WriteLine();
            string? aukera = Console.ReadLine();
            if (aukera == "b" || aukera == "B")
            {
                Run();
            }
            else if (aukera == "e" || aukera == "E")
            {
                bezero_datuak();
            }
            else
            {
                Console.WriteLine("Aukera baliogabea berriz saiatu mesedez.");
                konfirmazioa();
            }
        }
    }
    public void bezero_datuak() // eskaera bukatzeko zure datuak eskatuko ditu
    {
        Console.WriteLine("Bukatzeko zure datuak sartu:");
        Console.Write("Izen abizenak: ");
        string? izena = Console.ReadLine();
        Console.Write("Helbidea: ");
        string? helbidea = Console.ReadLine();
        Console.Write("telefono zenbakia: ");
        string? zenbakia = Console.ReadLine();
        Console.WriteLine();
        Console.Clear();
        Console.WriteLine("Hauek dira zure helbide datuak:");
        Console.WriteLine("ZURE DATUAK:");
        Console.WriteLine($"Izen abizenak: {izena}");
        Console.WriteLine($"Helbidea: {helbidea}");
        Console.WriteLine($"Telefono zenbakia: {zenbakia}");
        Console.WriteLine();
        
        Console.WriteLine("Eskaera arrakastatsua izan da!");
        eskaera_berria();
    }
    public void eskaera_berria() // Azkenik eskaera berririk nahi duzun egin galdetuko du eta programa bukatuko da ez erantzuten baduzu
    {
        Console.WriteLine("Eskaera berri bat egin nahi duzu? Bai(b)/Ez(e)");
        string? aukera = Console.ReadLine();
        if (aukera == "b" || aukera == "B")
        {
            menu_eskaerak.Clear();
            pizza_eskaera.Clear();
            Run();
        }
        else if (aukera == "e" || aukera == "E")
        {
            Console.WriteLine("Eskerrik asko Taxi's erabiltzeagatik. Ongi Izan!");
        }
        else
        {
            Console.WriteLine("Aukera baliogabea, mesedez berriro saiatu (Intro sakatu)");
            Console.ReadLine();
            eskaera_berria();
        }
    }
}