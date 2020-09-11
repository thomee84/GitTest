using System;
using System.Globalization;
using System.Linq;

namespace AdoazonositoJel
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:
            int elsoszam = 8;

            //2-6-ig:
            DateTime szuletesiido = new DateTime(1984, 12, 31);
            DateTime viszonyitas = new DateTime(1867, 01, 01);

            TimeSpan t = szuletesiido - viszonyitas;
            double NrOfDays = t.TotalDays;

            Console.WriteLine(String.Format("{0:0}", t.TotalDays));

            //7-9:
            Random rnd = new Random();
            int veletlen = rnd.Next(1, 1000);
            Console.WriteLine(veletlen);

            //1-9-ig felosztás
            int[] xorzas = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
                int[] answer = new int[10];
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < xorzas.Length; j++)
                {

                    answer[i] = Convert.ToInt32(Console.ReadLine());
                    int szumma = (answer[i] * xorzas[j]);
                    

                    //Console.WriteLine(((answer[i] * xorzas[j])));
                }
            }
            
        }
    }
}
