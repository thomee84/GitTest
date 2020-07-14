using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace Gepiras
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again;
            char key = ' ';
            int plays;
            int counter = 0;
            int szumma;
            Stopwatch stopwatch = new Stopwatch();
            
            Console.WriteLine("Üsd le a megjelenő karaktert!");
            Console.WriteLine("/////////////////////////////");
            Console.WriteLine();
            Console.WriteLine("Hány kör?");
            plays = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= plays; i++)
            {   
                do
                {   
                    Random rnd = new Random();
                    char randomChar = (char)rnd.Next('1', 'z');
                    Console.Write(" " + randomChar + " | ");
                    
                    for (int j = 0; j < 1; j++)
                    {   
                        stopwatch.Start();
                        key = char.Parse(Console.ReadLine());
                        stopwatch.Stop();
                        Console.WriteLine("Részidő: {0}", stopwatch.Elapsed);
                        counter++;
                        
                        /*DateTime[] ary = new DateTime[10];

                        ary[counter] = Convert.ToDateTime(stopwatch.Elapsed);
                        szumma = Convert.ToInt32(ary.Sum);*/
                        
                    }
                    
                    if (key == randomChar)
                    {
                        again = true;
                    }
                    else if (plays > 1) 
                    {
                        again = true;
                        plays = plays - 1;
                        Console.WriteLine();
                        counter = counter - 1;
                        Console.WriteLine("Hiba! Új játék.");
                    }
                    else
                    {
                        again = false;
                        Console.WriteLine();
                        Console.WriteLine("Statisztika: {0}", counter - 1 + " találat.");
                        Console.WriteLine();
                        Console.WriteLine("Hiba! Nyomj egy gombot a kilépéshez!");
                    }
                } while (again);
            }
            Console.ReadKey();
        }
    }
}
