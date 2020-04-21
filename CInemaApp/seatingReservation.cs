using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace CInemaApp
{
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
=======
using System.Linq;

namespace CinemaApp
{   
    class program
    { 
        static void Main(string[] args)
        {
            int e = 0;
            int width = 0;
            int height = 0;
            int movieHall = 1;
            int userRow = 0;
            int userColumn = 0;
            int userSeat = 0;


            if (movieHall == 1)
            {
                width = 15;
                height = 10;               
            }
            else if (movieHall == 2)
            {
                width = 20;
                height = 15;
            }       
            else if (movieHall == 3)
            {
                width = 25;
                height = 20;
            }
            int[] userSeats = new int[width * height];
            void showSeats()
            {
                for (int i = -1; i < height; i++)
                {
                    Console.Write(i+1);
                    if (i < 9) Console.Write(" ");
                        
                    for (int o = 0; o < width; o++)
                    {
                        if (i == -1)
                        {
                            Console.Write("  " + (o + 1));
                            if (o< 9) Console.Write(" ");
                            Console.Write(" ");
                        }
                        else
                        {
                            if (userSeats.Contains(i * width + o + 1))
                            {
                                Console.Write("[ X ]");
                            }
                            else
                            {
                                Console.Write("[ O ]");
                            }
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
            void seatSelection()
            {   
                Console.WriteLine("Enter the row of the seat you want to reserve (1 - " + height + ")");
                bool parseSucc = int.TryParse(Console.ReadLine(), out userRow);
                Console.WriteLine("Enter the column of the seat you want to reserve (1 - " + width + ")");
                parseSucc = int.TryParse(Console.ReadLine(), out userColumn);
                userSeat = (userRow - 1) * width + userColumn;
                if (!userSeats.Contains(userSeat) && userRow <= height && userColumn <= width) {
                    userSeats[e] = userSeat;
                    showSeats();
                }
                else { Console.WriteLine("Unavailible seat, try again."); }
                
            }
            showSeats();
            seatSelection();
            e += 1;

            Console.WriteLine("Type OK to confirm reservation, type anything else to select another seat.");
            while(Console.ReadLine() != "OK")
            {       
                seatSelection();
                e += 1;
                Console.WriteLine("Type OK to confirm reservation, type anything else to select a different seat.");

    
            }
            
>>>>>>> Bas
        }
    }

}