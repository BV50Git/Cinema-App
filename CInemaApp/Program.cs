using System;
using System.Windows.Input;

namespace CInemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static void STARS()
            {
                Console.WriteLine("********************");
            }

            static void Contact()
            {
                Console.WriteLine("CINEMAPP CONTACT INFO\n");
                Console.WriteLine("Phone number: 06123456789");
                Console.WriteLine("Email: cinemapp@hr.nl\n");
                bb();
            }
            static void Current()
            {

            }
            static void Upcoming()
            {

            }
            static void Prices()
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
            static void Events()
            {

            }
            static void Sally()
            {

            }
            static void bb()
            {
                Console.WriteLine("To go back to the main menu press Enter.");
                string key = Console.ReadLine();

                if (key == "" + "")
                    Menu();

            }

            static void Choices()
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        STARS();
                        Console.WriteLine("Welcome to the current movies page!");
                        break;
                    case "2":
                        STARS();
                        Console.WriteLine("Welcome to the upcoming movies page!");
                        break;
                    case "3":
                        STARS();
                        Prices();
                        break;
                    case "4":
                        STARS();
                        Console.WriteLine("Welcome to the events page!");
                        break;
                    case "5":
                        STARS();
                        Console.WriteLine("Welcome to sally's cafe page!");
                        break;
                    case "6":
                        STARS();
                        Contact();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("False input. Try again.");
                        Choices();
                        break;
                }
            }
            
            static void Menu()
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
           
            Menu();  
        }
    }
}
