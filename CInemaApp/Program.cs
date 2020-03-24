using System;

namespace CInemaApp
{
    // administrator class so the administrator can use specific functions and add data needed in the application
    public class Administrator
    {

        public string[] Age_prices_array()
        {
            string[] agebrackets_in_cinema = { "below age 10", "age 10 to 15", "age 16 to 26", "age 27 to 50", "50+" };
            string[] array = { "1", "2", "3", "4", "5" };
            int agebrackets = 5;
            for (int i = 0; i < agebrackets; i++)
            {
                Console.WriteLine("The price for " + agebrackets_in_cinema[i] + " are?");
                string agebracket_and_price = Console.ReadLine();
                array[i] = agebrackets_in_cinema[i] + " " + agebracket_and_price;
            }
            return array;
        }
        public System.Collections.Generic.List<string> Times_and_dates()
        {
            string location = "location: Rotterdam, Wijnhaven 107.";
            var array_movie_times_and_location = new System.Collections.Generic.List<string>() { };

            Console.WriteLine("At what time does the movie play!");
            string time = Console.ReadLine();
            Console.WriteLine("At which date does the movie play!");
            string date = Console.ReadLine();
            string newdata = "movie starts at " + time + " on " + date + " " + location;
            array_movie_times_and_location.Add(newdata);
            Console.WriteLine(array_movie_times_and_location[0]);


            return array_movie_times_and_location;
        }

        // the class for the costumer this way the costumer can use different functions within the application
        public class Costumer
        {
            public System.Collections.Generic.List<string>  array_movie_times_and_location;
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
                return array_movie_times_and_location;
            }
        }
        

        class Program
        {
            // there need to be changes here now the administrator needs to be arround to change the data given to the costumer this will change when we have a json file system going
            // also will this be more with if statements so the costumer can choose what they want to see, the same goes for the administrator
            static void Main(string[] args)
            {
                string[] array = { "1", "3", "3", "4", "5" };
                Administrator testing = new Administrator();
                array = testing.Age_prices_array();
                System.Collections.Generic.List<string> array_movie_times_and_location = testing.Times_and_dates();

                Costumer testuser = new Costumer();

                testuser.Newarray = array;
                testuser.Shows_prices_by_age();
                testuser.Show_times_and_dates();




            }
        }
    }
}
