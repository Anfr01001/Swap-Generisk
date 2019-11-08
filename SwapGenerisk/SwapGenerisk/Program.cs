using System;

namespace SwapGenerisk {
    class Program {
        static void Main(string[] args) {
            int a = 10; int b = 20;
            string c = "Hej"; string d = "då";
            double e = 1.5; double f = 123.5;
            bool g = true; bool h = false;



            Console.WriteLine("Test kod där jag skickar in Int, string, double  & bool");
            Console.WriteLine("Int a = {0} och int b = {1} blir", a, b);
            new Swap<int>(ref a, ref b);
            Console.WriteLine("Int a = {0} och int b = {1}", a, b);

            Console.WriteLine("");

            Console.WriteLine(" Och nu med strings String ");
            Console.WriteLine("string c = {0} och string d = {1} som blir", c, d);
            new Swap<string>(ref c, ref d);
            Console.WriteLine("string c = {0} och string d = {1}", c, d);

            Console.WriteLine("");

            Console.WriteLine(" Och nu med doubles double ");
            Console.WriteLine("double e = {0} och double f = {1} som blir", e, f);
            new Swap<double>(ref e, ref f);
            Console.WriteLine("double e = {0} och double f = {1}", e, f);

            Console.WriteLine("");

            Console.WriteLine(" Och slutligen med bool");
            Console.WriteLine("bool g = {0} och bool h = {1} som blir", g, h);
            new Swap<bool>(ref g, ref h);
            Console.WriteLine("bool g = {0} och bool h = {1}", g, h);

            Console.ReadLine(); // vänta




        }
    }
}
