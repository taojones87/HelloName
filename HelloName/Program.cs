using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Matthew Peters";
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("Hello " + name + "!");
            Console.ReadKey(true);
        }
    }
}
