using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class Data
{
<<<<<<< Updated upstream
    // the List Movie is the constructor in Movies.cs
    public static List<Movie> LoadMovies()
    {
        // Load the movieData.json here and parse to Movie objects
        using (StreamReader r = new StreamReader(@"C:\Users\jeroe\source\repos\Cinema-App\CInemaApp\movies.json"))
=======
    public static List<Movie> LoadMovies()
    {
        // Load the movieData.json here and parse to Movie objects
        using (StreamReader r = new StreamReader(@"C:\Users\basvo\Documents\GitHub\Cinema-App\filter\filter\movies.json"))
>>>>>>> Stashed changes
        {
            string json = r.ReadToEnd();
            List<Movie> items = JsonConvert.DeserializeObject<List<Movie>>(json);
            return items;
<<<<<<< Updated upstream
            /*foreach(Movie item in items){
                Console.WriteLine(item.GetMovieDetails() + "\n\n");
            }*/
=======

>>>>>>> Stashed changes
        }
    }
}
