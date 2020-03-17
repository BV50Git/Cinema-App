using System;

namespace CInemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // function to let the administrator change values, i do not yet know how to make a function in c#
            string[] agebrackets_in_cinema = { "below age 10", "age 10 to 15", "age 16 to 26", "age 27 to 50", "50+"};
            string[] array = { "1", "2", "3", "4", "5" };
            int agebrackets = 5;
            for (int i = 0; i < agebrackets; i++){

                string agebracket_and_price = Console.ReadLine();
                array[i] = agebrackets_in_cinema[i] + " " + agebracket_and_price;
            }
            // function to show the lists of prices, I do not yet know how to do that in c#
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // function to change time/date/location movies will be played at.
            // this function needs allot more work, mostly on the design.
            string location = "locatie: Rotterdam, Wijnhaven 107.";
            var array_movie_times_and_location = new System.Collections.Generic.List<string>() {};
            Console.WriteLine("type 1 to add specifics for a movie, anything else to leave");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("At what time does the movie play!");
                string time = Console.ReadLine();
                Console.WriteLine("At which date does the movie play!");
                string date = Console.ReadLine();
                string newdata = "movie starts at " + time + " on " + date + " " + location;
                array_movie_times_and_location.Add(newdata);
                Console.WriteLine(array_movie_times_and_location[0]);
            }
            else if (a != "1"){
                Console.WriteLine(array_movie_times_and_location);
            } 
        }
    }
}
