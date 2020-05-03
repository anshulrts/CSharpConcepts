using System;

namespace CSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n\n\n-----Menu Driven Program--------");
                Console.WriteLine("1. Exit");
                Console.WriteLine("2. Method Hiding");

                Console.WriteLine("\nEnter Choice");
                string x = Console.ReadLine();

                switch (Convert.ToInt32(x))
                {
                    case 1:
                        System.Environment.Exit(0);
                        break;
                    case 2:
                        MethodHiding m = new MethodHiding();
                        m.start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
