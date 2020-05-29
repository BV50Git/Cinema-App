using System;
using System.Linq;

namespace CinemaApp
{   
    class program
    { 
        static void Main2(string[] args)
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
            
        }
    }

}

