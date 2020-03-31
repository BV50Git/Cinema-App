using System;
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
                    Console.WriteLine(x + Data.LoadMovies()[x - 1].GetMovieName());
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
                    string filmname = Console.ReadLine();
                    Movie movie1 = new Movie(filmname, "hooi", 10); // new object
                    List<Movie> list = Data.LoadMovies();
                    list.Add(movie1);
                    var test = JsonConvert.SerializeObject(list, Formatting.Indented);
                    File.WriteAllText(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json", test);
                }
                // remove a movie based on a position
                else if (val == "2")
                {
                    Console.WriteLine("i cant remove yet");
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
