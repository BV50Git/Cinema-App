using System;

namespace CInemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] movies = { "star wars", "lord of the rings", "pirates of the carribean", "sharknado" };
            var movies = new System.Collections.Generic.List<string>() { "star wars", "lord of the rings", "pirates of the carribean", "sharknado" };
            // Insert strings from an array in position 1.
            
            bool c = true;
            

            while (c == true) 
            {
                int z = 0;
                foreach (string i in movies)
                {
                    Console.WriteLine(z + " " + i);
                    z = z + 1;
                }
                Console.WriteLine("enter 1 for adding movies");
                Console.WriteLine("enter 2 for removing movies");
                Console.WriteLine("enter quit to stop");
                Console.Write("Enter a command: ");
                string val = Console.ReadLine(); 
                if (val == "quit")
                {
                    c = false;
                }
                else if (val == "1")
                {
                    Console.Write("name of the movie: ");
                    string a = Console.ReadLine();
                    movies.Add(a);
                }

                else if (val == "2")
                {
                    Console.Write("position of the movie: ");
                    string b = Console.ReadLine();
                    int res = Convert.ToInt32(b);
                    if(res < movies.Count){
                        movies.RemoveAt(res); 
                    }
                    else
                    {
                        Console.WriteLine("there is no movie on that posisiton");
                    }
                }



                
            }
        }
    }
}
