using System;
using System.Runtime.InteropServices.ComTypes;

namespace Car
{

    class Jármű
    {
        public string márka = "Ford";
        public void duda()
        {
            Console.WriteLine("Tu tu");
        }
    }
    class Autó : Jármű
    {
        public string modelName = "Mustang";

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Autó myObj = new Autó();
            myObj.duda();
            Console.WriteLine(myObj.márka + " " + myObj.modelName);
            
            Console.ReadKey();
        }
    }
}
