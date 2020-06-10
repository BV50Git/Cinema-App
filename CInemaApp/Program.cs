using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using CinemaApp;
using CInemaApp;

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
            string[] agebrackets_in_cinema = { "Below age 12", "Age 12 to 26", "Age 27 to 50", "50+" };
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
                Console.WriteLine("The prices are as follows: ");
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
            Console.Write("Please enter the password: ");
            string pass = Console.ReadLine();

            if (pass == "Admin")
                Admin.Menu();
            else
                Console.WriteLine("Wrong input. Please try again");
                Password();
        }
        public static void Question()
        {
            User.STARS();
            Console.WriteLine("Are you an Admin or User? [A/U]");
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
            Console.WriteLine("To go back to the main menu, please press Enter.");
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


                Console.WriteLine("Please choose your age group");
                Console.WriteLine("Press 1 if you are below 12 years old\nPress 2 if you are between 12 and 26 years old\nPress 3 if you are between 27 and 50 years old\nPress 4 if you are 50 years or older");

                string agegroup = Console.ReadLine();
                int j = 0;
                while (j < 1)
                {
                    if (x > 1)
                    {


                        if (agegroup == "1")
                        {

                            counter = counter + 1;
                            string response = "This is group member " + counter + " ";
                            output = output + " " + response + "and is below 12 years old. ";

                            j++;
                        }
                        if (agegroup == "2")
                        {

                            counter = counter + 1;
                            string response = "This is group member " + counter + " ";
                            output = output + " " + response + "and is between 12 and 26 years old. ";
                            j++;
                        }
                        if (agegroup == "3")
                        {

                            counter = counter + 1;
                            string response = "This is group member " + counter + " ";
                            output = output + " " + response + "and is between 27 and 50 years old. ";
                            j++;
                        }
                        if (agegroup == "4")
                        {

                            counter = counter + 1;
                            string response = "This is group member " + counter + " ";
                            output = output + " " + response + "and is 50 years or older. ";
                            j++;
                        }
                    }
                    i++;
                    if (x == 1)
                    {
                        if (agegroup == "1")
                        {

                            counter = counter + 1;
                            string response = "You are ";
                            output = output + " " + response + "and you are below 12 years old. ";
                            j++;
                        }
                        if (agegroup == "2")
                        {

                            counter = counter + 1;
                            string response = "You are ";
                            output = output + " " + response + "and you are between 12 and 26 years old. ";
                            j++;
                        }
                        if (agegroup == "3")
                        {

                            counter = counter + 1;
                            string response = "You are ";
                            output = output + " " + response + "and you are between 27 and 50 years old. ";
                            j++;
                        }
                        if (agegroup == "4")
                        {

                            counter = counter + 1;
                            string response = "You are ";
                            output = output + " " + response + "and you are 50 years or older. ";
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
            Console.WriteLine("We want to ask you to pay for the reservation of the movie: " + Globals.Moviename);
            Console.WriteLine("We are calculating your Bill");
            Console.WriteLine("Please choose a payment option");
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
                    Console.WriteLine("   IDEAL (option 1)");
                }
                counter = counter + 1;
            }

            Console.WriteLine(s);
            Console.WriteLine(" Credit Card (option 2)");
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine("Please enter your IDEAL information, 8 digit code\n *********************");
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine("Please try again, you seemed to have typed the wrong code");
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
                        Console.WriteLine("Please enter your IDEAL information, 8 digit code\n *********************");
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine("Please try again you seemed to have typed the wrong code");
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
            Console.WriteLine("Everything has been payed for");
        }

        public static void Contact()
        {
            Console.WriteLine("CINEMAPP CONTACT INFO\n");
            Console.WriteLine("Phone number: 06123456789");
            Console.WriteLine("Email: cinemapp@hr.nl\n");
            bb();
        }
        public static void Current()
        {
            Console.WriteLine("Welcome to the current movies page!");
            List<Movie> list = Data.LoadMovies();
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                Console.WriteLine(x + " " + Data.LoadMovies()[x - 1].GetMovieName());

            }
            Console.WriteLine("Enter the name of the movie you want to make a reservation for: ");
            string Moviename = Console.ReadLine();
            bool found = false;
            //goes through the whole json file
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                
                if (Moviename == Data.LoadMovies()[x - 1].GetMovieName())
                {
                    
                    string seats = SeatingReservation.Seat();
                    
                    Console.WriteLine("Reservation for " + Moviename + "made. Your seats are: " + seats);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Movie not found");
            }
                bb();
            
        }
        public static void Upcoming()
        {
            
            Console.WriteLine("These are the upcoming movies: ");
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
                Console.WriteLine("Please press 1 to go to the information page\nPress 2 to exit");
                x = Console.ReadLine();
                if (x == "1")
                {
                    Console.WriteLine("The prices are as follows:");
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
                    Console.WriteLine("False input. Try again");
                    Prices();
                }
            }
        }
        public static void Events()
        {
            STARS();
            Console.WriteLine("Welcome to the Events page!");
            Console.WriteLine("For our COVID-19 Regulations please press 'C'\nFor our regularly scheduled events press 'E'");
            var ev = Console.ReadLine();

            if (ev.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                STARS();
                Console.WriteLine("Due to the current circumstances and the social distancing order, Cinemapps has unfortunately had to" +
                    " close their doors for a short while.");
                Console.WriteLine("However, since reopening we have been trying our hardest to get back to how things used to be," +
                    " with some added changes to uphold the new rules.\n\nAs such, we've had to remove some of our previous events" +
                    " and swap them out in favor of new ones that don't put a lot of people at risk. ");
                Console.WriteLine("We are sorry for the inconvenience and hope for your understanding.");
                
                Console.WriteLine("Press any key to go back to the Events page");
                Console.ReadLine();
                Events();
               
            }

            else if (ev.Equals("E", StringComparison.OrdinalIgnoreCase))
            {
                STARS();
                Console.WriteLine("Current ongoing events:");
                Console.WriteLine("Friday - 'Horror Movie Night!'\n     All horror movies will be available to watch for 50% off " +
                    "during this event!");
                Console.WriteLine("Saturday - 'Family Day!'\n     Each family that arrives at our cinema gets a " +
                    "free ticket to spend on food and beverages as they like!");
                Console.WriteLine("Sunday - 'Premiere Night!'\n     On this day, one or more movies from the " +
                    "'Upcoming Movies' list will be shown for the first time in our cinema! Don't miss it!");
            }

            else
            {
                Console.WriteLine("False input. Try again");
                Events();
            }
            bb();
        }

        public static void Subscription()
        {
            Console.WriteLine("Welcome to the subscriptions page!");
            Console.WriteLine("Press 'S' to subscribe,\n'I' for more information,\n'Enter' to go back to the main menu");
            var sub = Console.ReadLine();

            if (sub.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank you for choosing to subscribe to the Cinemapps newsletter! Please enter the following information:");
                Console.Write("First name: ");
                var fname = Console.ReadLine();
                Console.Write("Surname: ");
                var sname = Console.ReadLine();
                Console.Write("Age: ");
                var age = Console.ReadLine();
                Console.Write("Email: ");
                var mail = Console.ReadLine();

                var every = fname + " " + sname + ", " + age + ", " + mail;
                List<string> sublist = new List<string>();
                sublist.Add(every);

                //Write to json file
                string file = JsonConvert.SerializeObject(sublist, Formatting.Indented);

                string js = Directory.GetCurrentDirectory() + "/../../../sub.json";
                File.AppendAllText(js, file);

                Console.WriteLine("Press any key to go back to the subscription page");
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
                Console.WriteLine("If you subscribe to Cinemapps, you will receive a monthly news letter by email!");
                Console.WriteLine("It will include information about upcoming movies, events, and eventual discounts, as well as any other news surrounding our beloved cinema!");
                Console.WriteLine("Press any key to go back to the subscription page");
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
                Console.WriteLine("False input. Try again");
                STARS();
                Subscription();
            }
        }
        public static void Sally()
        {
            Console.WriteLine("What can I help you with today?");
            Console.WriteLine("1) Display Food & Drink menu");
            Console.WriteLine("2) Display payment options");
            Console.WriteLine("3) Order from Food & Drink menu");
            Console.WriteLine("4) Exit\n");
            Console.WriteLine("Please select your option");


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
            Console.WriteLine("Welcome to Sally's! Prices are in $$$");
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

            Console.WriteLine("Press any key to order");
            Console.ReadLine();
            OrderMenu();


        }

        public static void PaymentOptionsally()
        {
        Console.WriteLine("These are the payment options");
        Console.WriteLine("1) IDEAL");
        Console.WriteLine("2) Credit card");
        bb();
        }
        public static void Paymentsally()
        {
            
            Console.WriteLine("Please choose your payment option");
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
                    Console.WriteLine("   IDEAL (option 1)");
                }
                counter = counter + 1;
            }

            Console.WriteLine(s);
            Console.WriteLine(" Credit card (option 2)");
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    int d = 0;
                    while (d != 1)
                    {
                        Console.WriteLine("Please enter your IDEAL information, 8 digit code\n *********************");
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine("Please try again, you seemed to have typed the wrong code");
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
                        Console.WriteLine("Please enter your IDEAL information, 8 digit code\n *********************");
                        string information = Console.ReadLine();
                        if (information.Length != 8)
                        {
                            Console.WriteLine("Please try again, you seemed to have typed the wrong code");
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
            Console.WriteLine("Everything has been payed for");
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


            Console.WriteLine("What would you like to order? Remember to use Capital Letters!!!");
            string message = Console.ReadLine();
            Console.WriteLine("Your choice is: " + message);


            if (true == (MenuItems.Contains(message)))
            {
                Console.WriteLine("You have succesfully ordered " + message);
            }
            else
            {
                Console.WriteLine("We don't seem to have that in our store, please try again.");
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


            Console.WriteLine("You will have to pay $" + value + "!");

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
                Console.WriteLine("Thank you for visiting Sally's cafe!");
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
                    Console.WriteLine("Welcome to the upcoming movies page!");
                    Upcoming();
                    break;
                case "3":
                    STARS();
                    Prices();
                    break;
                case "4":
                    STARS();
                    Console.WriteLine("Welcome to the events page!");
                    Events();
                    break;
                case "5":
                    STARS();
                    Console.WriteLine("Welcome to Sally's Cafe!");
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
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("False input. Try again.");
                    Choices();
                    break;
            }
        }

        public static void Menu()
        {
            STARS();
            Console.WriteLine("[1] - Current Movies");
            Console.WriteLine("[2] - Upcoming Movies");
            Console.WriteLine("[3] - Movie Prices");
            Console.WriteLine("[4] - Events");
            Console.WriteLine("[5] - Sally's Café");
            Console.WriteLine("[6] - Contact Information");
            Console.WriteLine("[7] - Subscriptions");
            Console.WriteLine("[8] - Quit");
            STARS();
            Console.WriteLine("Please choose any option to continue");

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
            Console.WriteLine("To go back to the main menu, please press Enter");
            string key = Console.ReadLine();

            if (key == "" + "") //enter
                Menu();
            else
                bb();

        }

        public static void Contact()
        {
            Console.WriteLine("CINEMAPP CONTACT INFO\n");
            Console.WriteLine("Phone number: 06123456789");
            Console.WriteLine("Email: cinemapp@hr.nl\n");
            bb();
        }
        public static void Current()
        {
            Console.WriteLine("Welcome to the current movies page!");
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                Console.WriteLine(x + ": " + Data.LoadMovies()[x - 1].GetMovieName());
            }
            bb();
        }
        public static void Upcoming()
        {
            Console.WriteLine("These are the upcoming movies: ");
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
            Console.WriteLine("These are the current subscribers:\n" + s);
            bb();
        }
        public static void Prices()
        {
            
            
            string x = "0";
            while (x != "6")
            {
                Console.WriteLine("Press 1 to fill in information\nPress 2 to write the new information to the json file\nPress 3 to get information from the json file\nPress 4 to exit");
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
                    Console.WriteLine("The prices are as follows:");

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
                    Console.WriteLine("False input. Try again");
                    Prices();
                }
            }
        }
        public static void Sally()
        {
            Console.WriteLine("What can I help you with today?");
            Console.WriteLine("1) Display Food & Drink menu");
            Console.WriteLine("2) Exit");
            Console.WriteLine("Please select your option. You can only choose 1, 2");


            switch (Console.ReadLine())
            {
                case "1":
                    FoodDrinkMenu();
                    break;
                case "2":
                    Admin.bb();
                    break;
               

            }

        }

        public static void FoodDrinkMenu()
        {
            Console.WriteLine("Welcome to Sally's! Prices are in $$$");
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

            Exit();
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
            Console.WriteLine("Thank you for visiting Sally's cafe!");
            bb();
        }

        public static void addMovie()
        {
            Console.WriteLine("Name of the movie: ");
            string filmname = Console.ReadLine();
            
            
            //goes through the whole json file #code crashes here
            for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
            {
                
                // removes a movie if it found a name with the same input
                if (filmname == Data.LoadMovies()[x - 1].GetMovieName())
                {
                    Console.WriteLine("A movie with that name already exists");
                    bb();
                }

            }
            Console.WriteLine("Movie description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Movie length: ");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Movie genre: ");
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
            Console.WriteLine("Enter the name of the movie you want to remove: ");
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
                Console.WriteLine("Movie not found");
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
                    Console.WriteLine("Welcome to the upcoming movies page!");
                    Upcoming();
                    break;
                case "3":
                    STARS();
                    Prices();
                    break;
                case "4":
                    STARS();
                    Console.WriteLine("Welcome to Sally's Cafe!");
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
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                    break;
                default: // <<<<<works as the final 'else'
                    Console.WriteLine("False input. Try again.");
                    Choices();
                    break;
            }
        }

        public static void Menu()
        {
            STARS();
            Console.WriteLine("[1] - Current Movies");
            Console.WriteLine("[2] - Upcoming Movies");
            Console.WriteLine("[3] - Movie Prices");
            Console.WriteLine("[4] - Sally's Café");
            Console.WriteLine("[5] - Contact Information");
            Console.WriteLine("[6] - Add Movie");
            Console.WriteLine("[7] - Remove movie");
            Console.WriteLine("[8] - Subscriptions");
            Console.WriteLine("[9] - Quit");
            STARS();
            Console.WriteLine("Please choose an option to continue.");

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


             
    
