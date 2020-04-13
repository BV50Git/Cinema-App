using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are the popularmovies: ");
            List<string> Movies = new List<string>();
            Movies.Add("Bad Boys for Life from 2020");
            Movies.Add("The Godfather from 1974");
            Movies.Add("1917 from 2020");
            Movies.Add("Guardians of the Galaxy from 2014");
            Movies.Add("Joker from 2019");

            foreach (var movie in Movies)

                Console.WriteLine(Movies);
        }
    }
}
