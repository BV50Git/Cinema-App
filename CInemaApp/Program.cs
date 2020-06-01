using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace CInemaApp
{

    public class Globals
    {
        public static string[] array;
        public static System.Collections.Generic.List<string> Newarray_movie_times_and_location;
        public static string answer;
    }

    public class Paymentsystem
    {
        public void Paymentoption()
        {
            Console.WriteLine("Please choose your payment option! (press a number to choose)");
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
                    Console.WriteLine("   IDEAL option 1");
                }
                else if (counter == 2)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(" Credit Card option 2");
                }
                counter = counter + 1;
            }

            Console.WriteLine(s);
            Console.WriteLine(" Credit Card option 2");
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    Console.WriteLine("Please enter your IDEAL information");
                    User.STARS();
                    string information = Console.ReadLine();
                    string x = "5";
                    c = "4";
                }
                if (c == "2")
                {
                    Console.WriteLine("Please enter your Credit Card information");
                    User.STARS();
                    string information = Console.ReadLine();

                    c = "4";
                }


            }
            // shows final ticket and show the time and payment done.
            string infopayed = " Payment completed";



        }
        // administrator class so the administrator can use specific functions and add data needed in the application

        // the 'login screen' that asks whether the current user is an admin or not
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
        public System.Collections.Generic.List<string> Times_and_dates()
        {
            string location = "Location: Rotterdam, Wijnhaven 107.";
            var array_movie_times_and_location = new System.Collections.Generic.List<string>() { };

            Console.WriteLine("At what time does the movie play?");
            string time = Console.ReadLine();
            Console.WriteLine("At which date does the movie play?");
            string date = Console.ReadLine();
            string newdata = "Movie starts at " + time + " on " + date + " at " + location;
            array_movie_times_and_location.Add(newdata);
            Console.WriteLine(array_movie_times_and_location[0]);


            return array_movie_times_and_location;
        }


    }
        // the class for the costumer this way the costumer can use different functions within the application
        public class Costumer
        {
            public System.Collections.Generic.List<string> array_movie_times_and_location;
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
            public System.Collections.Generic.List<string> Show_times_and_dates()
            {
                Console.WriteLine(array_movie_times_and_location);
                var Newarray = array_movie_times_and_location;
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
            Globals.answer = Answer;

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
            bb();
        }
        public static void Prices()
        {
            string x = "0";
            while (x != "2")
            {
                Console.WriteLine("Please press 1 to go to the information page\nPress 2 to exit ");
                x = Console.ReadLine();
                if (x == "1")
                {
                    Console.WriteLine("here");
                    Console.WriteLine(System.IO.File.ReadAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\json1.json"));


                    // future reading code to make sure it reads without the brackets
                    //for (int d = 1; d < Dataprices.LoadPrices().Count + 1; d++)
                    //{
                    //    Console.WriteLine(x + ": " + Dataprices.LoadPrices()[d - 1].Getmovietime());
                    //}
                }
                if (x == "2")
                {

                    bb();
                    x = "2";
                }
                else
                {
                    Console.WriteLine("input invalid please try again");
                    Prices();
                }
            }
        }
        public static void Events()
        {
            Console.WriteLine("Friday horror night all horror movies are 50% off");
            Console.WriteLine("Saturday Familiy day every familiy that comes gain tickets for free food");
            Console.WriteLine("Sunday premire night every sunday night one or more of the upcoming movies will play for the first time");
            bb();
        }
        public static void Sally()
        {
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
                    Console.WriteLine("Welcome to sally's cafe page!");
                    Sally();
                    break;
                case "6":
                    STARS();
                    Contact();
                    break;
                case "7":
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
            Console.WriteLine("[7] - Quit");
            STARS();
            Console.WriteLine("Please choose an option to continue.");

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
            Console.WriteLine("To go back to the main menu, please press Enter.");
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
            bb();
        }
        public static void Upcoming()
        {
            bb();
        }
        public static void Prices()
        {
            
            
            string x = "0";
            while (x != "6")
            {
                Console.WriteLine("Please type your choice 1 to fill in information. 2 to write the new information to the json fil\n 3 to get information from the json file. 4 to go to exit");
                x = Console.ReadLine();
                if (x == "1")
                // option to create the arrays of information in final program only useable by administrato
                {
                    Administrator testing = new Administrator();
                    string[] array = testing.Age_prices_array();
                    System.Collections.Generic.List<string> Newarray_movie_times_and_location = testing.Times_and_dates();
                    Globals.Newarray_movie_times_and_location = Newarray_movie_times_and_location;
                    Globals.array = array;
                }
                if (x == "2")
                // option to write information into the json file
                {
                    Costumer testuser = new Costumer();

                    testuser.Newarray = Globals.array;

                    testuser.array_movie_times_and_location = Globals.Newarray_movie_times_and_location;
                    var stringjson = JsonConvert.SerializeObject(testuser, Formatting.Indented);


                    System.IO.File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\json1.json", stringjson);
                }
                // needs t read from json file to print the information the user needs to see/ known problems does not print the times and date information
                // still is unable to read from the json file
                if (x == "3")
                {
                    Console.WriteLine("here");
                    Console.WriteLine(System.IO.File.ReadAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\json1.json"));
                }
                if (x == "4") {
                    bb();
                    x = "4";
                }
                else
                {
                    Console.WriteLine("input invalid please try again");
                    Prices();
                }
            }
        }
        public static void Events()
        {
            Console.WriteLine("Friday horror night all horror movies are 50% off");
            Console.WriteLine("Saturday Family day every family that comes gain tickets for free food");
            Console.WriteLine("Sunday premiere night every Sunday night one or more of the upcoming movies will play for the first time");
            bb();
        }
        public static void Sally()
        {
            bb();
        }
        public static void addMovie()
        {
            Console.WriteLine("Name of the movie: ");
            string filmname = Console.ReadLine();
            
            
            //goes through the whole json file
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
            var test = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json", test);
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
            var test = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json", test);
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
                    Console.WriteLine("Welcome to sally's cafe page!");
                    Sally();
                    break;
                case "6":
                    STARS();
                    Contact();
                    break;
                case "7":
                    addMovie();
                    break;
                case "8":
                    removeMovie();
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
            Console.WriteLine("[4] - Events");
            Console.WriteLine("[5] - Sally's Café");
            Console.WriteLine("[6] - Contact Information");
            Console.WriteLine("[7] - Add Movie");
            Console.WriteLine("[8] - Remove movie");
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
            Console.BackgroundColor = ConsoleColor.Cyan;
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = color;
                Console.WriteLine($"Background color set to {color}");
            }*/

                Login.Question();
        }
    }
}


             
    
