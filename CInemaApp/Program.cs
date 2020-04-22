using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace CInemaApp
{
    // the 'login screen' that asks whether the current user is an admin or not
    public class Login
    {
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
                Admin.Menu();
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
            bb();
        }
        public static void Upcoming()
        {
            bb();
        }
        public static void Prices()
        {
            Console.WriteLine("MOVIE TICKET PRICES BY AGE\n");

            Console.WriteLine("REGULAR 2D MOVIES");
            Console.WriteLine("Children up to 11 - $6.00");
            Console.WriteLine("Regular - $11.00");
            Console.WriteLine("Teenagers (aged 12 - 17) and elderly (65+) - $9.00\n");

            Console.WriteLine("3D MOVIES");
            Console.WriteLine("Children up to 11 - $9.00");
            Console.WriteLine("Regular - $14.00");
            Console.WriteLine("Teenagers (aged 12 - 17) and elderly (65+) - $12.00\n");

            Console.WriteLine("IMAX/4DX MOVIES");
            Console.WriteLine("Children up to 11 - $11.50");
            Console.WriteLine("Regular - $16.50\n");

            bb();
        }
        public static void Events()
        {
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
                    Console.WriteLine("Welcome to the current movies page!");
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
        public static void Menu()
        {
            User.STARS();
            Console.WriteLine("[1] - Current Movies");
            Console.WriteLine("[2] - Upcoming Movies");
            Console.WriteLine("[3] - Movie Prices");
            Console.WriteLine("[4] - Events");
            Console.WriteLine("[5] - Sally's Café");
            Console.WriteLine("[6] - Contact Information");
            Console.WriteLine("[7] - Quit");
            User.STARS();
            Console.WriteLine("Please choose an option to continue.");

            Choices();
        }
        public static void Current()
        {
            string tc = Console.ReadLine();
        }
        public static void Upcoming()
        {
            string tu = Console.ReadLine();
        }
        public static void Prices()
        {
            string tp = Console.ReadLine();
        }
        public static void Events()
        {
            string te = Console.ReadLine();
        }
        public static void Sally()
        {
            string ts = Console.ReadLine();
        }
        public static void Contact()
        {
            string tco = Console.ReadLine();
        }
        public static void Choices()
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Current();
                    break;
                case "2":
                    Upcoming();
                    break;
                case "3":
                    Prices();
                    break;
                case "4":
                    Events();
                    break;
                case "5":
                    Sally();
                    break;
                case "6":
                    Contact();
                    break;
                default:
                    Choices();
                    break;
            }
        }
    }
    class Program
    {
        private static int Main(string[] args)
        {
            bool c = true;

            while (c)
            {

                // shows every movie name in the list
                for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
                {
                    Console.WriteLine(x + ": " + Data.LoadMovies()[x - 1].GetMovieName());
                }
                    // a little menu 
                Console.WriteLine("enter 1 for adding movies");
                Console.WriteLine("enter 2 for removing movies");
                Console.WriteLine("enter quit to stop");
                Console.Write("Enter a command: ");
                string val = Console.ReadLine();
                if (val == "quit")
                {
                    c = false;
                }
                // add a movie
                else if (val == "1")
                {
                    Console.WriteLine("Name of the movie: ");
                    string filmname = Console.ReadLine();
                    Console.WriteLine("Description of the movie: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Duration of the movie: ");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Genre of the movie: ");
                    string genre = Console.ReadLine();
                    Movie movie1 = new Movie(filmname, description, duration, genre); // new object
                    List<Movie> list = Data.LoadMovies();
                    list.Add(movie1);
                    var test = JsonConvert.SerializeObject(list, Formatting.Indented);
                    File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json", test);
                }
                // remove a movie based on a position
                else if (val == "2")
                {
                    //can be found at MovieData.cs 
                    List<Movie> list = Data.LoadMovies();
                    for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
                    {
                        Console.WriteLine(x + Data.LoadMovies()[x - 1].GetMovieName());
                   
                    }
                    Console.WriteLine("type the name of the movie that you want to remove: ");
                    string r = Console.ReadLine();
                    bool found = false;
                    //goes through the whole json file
                    for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
                    {
                        // removes a movie if it found a name with the same input
                       if ( r == Data.LoadMovies()[x - 1].GetMovieName())
                        {
                            list.RemoveAt(x - 1);
                            found = true;
                        }
                       
                    }
                    if (found == false)
                    {
                        Console.WriteLine("the movie is not found");
                    }
                    // sends the data back to the json file
                    var test = JsonConvert.SerializeObject(list, Formatting.Indented);
                    File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json", test);
                }
                else
                {
                    Console.WriteLine("there is no movie on that posisiton");
                }
            }
            return 0;
        }
    }
}
