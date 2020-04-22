using System;
using System.Linq;
using Newtonsoft.Json;



namespace filter
{

    class Program
    {
        static void Main(string[] args)
        {
            string tag1 = "emptyTag";
            string tag2 = "emptyTag";
            string tag3 = "emptyTag";
            string movieGenres = "fantasy, horror, anime, action, adventure, family";
            int minDuration = -1;
            int maxDuration = 99999999;

            void durationSelection()
            {
                Console.WriteLine("Enter the minimum duration (in minutes) of the movie");
                int.TryParse(Console.ReadLine(), out minDuration);
                while (minDuration <= 0)
                {
                    Console.WriteLine("Please enter a numeric positive value, enter the minimum duration (in minutes) of the movie");
                    int.TryParse(Console.ReadLine(), out minDuration);
                }

                Console.WriteLine("Enter the maximum duration (in minutes) of the movie");
                int.TryParse(Console.ReadLine(), out maxDuration);
                while (maxDuration <= 0)
                {
                    Console.WriteLine("Please enter a numeric positive value, enter the maximum duration (in minutes) of the movie");
                    int.TryParse(Console.ReadLine(), out maxDuration);
                }
                if (tag1 == "emptyTag")
                {
                    Console.WriteLine("For filtering on genre, enter 1, for displaying filtered movies, enter anything else");
                    if (Console.ReadLine() == "1")
                        genreSelection();
                }


            }

            void genreSelection()
            {
                Console.WriteLine("Enter your first genre:");
                string selection = Console.ReadLine();
                while (!movieGenres.Contains(selection))
                {
                    Console.WriteLine("there are no movies with this genre, the genres you can choose from are: ");
                    Console.WriteLine(movieGenres);
                    selection = Console.ReadLine();
                }
                tag1 = selection;

                Console.WriteLine("Enter 'OK' to enter a second tag, enter anything else to continue");

                if (Console.ReadLine() == "OK")
                {
                    Console.WriteLine("Enter your second genre:");
                    selection = Console.ReadLine();
                    while (!movieGenres.Contains(selection))
                    {
                        Console.WriteLine("there are no movies with this genre, the genres you can choose from are: ");
                        Console.WriteLine(movieGenres);
                        selection = Console.ReadLine();
                    }
                    tag2 = selection;

                    Console.WriteLine("Enter 'OK' to enter a second tag, enter anything else to continue");

                    if (Console.ReadLine() == "OK")
                    {
                        Console.WriteLine("Enter your third genre: a - b - c");
                        selection = Console.ReadLine();
                        while (!movieGenres.Contains(selection))
                        {
                            Console.WriteLine("there are no movies with this genre, the genres you can choose from are: ");
                            Console.WriteLine(movieGenres);
                            selection = Console.ReadLine();
                        }
                        tag3 = selection;
                    }
                }
                    if (minDuration == 0 && maxDuration == 99999999)
                    {
                        Console.WriteLine("For filtering on duration, enter 1, for displaying filtered movies, enter anything else");
                        if (Console.ReadLine() == "1")
                            durationSelection();
                    }

                
            }
                    Console.WriteLine("For filtering on genre, enter 1. For filtering on duration, enter anything else");
                    if (Console.ReadLine() == "1")
                        genreSelection();
                    else
                        durationSelection();

                    for (int x = 1; x < Data.LoadMovies().Count + 1; x++)
                    {
                        if ((tag1 == "emptyTag" || Data.LoadMovies()[x - 1].GetMovieGenre() == tag1 || Data.LoadMovies()[x - 1].GetMovieGenre() == tag2 || Data.LoadMovies()[x - 1].GetMovieGenre() == tag3) && Data.LoadMovies()[x - 1].GetMovieDuration() > minDuration && Data.LoadMovies()[x - 1].GetMovieDuration() < maxDuration)
                            Console.WriteLine(Data.LoadMovies()[x - 1].GetMovieName());
                    }
                }
            }
        }

    
