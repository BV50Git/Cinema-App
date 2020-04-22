using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CInemaApp

{
    // global class to use the variables in different things
    public class Globals
    {
        public static string[] array;
        public static System.Collections.Generic.List<string> Newarray_movie_times_and_location;
    }

    public class Paymentsystem
    {
        public void Paymentoption()
        {
            Console.WriteLine("please choose your payment option! (type the number of your choice to choose)");
            string c = "0";
            string s = "";
            int counter = 1;
            int options = 2;
            int i;
            int j;
            int height = 9;
            int width = 9;
            while (counter < options)
            {
                for (i = 1; i <= height; i++)
                {
                    for (j = 1; j <= width; j++)
                    {
                        if (i == 1 || i == height || j == 1 || j == width)
                            s = s + " *";
                        else
                            s = s + "  ";
                    }
                    s = s + "\n";
                }
                if (counter == 1)
                {
                    Console.WriteLine(s);
                    Console.WriteLine("   ideal option 1");
                }
                else if (counter == 2)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(" credit card option 2");
                }
                counter = counter + 1;
            }
          
            Console.WriteLine(s);
            Console.WriteLine(" credit card option 2");
            while (c != "4")
            {
                c = Console.ReadLine();
                if (c == "1")
                {
                    Console.WriteLine("please enter your Ideal information\n *********************");
                    string information = Console.ReadLine();
                    string x = "5";
                    c = "4";
                }
                if (c == "2")
                {
                    Console.WriteLine("please enter your credit card information\n *********************");
                    string information = Console.ReadLine();
                    
                    c = "4";
                }


            }
            // shows final ticket and show the time and payment done.
            string infopayed = " everything is payed ";
            

            
        }
        // administrator class so the administrator can use specific functions and add data needed in the application
        public class Administrator
        {
            // creates the price classes on the bases of age
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

                //var stringjson = JsonConvert.SerializeObject(array, Formatting.Indented);
                //System.IO.File.AppendAllText(@"C: \Users\Acer\AppData\Local\Temp\~vs39C6.json", stringjson);
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
                public System.Collections.Generic.List<string> array_movie_times_and_location;
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
                    var Newarray = array_movie_times_and_location;
                    return Newarray;
                }
            }


            class Program
            {
                // there need to be changes here now the administrator needs to be arround to change the data given to the costumer this will change when we have a json file system going
                // also will this be more with if statements so the costumer can choose what they want to see, the same goes for the administrator
                static void Main(string[] args)
                {
                    // start the while loop
                    string x = "0";
                    while (x != "6")
                    {
                        Console.WriteLine("Please type your choice 1 to fill in information. 2 to write the new information to the json fil\n 3 to get information from the json file. 4 t go to the payment system and pay your ticket");
                        x = Console.ReadLine();
                        if (x == "1")
                        // option to create the arrays of information in final program only useable by administrato
                        {
                            Administrator testing = new Administrator();
                            string[] array = testing.Age_prices_array();
                            System.Collections.Generic.List<string> Newarray_movie_times_and_location = testing.Times_and_dates();
                            Globals.Newarray_movie_times_and_location = Newarray_movie_times_and_location;
                            Globals.array = array;
                        }
                        if (x == "2")
                        // option to write information into the json file
                        {
                            Costumer testuser = new Costumer();

                            testuser.Newarray = Globals.array;

                            testuser.array_movie_times_and_location = Globals.Newarray_movie_times_and_location;
                            var stringjson = JsonConvert.SerializeObject(testuser, Formatting.Indented);


                            System.IO.File.WriteAllText(@"C:\Users\Acer\source\repos\json1.json", stringjson);
                        }
                        // needs t read from json file to print the information the user needs to see/ known problems does not print the times and date information
                        // still is unable to read from the json file
                        if (x == "3")
                        {
                            Console.WriteLine("here");
                            Console.WriteLine(System.IO.File.ReadAllText(@"C:\Users\Acer\source\repos\json1.json"));

                            // future reading code to make sure it reads without the brackets
                            //for (int d = 1; d < Dataprices.LoadPrices().Count + 1; d++)
                            //{
                            //    Console.WriteLine(x + ": " + Dataprices.LoadPrices()[d - 1].Getmovietime());
                            //}
                            



                        }
                        if (x == "4")
                        {
                            Paymentsystem testuser = new Paymentsystem();
                            testuser.Paymentoption();
                            //x = "5";
                        }
                        if (x == "5")
                        {
                            // does not yet place information in json file is for future ticket information
                            //Console.WriteLine("here");
                           // Paymentsystem testuser = new Paymentsystem();
                            //string information = testuser.Paymentoption();
                            //var stringjson = JsonConvert.SerializeObject(information, Formatting.Indented);
                           // System.IO.File.AppendAllText(@"C:\Users\Acer\source\repos\json1.json", stringjson);
                        }
                    }
                }
            }
        }
    }
}

