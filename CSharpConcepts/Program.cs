using System;
using CSharpConcepts.Constructor;
using CSharpConcepts.Shallow;
using CSharpConcepts.UsingIComparernamespace;
using CSharpConcepts.UsingIEquatableNamespace;

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
                Console.WriteLine("12. Using IComparable");
                Console.WriteLine("13. Using IComparer");
                Console.WriteLine("14. Equality Scenarios");
                Console.WriteLine("15. UsingIEquatable");
                Console.WriteLine("16. Shallow Copy");
                Console.WriteLine("17. Constructors");

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
                    case 12:
                        UsingIComparable uic = new UsingIComparable();
                        uic.start();
                        break;
                    case 13:
                        UsingIComparer uico = new UsingIComparer();
                        uico.start();
                        break;
                    case 14:
                        EqualityScenario eq = new EqualityScenario();
                        eq.start();
                        break;
                    case 15:
                        UsingIEquatable ui = new UsingIEquatable();
                        ui.start();
                        break;
                    case 16:
                        ShallowCopy sc = new ShallowCopy();
                        sc.start();
                        break;
                    case 17:
                        Constructors c = new Constructors();
                        c.start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
