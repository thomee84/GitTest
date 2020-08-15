using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Teszt
    {

        static void MyMethod1(string firstName)
        {
            Console.WriteLine(firstName + " lastName");
        }

        static int MyMethod2(int x)
        {
            return 5+x;
        }
        static void MyMethod3(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child1);
        }

        static void MyMethod4(int size, string name)
        {
            Console.WriteLine("Size = {0}, Name = {1}", size, name);
        }

        static void MyMethod5(string name, int size)
        {
            Console.WriteLine("Name = {0}, Size = {1}", name, size);
        }

        static void MyMethod6(string child1 = "Jóska", string child2 = "Pistike", string child3 = "Petike",
                              string child4 = "Isti")
        {
            Console.WriteLine(child4);
        }

        static void Main(string[] args)
        {
            MyMethod1("Keresztnév");
            
            Console.WriteLine(MyMethod2(5));
            MyMethod3(child3: "John", child1: "Liam", child2: "Liam");
            
            MyMethod4(name: "Perl", size: 5);
            MyMethod4(name: "Dot", size: -1);
            MyMethod4(6, "Net");
            MyMethod4(7, name: "Google");

            Console.WriteLine();
            MyMethod5(name: "első", size: 2);
            MyMethod5("második", 4);
            MyMethod5(size: 9, name: "név");
            
            Console.WriteLine();
            MyMethod6("child4");

            Console.ReadKey();
        }
    }
}
