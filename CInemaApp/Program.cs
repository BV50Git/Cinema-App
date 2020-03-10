using System;
namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            int movieHall = 1;
            var userRow = 0;
            var userColumn = 0;

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

            void showSeats()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int o = 0; o < width; o++)
                    {
                        if (userRow == i + 1 && userColumn == o + 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    Console.Write("\n");
                }
            }
            void seatSelection()
            {
                Console.WriteLine("Enter the row of the seat you want to reserve (1 - " + height + ")");
                bool parseSucc = int.TryParse(Console.ReadLine(), out userRow);
                if (parseSucc)
                {
                    Console.WriteLine(userRow);
                }
                Console.WriteLine("Enter the column of the seat you want to reserve (1 - " + width + ")");
                bool parseSucc = int.TryParse(Console.ReadLine(), out userColumn);
                if (parseSucc)
                {
                    Console.WriteLine(userColumn);
                }
                showSeats();
            }
            showSeats();
            seatSelection();
            Console.WriteLine("Type OK to confirm reservation, type anything else to select a different seat.");
            while(Console.ReadLine() != "OK")
            {
                seatSelection();
                Console.WriteLine("Type OK to confirm reservation, type anything else to select a different seat.");
            }
        }
    }

}