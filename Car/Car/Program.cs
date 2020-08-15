using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;

namespace Car
{

    class Person
    {
        private string név; // field
        public string Név   // property - Tulajdonság
        {
            get; set;
            /*get { return név; }
            set { név = value; }*/
        }
    }

    class Program
    {

        public string name; //Class Program konstruktora fogja használni, változó
        public Program() //Class Program konstruktora.
        {
            name = "Béla";
        }
        static void myMethod1(string szöveg) /*static = a metódus az adott osztályba tartozik,
                                * nem pedig egy objektuma az osztálynak: Objektumpéldány nélkül is hívható
                                * 
                                * public – nyilvános, mindenki számára hozzáférhető
                                * private – privát
                                * protected – származtatott osztály hozzáférhet
                                * static – statikus, objektumpéldány nélkül is hívható
                                * 
                                * <Access Specifier> <Return Type> <Method Name>(Parameter List) {
                                  Method Body}*/
        {
            Console.WriteLine(szöveg + "piros");
        }

        static int MyMethod2(int x) //int, float, double lehet.
        {
            return 5 + x;
        }
    }
}
        /*static void Main(string[] args)
        {
            Car_autó myObj = new Car_autó();
            Console.WriteLine(myObj.color);
            myMethod1("Vagyis: ");
            //Program ojjektumpeldany = new Program();
            //ojjektumpeldany.myMethod1();
            Console.WriteLine(MyMethod2(3));

            //KONSTRUKTORHOZ:
            Program myObj2 = new Program();
            Console.WriteLine(myObj2.name);

            //GET, SET
            Person myObj3 = new Person();
            myObj3.Név = "Tomi";
            Console.WriteLine(myObj3.Név);








            Console.ReadKey();
        }
    }
}*/
