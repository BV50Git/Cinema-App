using CInemaApp;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CinemaApp
{   
    public class SeatingReservation
    { 
        public static string Seat()
        {
            int e = 0;
            int width = 0;
            int height = 0;
            int movieHall = 1;
            int userRow = 0;
            int userColumn = 0;
            int userSeat = 0;
            List<List<int>> reservation = new List<List<int>>();
            List<int> chosen_seat = new List<int>();
            int c = 0;
            string s = "";
            int Group = 1;
            Globals.group = Group;


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
                //int row = userRow;
                bool parseSucc = int.TryParse(Console.ReadLine(), out userRow);
                Console.WriteLine("Enter the column of the seat you want to reserve (1 - " + width + ")");
                parseSucc = int.TryParse(Console.ReadLine(), out userColumn);
                //int colum = userColumn;
                
                userSeat = (userRow - 1) * width + userColumn;
                
                if (!userSeats.Contains(userSeat) && userRow <= height && userColumn <= width) {
                    chosen_seat.Add(userRow);
                    chosen_seat.Add(userColumn);
                    reservation.Add(chosen_seat);
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
                Group = Group + 1;
                Globals.group = Group;
                Console.WriteLine("Type OK to confirm reservation, type anything else to select a different seat.");

    
            }
            //Admin.bb();
            foreach (var sublist in reservation)
            {
                foreach (var value in sublist)
                {
                   
                    s += value;
                       
                    if (c < 1)
                    {
                        
                        s += ":";
                        c += 1;
                    }
                    else
                    {
                        
                        s += ", ";
                        c = 0;
                    }
                }
                Console.WriteLine();
                break;
            }
            User.PaymentOption();
            return s;
        }
    }

}