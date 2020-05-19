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
                Console.WriteLine("6. Abstract With Interfaces");
                Console.WriteLine("7. Delegates");
                Console.WriteLine("8. Events");
                Console.WriteLine("9. Static Constructor");
                Console.WriteLine("10. AsyncAwait");
                Console.WriteLine("11. Yield Keyword");

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
                    case 7:
                        DelegateClass d = new DelegateClass();
                        d.start();
                        break;
                    case 8:
                        EventClass e = new EventClass();
                        e.start();
                        break;
                    case 9:
                        TestStatic ts = new TestStatic();
                        ts.start();
                        break;
                    case 10:
                        AsyncAwait aw = new AsyncAwait();
                        aw.start();
                        break;
                    case 11:
                        YieldKeyword yk = new YieldKeyword();
                        yk.start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
