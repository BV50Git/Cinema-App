using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using CinemaApp;
using CInemaApp;
using System.Diagnostics;

namespace CInemaApp
{

    public class Globals
    {
        public static string[] array;
        public static string Moviename;
        public static string total;
        public static int group;
    }


    public class Administrator
    {
        // creates the price classes on the bases of age
        public string[] Age_prices_array()
        {
            string[] agebrackets_in_cinema = { Translation.SR55, Translation.SR56, Translation.SR57 };
            string[] array = { "1", "2", "3", "4" };
            int agebrackets = 4;
            for (int i = 0; i < agebrackets; i++)
            {
                Console.WriteLine("The price for " + agebrackets_in_cinema[i] + " is?");
                string agebracket_and_price = Console.ReadLine();
                array[i] = agebrackets_in_cinema[i] + " " + agebracket_and_price;
            }

            //var stringjson = JsonConvert.SerializeObject(array, Formatting.Indented);
            //System.IO.File.AppendAllText(@"C: \Users\Acer\AppData\Local\Temp\~vs39C6.json", stringjson);
            return array;
        }

    }
        // the class for the costumer this way the costumer can use different functions within the application
        public class Costumer
        {
            public string[] Newarray;
            public string[] Shows_prices_by_age()
            {
                Console.WriteLine(Translation.SR58);
                Console.WriteLine(Newarray[0]);
                Console.WriteLine(Newarray[1]);
                Console.WriteLine(Newarray[2]);
                Console.WriteLine(Newarray[3]);
                Console.WriteLine(Newarray[4]);
                return Newarray;
            }
        }
    

    public class Login
    {
        public static void Password()
        {
            Console.Write(Translation.SR13);
            string pass = Console.ReadLine();

            if (pass == "Admin")
                Admin.Menu();
            else
                Console.WriteLine(Translation.SR14);
                Password();
        }
        public static void Question()
        {
            User.STARS();
            Console.WriteLine(Translation.SR15);
            string Answer = Console.ReadLine();


            //StringComparison.OrdinalIgnoreCase makes sure that the answer gets through despite it being upper or lower case
            //Answer.Equals is the same as Answer = "U"
            if (Answer.Equals("U", StringComparison.OrdinalIgnoreCase))
                User.Menu();
            else if (Answer.Equals("A", StringComparison.OrdinalIgnoreCase))
                Password();
            else
                Question();
            //repeats the question if it isn't answered properly .-.
        }
    }
    // menu screen for the user
    public class User
    {
        public static void STARS()
        {
            Console.WriteLine("********************");
        }
        public static void bb()
        //works as a back button
        {
            Console.WriteLine(Translation.SR16);
            string key = Console.ReadLine();

            if (key == "" + "") //enter
                Menu();
            else
                bb();

        }

        public static void PaymentOption()
        {

            string output = "";
            int counter = 0;
            int x = Globals.group;
            Console.WriteLine(x);
            int i = 0;
            while (i < x)
            {


                Console.WriteLine(Translation.SR59);
                Console.WriteLine(Translation.SR60);

                string agegroup = Console.ReadLine();
                int j = 0;
                while (j < 1)
                {
                    if (x > 1)
                    {


                        if (agegroup == "1")
                        {

                            counter = counter + 1;
                            string response = Translation.SR61 +  + counter + " ";
                            output = output + " " + response + Translation.SR62;

                            j++;
                        }
                        if (agegroup == "2")
                        {

                            counter = counter + 1;
                            string response = Translation.SR61 + counter + " ";
                            output = output + " " + response + Translation.SR63;
                            j++;
                        }
                        if (agegroup == "3")
                        {

                            counter = counter + 1;
                            string response = Translation.SR61 + counter + " ";
                            output = output + " " + response + Translation.SR64;
                            j++;
                        }
                        if (agegroup == "4")
                        {

                            counter = counter + 1;
                            string response = Translation.SR61 + counter + " ";
                            output = output + " " + response + Translation.SR65;
                            j++;
                        }
                    }
                    i++;
                    if (x == 1)
                    {
                        if (agegroup == "1")
                        {

                            counter = counter + 1;
                            string response = Translation.SR66;
                            output = output + " " + response + Translation.SR67;
                            j++;
                        }
                        if (agegroup == "2")
                        {

                            counter = counter + 1;
                            string response = Translation.SR66;
                            output = output + " " + response + Translation.SR68;
                            j++;
                        }
                        if (agegroup == "3")
                        {

                            counter = counter + 1;
                            string response = Translation.SR66;
                            output = output + " " + response + Translation.SR69;
                            j++;
                        }
                        if (agegroup == "4")
                        {

                            counter = counter + 1;
                            string response = Translation.SR66;
                            output = output + " " + response + Translation.SR70;
                            j++;
                        }
                    i++;
                    }
                    
                }

            }
            Payment();
        }
        public static void Payment()
        {
            Console.WriteLine(Translation.SR71 + Globals.Moviename);
            Console.WriteLine(Translation.SR72);
            Console.WriteLine(Translation.SR73);
            string c = "0";
            string s = "";
            int counter = 1;
            int options = 2;
            int i;
            int j;
            int height = 9;
            int width = 9;
            while (counter < options)
            {
                for (i = 1; i <= height; i++)
                {
                    for (j = 1; j <= width; j++)
                    {
                        if (i == 1 || i == height || j == 1 || j == width)
                            s = s + " *";
                        else
                            s = s + "  ";
                    }
                    s = s + "\n";
                }
                if (counter == 1)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(Translation.SR5);
                }
                counter = counter + 1;
            }

            Console.WriteLine(s);
            Console.WriteLine(Translation.SR6);
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine(Translation.SR74);
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine(Translation.SR75);
                        }
                        else if (information.Length == 8)
                        {
                            c = "4";
                            d = 1;
                        }
                    }
                }
                if (c == "2")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine(Translation.SR76);
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine(Translation.SR75);
                        }
                        else if (information.Length == 8)
                        {
                            c = "4";
                            d = 1;
                        }

                    }
                }


            }
            // shows final ticket and show the time and payment done.
            Console.WriteLine(Translation.SR77);
        }

        public static void Contact()
        {
            Console.WriteLine("CINEMAPP CONTACT INFO\n");
            Console.WriteLine(Translation.SR17);
            Console.WriteLine(Translation.SR18);
            bb();
        }
        public static void Current()
        {
            Console.WriteLine(Translation.SR19);
            List<Movie> list = Data.LoadMovies();
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                Console.WriteLine(x + " " + Data.LoadMovies()[x - 1].GetMovieName());

            }
            Console.WriteLine(Translation.SR78);
            string Moviename = Console.ReadLine();
            bool found = false;
            //goes through the whole json file
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                
                if (Moviename == Data.LoadMovies()[x - 1].GetMovieName())
                {
                    
                    string seats = SeatingReservation.Seat();
                    
                    Console.WriteLine(Translation.SR79 + Moviename + Translation.SR80 + seats);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine(Translation.SR54);
            }
                bb();
            
        }
        public static void Upcoming()
        {
            
            Console.WriteLine(Translation.SR38);
            List<string> Movies = new List<string>();
            Movies.Add("Bad Boys for Life (2020)");
            Movies.Add("The Godfather (1974)");
            Movies.Add("1917 (2020)");
            Movies.Add("Guardians of the Galaxy (2014)");
            Movies.Add("Joker (2019)");

            foreach (var movie in Movies)

                Console.WriteLine(movie);
            bb();
        }
        public static void Prices()
        {
            string x = "0";
            while (x != "2")
            {
                Console.WriteLine(Translation.SR20);
                x = Console.ReadLine();
                if (x == "1")
                {
                    Console.WriteLine(Translation.SR81);
                    string str = File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../json1.json");
                    string[] sepparator = { "{", "Newarray", "[", "}", "]", ":", ",", "\"", "array_movie_times_and_location", "null" };
                    string[] stringlist = str.Split(sepparator, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in stringlist)
                    {
                        Console.WriteLine(s);
                    }


                    // future reading code to make sure it reads without the brackets
                    //for (int d = 1; d < Dataprices.LoadPrices().Count + 1; d++)
                    //{
                    //    Console.WriteLine(x + ": " + Dataprices.LoadPrices()[d - 1].Getmovietime());
                    //}
                }
                else if (x == "2")
                {

                    bb();
                    x = "2";
                }
                else
                {
                    Console.WriteLine(Translation.SR29);
                    Prices();
                }
            }
        }
        public static void Events()
        {
            STARS();
            Console.WriteLine(Translation.SR26);
            Console.WriteLine(Translation.SR82);
            var ev = Console.ReadLine();

            if (ev.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                STARS();
                Console.WriteLine(Translation.SR83);
                Console.WriteLine(Translation.SR84);
                Console.WriteLine(Translation.SR85);
                
                Console.WriteLine(Translation.SR86);
                Console.ReadLine();
                Events();
               
            }

            else if (ev.Equals("E", StringComparison.OrdinalIgnoreCase))
            {
                STARS();
                Console.WriteLine(Translation.SR87);
                Console.WriteLine(Translation.SR22);
                Console.WriteLine(Translation.SR23);
                Console.WriteLine(Translation.SR24);
            }

            else
            {
                Console.WriteLine(Translation.SR29);
                Events();
            }
            bb();
        }

        public static void Subscription()
        {
            Console.WriteLine(Translation.SR88);
            Console.WriteLine(Translation.SR89);
            var sub = Console.ReadLine();

            if (sub.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(Translation.SR90);
                Console.Write(Translation.SR91);
                var fname = Console.ReadLine();
                Console.Write(Translation.SR92);
                var sname = Console.ReadLine();
                Console.Write(Translation.SR93);
                var age = Console.ReadLine();
                Console.Write(Translation.SR94);
                var mail = Console.ReadLine();

                var every = fname + " " + sname + ", " + age + ", " + mail;
                List<string> sublist = new List<string>();
                sublist.Add(every);

                //Write to json file
                string file = JsonConvert.SerializeObject(sublist, Formatting.Indented);

                string js = Directory.GetCurrentDirectory() + "/../../../sub.json";
                File.AppendAllText(js, file);

                Console.WriteLine(Translation.SR95);
                var back = Console.ReadLine();

                if (back == "A")
                {
                    STARS();
                    Subscription();
                }
                else
                {
                    STARS();
                    Subscription();
                }
            }
                

            else if (sub.Equals("I", StringComparison.OrdinalIgnoreCase))
            {
                STARS();
                Console.WriteLine(Translation.SR96);
                Console.WriteLine(Translation.SR97);
                Console.WriteLine(Translation.SR95);
                var back = Console.ReadLine();

                if (back == "A")
                {
                    STARS();
                    Subscription();
                }
                else
                {
                    STARS();
                    Subscription();
                }
            }

            else if (sub == "" + "")
            {
                Menu();
            }
            else
            {
                Console.WriteLine(Translation.SR29);
                STARS();
                Subscription();
            }
        }
        public static void Sally()
        {
            Console.WriteLine(Translation.SR40);
            Console.WriteLine(Translation.SR41);
            Console.WriteLine(Translation.SR42);
            Console.WriteLine(Translation.SR43);
            Console.WriteLine(Translation.SR44);
            Console.WriteLine(Translation.SR45);


            switch (Console.ReadLine())
            {
                case "1":
                    FoodDrinkMenu();
                    break;
                case "2":
                    PaymentOptionsally();
                    break;
                case "3":
                    OrderMenu();
                    break;
                case "4":
                    Exit();
                    break;

            }

        }

        public static void FoodDrinkMenu()
        {
            Console.WriteLine(Translation.SR98);
            List<MenuItems> SubTotal = new List<MenuItems>();
            SubTotal.Add(new MenuItems() { Name = "Water", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Tea", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Coffee", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Slushie", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Milkshakes", Price = "4" });
            SubTotal.Add(new MenuItems() { Name = "Soda", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Beer", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Wine", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Popcorn", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Medium Popcorn", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Big Popcorn", Price = "7" });
            SubTotal.Add(new MenuItems() { Name = "Nachos & Dip", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Cotton Candy", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Cotton Candy", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Ben & Jerry's", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Ben & Jerry's", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 3", Price = "6" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 6", Price = "10" });
            SubTotal.Add(new MenuItems() { Name = "Cupcakes", Price = "2" });

            foreach (MenuItems x in SubTotal)
            {
                Console.WriteLine(x.getData());
            }

            Console.WriteLine(Translation.SR113);
            Console.ReadLine();
            OrderMenu();


        }

        public static void PaymentOptionsally()
        {
        Console.WriteLine(Translation.SR46);
        Console.WriteLine(Translation.SR47);
        Console.WriteLine(Translation.SR48);

        }
        public static void Paymentsally()
        {
            
            Console.WriteLine(Translation.SR114);
            string c = "0";
            string s = "";
            int counter = 1;
            int options = 2;
            int i;
            int j;
            int height = 9;
            int width = 9;
            while (counter < options)
            {
                for (i = 1; i <= height; i++)
                {
                    for (j = 1; j <= width; j++)
                    {
                        if (i == 1 || i == height || j == 1 || j == width)
                            s = s + " *";
                        else
                            s = s + "  ";
                    }
                    s = s + "\n";
                }
                if (counter == 1)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(Translation.SR5);
                }
                counter = counter + 1;
            }

            Console.WriteLine(s);
            Console.WriteLine(Translation.SR6);
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine(Translation.SR74);
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine(Translation.SR75);
                        }
                        else if (information.Length == 8)
                        {
                            c = "4";
                            d = 1;
                        }
                    }
                }
                if (c == "2")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine(Translation.SR76);
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine(Translation.SR75);
                        }
                        else if (information.Length == 8)
                        {
                            c = "4";
                            d = 1;
                        }

                    }
                }


            }
            // shows final ticket and show the time and payment done.
            Console.WriteLine(Translation.SR77);
            bb();
        }

        public static void OrderMenu()
        {

            List<string> MenuItems = new List<string>();
            MenuItems.Add("Water");
            MenuItems.Add("Tea");
            MenuItems.Add("Coffee");
            MenuItems.Add("Slushie");
            MenuItems.Add("Milkshakes");
            MenuItems.Add("Soda");
            MenuItems.Add("Beer");
            MenuItems.Add("Wine\n");
            MenuItems.Add("Small Popcorn");
            MenuItems.Add("Medium Popcorn");
            MenuItems.Add("Big Popcorn");
            MenuItems.Add("Nachos & Dip");
            MenuItems.Add("Cotton Candy");
            MenuItems.Add("Big Cotton Candy");
            MenuItems.Add("Small Ben & Jerry's");
            MenuItems.Add("Big Ben & Jerry's");
            MenuItems.Add("Dunkin Donuts set of 3");
            MenuItems.Add("Dunkin Donuts set of 6");
            MenuItems.Add("Cupcakes");


            Console.WriteLine(Translation.SR115);
            string message = Console.ReadLine();
            Console.WriteLine(Translation.SR49 + message);

            if (true == (MenuItems.Contains(message)))
            {
                Console.WriteLine(Translation.SR50 + message);
            }
            else
            {
                Console.WriteLine(Translation.SR51);
                OrderMenu();
            }

            List<MenuItems> SubTotal = new List<MenuItems>();
            SubTotal.Add(new MenuItems() { Name = "Water", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Tea", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Coffee", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Slushie", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Milkshakes", Price = "4" });
            SubTotal.Add(new MenuItems() { Name = "Soda", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Beer", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Wine", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Popcorn", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Medium Popcorn", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Big Popcorn", Price = "7" });
            SubTotal.Add(new MenuItems() { Name = "Nachos & Dip", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Cotton Candy", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Cotton Candy", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Ben & Jerry's", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Ben & Jerry's", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 3", Price = "6" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 6", Price = "10" });
            SubTotal.Add(new MenuItems() { Name = "Cupcakes", Price = "2" });

            var value = SubTotal.First(item => item.Name == message).Price;


            Console.WriteLine(Translation.SR116 + value + Translation.SR117);

            Paymentsally();

        }
        public class MenuItems
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string getData()
            {
                return this.Name + " : " + this.Price;
            }

        }
        public static void Exit()
            {
                Console.WriteLine(Translation.SR52);
                bb();
            }
        

        public static void Choices()
        {
            string choice = Console.ReadLine();
            switch (choice)
            //switch cases are pretty similar to if-else statements, only it looks better and works a bit faster
            // also you don't have to deal with 80 else ifs back to back 
            {
                case "1":
                    STARS();
                    Current();
                    break; // <<<<< needed because switch cases REFUSE to work if the breaks are left out
                case "2":
                    STARS();
                    Console.WriteLine(Translation.SR25);
                    Upcoming();
                    break;
                case "3":
                    STARS();
                    Prices();
                    break;
                case "4":
                    STARS();
                    Console.WriteLine(Translation.SR26);
                    Events();
                    break;
                case "5":
                    STARS();
                    Console.WriteLine(Translation.SR27);
                    Sally();
                    break;
                case "6":
                    STARS();
                    Contact();
                    break;
                case "7":
                    Subscription();
                    break;
                case "8":
                    Translation.dutch();
                    break;
                case "9":
                    Console.WriteLine(Translation.SR28);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(Translation.SR29);
                    Choices();
                    break;
            }
        }

        public static void Menu()
        {
            STARS();
            Console.WriteLine(Translation.SR30);
            Console.WriteLine(Translation.SR31);
            Console.WriteLine(Translation.SR32);
            Console.WriteLine(Translation.SR33);
            Console.WriteLine(Translation.SR34);
            Console.WriteLine(Translation.SR35);
            Console.WriteLine(Translation.SR36);
            Console.WriteLine(Translation.SR126);
            Console.WriteLine(Translation.SR132);
            STARS();
            Console.WriteLine(Translation.SR37);

            Choices();

        }

    }

    // menu screen for the admin
    public class Admin
    {
        public static void STARS()
        {
            Console.WriteLine("********************");
        }
        public static void bb()
        //works as a back button
        {
            Console.WriteLine(Translation.SR118);
            string key = Console.ReadLine();

            if (key == "" + "") //enter
                Menu();
            else
                bb();

        }

        public static void Contact()
        {
            Console.WriteLine("CINEMAPP CONTACT INFO\n");
            Console.WriteLine(Translation.SR17);
            Console.WriteLine(Translation.SR18);
            bb();
        }
        public static void Current()
        {
            Console.WriteLine(Translation.SR19);
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                Console.WriteLine(x + ": " + Data.LoadMovies()[x - 1].GetMovieName());
            }
            bb();
        }
        public static void Upcoming()
        {
            Console.WriteLine(Translation.SR38);
            List<string> Movies = new List<string>();
            Movies.Add("Bad Boys for Life (2020)");
            Movies.Add("The Godfather (1974)");
            Movies.Add("1917 (2020)");
            Movies.Add("Guardians of the Galaxy (2014)");
            Movies.Add("Joker (2019)");

            foreach (var movie in Movies)

                Console.WriteLine(movie);
            bb();
        }

        public static void Subprint()
        {
            string js = Directory.GetCurrentDirectory() + "/../../../sub.json";
            string s = File.ReadAllText(js);
            Console.WriteLine(Translation.SR119 + s);
            bb();
        }
        public static void Prices()
        {
            
            
            string x = "0";
            while (x != "6")
            {
                Console.WriteLine(Translation.SR39);
                x = Console.ReadLine();
                if (x == "1")
                // option to create the arrays of information in final program only useable by administrator
                {
                    Administrator testing = new Administrator();
                    string[] array = testing.Age_prices_array();
                    
                    Globals.array = array;
                }
                else if (x == "2")
                // option to write information into the json file
                {
                    Costumer testuser = new Costumer();

                    testuser.Newarray = Globals.array;

                    string stringjson = JsonConvert.SerializeObject(testuser, Formatting.Indented);

                    string js3 = Directory.GetCurrentDirectory() + "/../../../json1.json";
                    File.AppendAllText(js3, stringjson);
                    Console.WriteLine("Saved");
            }
                // needs t read from json file to print the information the user needs to see/ known problems does not print the times and date information
                // still is unable to read from the json file
                else if (x == "3")
                {
                    Console.WriteLine(Translation.SR58);

                    string str = File.ReadAllText(Directory.GetCurrentDirectory() + "/../../../json1.json");

                    string[] sepparator = { "{", "Newarray", "[", "}", "]", ":", ",", "\"", "array_movie_times_and_location", "null" };
                    string[] stringlist = str.Split(sepparator, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in stringlist)
                    {
                        Console.WriteLine(s);
                    }
                }
                else if (x == "4") {
                    bb();
                    x = "4";
                }
                else
                {
                    Console.WriteLine(Translation.SR29);
                    Prices();
                }
            }
        }
        public static void Sally()
        {
            Console.WriteLine(Translation.SR40);
            Console.WriteLine(Translation.SR41);
            Console.WriteLine(Translation.SR42);
            Console.WriteLine(Translation.SR43);
            Console.WriteLine(Translation.SR44);
            Console.WriteLine(Translation.SR45);


            switch (Console.ReadLine())
            {
                case "1":
                    FoodDrinkMenu();
                    break;
                case "2":
                    PaymentOption();
                    break;
                case "3":
                    OrderMenu();
                    break;
                case "4":
                    Admin.bb();
                    break;

            }

        }

        public static void FoodDrinkMenu()
        {
            Console.WriteLine(Translation.SR98);
            List<MenuItems> SubTotal = new List<MenuItems>();
            SubTotal.Add(new MenuItems() { Name = "Water", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Tea", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Coffee", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Slushie", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Milkshakes", Price = "4" });
            SubTotal.Add(new MenuItems() { Name = "Soda", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Beer", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Wine", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Popcorn", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Medium Popcorn", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Big Popcorn", Price = "7" });
            SubTotal.Add(new MenuItems() { Name = "Nachos & Dip", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Cotton Candy", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Cotton Candy", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Ben & Jerry's", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Ben & Jerry's", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 3", Price = "6" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 6", Price = "10" });
            SubTotal.Add(new MenuItems() { Name = "Cupcakes", Price = "2" });

            foreach (MenuItems x in SubTotal)
            {
                Console.WriteLine(x.getData());
            }
            //string file = JsonConvert.SerializeObject(SubTotal, Formatting.Indented);
            //string js = Directory.GetCurrentDirectory() + "/../../../products.json";
            


            Console.WriteLine(Translation.SR113);
            Console.ReadLine();
            OrderMenu();

        }

        public static void PaymentOption()
        {
            Console.WriteLine(Translation.SR46);
            Console.WriteLine(Translation.SR47);
            Console.WriteLine(Translation.SR48);


        }

    public static void Paymentsally()
    {
        
        Console.WriteLine(Translation.SR114);
        string c = "0";
        string s = "";
        int counter = 1;
        int options = 2;
        int i;
        int j;
        int height = 9;
        int width = 9;
        while (counter < options)
        {
            for (i = 1; i <= height; i++)
            {
                for (j = 1; j <= width; j++)
                {
                    if (i == 1 || i == height || j == 1 || j == width)
                        s = s + " *";
                    else
                        s = s + "  ";
                }
                s = s + "\n";
            }
            if (counter == 1)
            {
                Console.WriteLine(s);
                Console.WriteLine(Translation.SR5);
            }
            counter = counter + 1;
        }

        Console.WriteLine(s);
        Console.WriteLine(Translation.SR6);
        while (c != "4")
        {
            c = Console.ReadLine();
            if (c == "1")
            {
                int d = 0;
                while (d != 1)
                {
                    Console.WriteLine(Translation.SR74);
                    string information = Console.ReadLine();
                    if (information.Length != 8)
                    {
                        Console.WriteLine(Translation.SR75);
                    }
                    else if (information.Length == 8)
                    {
                        c = "4";
                        d = 1;
                    }
                }
            }
            if (c == "2")
            {
                int d = 0;
                while (d != 1)
                {
                    Console.WriteLine(Translation.SR76);
                    string information = Console.ReadLine();
                    if (information.Length != 8)
                    {
                        Console.WriteLine(Translation.SR75);
                    }
                    else if (information.Length == 8)
                    {
                        c = "4";
                        d = 1;
                    }

                }
            }


        }
        // shows final ticket and show the time and payment done.
        Console.WriteLine(Translation.SR77);
        bb();
        }
        public static void OrderMenu()
        {

            List<string> MenuItems = new List<string>();
            MenuItems.Add("Water");
            MenuItems.Add("Tea");
            MenuItems.Add("Coffee");
            MenuItems.Add("Slushie");
            MenuItems.Add("Milkshakes");
            MenuItems.Add("Soda");
            MenuItems.Add("Beer");
            MenuItems.Add("Wine\n");
            MenuItems.Add("Small Popcorn");
            MenuItems.Add("Medium Popcorn");
            MenuItems.Add("Big Popcorn");
            MenuItems.Add("Nachos & Dip");
            MenuItems.Add("Cotton Candy");
            MenuItems.Add("Big Cotton Candy");
            MenuItems.Add("Small Ben & Jerry's");
            MenuItems.Add("Big Ben & Jerry's");
            MenuItems.Add("Dunkin Donuts set of 3");
            MenuItems.Add("Dunkin Donuts set of 6");
            MenuItems.Add("Cupcakes");




            Console.WriteLine(Translation.SR115);
            string message = Console.ReadLine();
            Console.WriteLine(Translation.SR49 + message);
            Console.WriteLine(Globals.total);


            if (true == (MenuItems.Contains(message)))
            {
                Console.WriteLine(Translation.SR50 + message);
            }

            else
            {
                Console.WriteLine(Translation.SR51);
                OrderMenu();
            }

            List<MenuItems> SubTotal = new List<MenuItems>();
            SubTotal.Add(new MenuItems() { Name = "Water", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Tea", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Coffee", Price = "2" });
            SubTotal.Add(new MenuItems() { Name = "Slushie", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Milkshakes", Price = "4" });
            SubTotal.Add(new MenuItems() { Name = "Soda", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Beer", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Wine", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Popcorn", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Medium Popcorn", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Big Popcorn", Price = "7" });
            SubTotal.Add(new MenuItems() { Name = "Nachos & Dip", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Cotton Candy", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Cotton Candy", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Small Ben & Jerry's", Price = "3" });
            SubTotal.Add(new MenuItems() { Name = "Big Ben & Jerry's", Price = "5" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 3", Price = "6" });
            SubTotal.Add(new MenuItems() { Name = "Dunkin Donuts set of 6", Price = "10" });
            SubTotal.Add(new MenuItems() { Name = "Cupcakes", Price = "2" });

            var value = SubTotal.First(item => item.Name == message).Price;
            

            Console.WriteLine(Translation.SR116 + value + Translation.SR117);

            Paymentsally();
        }

        public class MenuItems
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string getData()
            {
                return this.Name + " : " + this.Price;
            }

        }

        public static void Exit()
        {
            Console.WriteLine(Translation.SR52);
            bb();
        }

        public static void addMovie()
        {
            Console.WriteLine(Translation.SR120 );
            string filmname = Console.ReadLine();
            
            
            //goes through the whole json file #code crashes here
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                
                // removes a movie if it found a name with the same input
                if (filmname == Data.LoadMovies()[x - 1].GetMovieName())
                {
                    Console.WriteLine(Translation.SR121);
                    bb();
                }

            }
            Console.WriteLine(Translation.SR122);
            string description = Console.ReadLine();
            Console.WriteLine(Translation.SR123);
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Translation.SR124);
            string genre = Console.ReadLine();
            Movie movie1 = new Movie(filmname, description, duration, genre); // new object
            List<Movie> list = Data.LoadMovies();
            list.Add(movie1);

            string test = JsonConvert.SerializeObject(list, Formatting.Indented);

            string js = Directory.GetCurrentDirectory() + "/../../../movies.json";
            File.WriteAllText(js, test);
            bb();
        }
        public static void removeMovie()
        {
            //can be found at MovieData.cs 
            List<Movie> list = Data.LoadMovies();
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                Console.WriteLine(x + " " + Data.LoadMovies()[x - 1].GetMovieName());

            }
            Console.WriteLine(Translation.SR125);
            string r = Console.ReadLine();
            bool found = false;
            //goes through the whole json file
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                // removes a movie if it found a name with the same input
                if (r == Data.LoadMovies()[x - 1].GetMovieName())
                {
                    list.RemoveAt(x - 1);
                    found = true;
                }

            }
            if (found == false)
            {
                Console.WriteLine(Translation.SR54);
            }
            // sends the data back to the json file

            string test = JsonConvert.SerializeObject(list, Formatting.Indented);

            string js = Directory.GetCurrentDirectory() + "/../../../movies.json";
            File.WriteAllText(js, test);
            bb();
        }

        public static void Choices()
        {
            string choice = Console.ReadLine();
            switch (choice)
            //switch cases are pretty similar to if-else statements, only it looks better and works a bit faster
            // also you don't have to deal with 80 else ifs back to back 
            {
                case "1":
                    STARS();
                    Current();
                    break; // <<<<< needed because switch cases REFUSE to work if the breaks are left out
                case "2":
                    STARS();
                    Console.WriteLine(Translation.SR25);
                    Upcoming();
                    break;
                case "3":
                    STARS();
                    Prices();
                    break;
                case "4":
                    STARS();
                    Console.WriteLine(Translation.SR27);
                    Sally();
                    break;
                case "5":
                    STARS();
                    User.Contact();
                    break;
                case "6":
                    STARS();
                    addMovie();
                    break;
                case "7":
                    STARS();
                    removeMovie();
                    break;
                case "8":
                    Subprint();
                    break;
                case "9":
                    Translation.dutch();
                    break;
                case "10":
                    Console.WriteLine(Translation.SR28);
                    Environment.Exit(0);
                    break;
                default: // <<<<<works as the final 'else'
                    Console.WriteLine(Translation.SR29);
                    Choices();
                    break;
            }
        }

        public static void Menu()
        {
            STARS();
            Console.WriteLine(Translation.SR30);
            Console.WriteLine(Translation.SR31);
            Console.WriteLine(Translation.SR32);
            Console.WriteLine(Translation.SR127);
            Console.WriteLine(Translation.SR128);
            Console.WriteLine(Translation.SR129);
            Console.WriteLine(Translation.SR130);
            Console.WriteLine(Translation.SR131);
            Console.WriteLine(Translation.SR135);
            Console.WriteLine(Translation.SR136);
            STARS();
            Console.WriteLine(Translation.SR37);

            Choices();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            /*Console.ForegroundColor = ConsoleColor.White;
           
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = color;
                Console.WriteLine($"Background color set to {color}");
            }*/
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Login.Question();
        }
    }
}


             
    
