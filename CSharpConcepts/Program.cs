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
                Console.WriteLine("3. Method Overriding");
                Console.WriteLine("4. Pass By Reference");
                Console.WriteLine("5. Using Hashset");

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
                    case 3:
                        MethodOverriding m1 = new MethodOverriding();
                        m1.start();
                        break;
                    case 4:
                        PassByReference p = new PassByReference();
                        p.start();
                        break;
                    case 5:
                        UsingHashSet u = new UsingHashSet();
                        u.start();
                        break;
                    case 6:
                        AbstractWithInterface a = new AbstractWithInterface();
                        a.start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
