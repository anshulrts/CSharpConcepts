﻿using System;
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
                Console.WriteLine("18. Exception Handling");
                Console.WriteLine("19. Try Catch Finally");
                Console.WriteLine("20. Constructor Chaining");
                Console.WriteLine("21. ValueTypeVsReference");
                Console.WriteLine("22. Reference Comparison By Different Insert");
                Console.WriteLine("23. AbstractClass");
                Console.WriteLine("24. Custom Exception");
                Console.WriteLine("25. Finally Not Executed");

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
                    // Here the link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
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
                    case 18:
                        try
                        {
                            ExceptionHandling exc = new ExceptionHandling();
                            exc.start();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Exception in Main()");
                        }
                        break;
                    case 19:
                        TryCatchFinally tcf = new TryCatchFinally();
                        int abc = tcf.start();
                        // Prints 2
                        Console.WriteLine(abc);
                        break;
                    case 20:
                        ConstructorChaining constructorChaining = new ConstructorChaining();
                        constructorChaining.start();
                        break;
                    case 21:
                        ValueTypeVsRef vtr = new ValueTypeVsRef();
                        vtr.start();
                        break;
                    case 22:
                        ReferenceComparisonByDifferentInsert rb = new ReferenceComparisonByDifferentInsert();
                        rb.start();
                        break;
                    case 23:
                        AbstractClass ac = new AbstractClass();
                        ac.start();
                        break;
                    case 24:
                        CustomException cs = new CustomException();
                        cs.start();
                        break;
                    case 25:
                        FinallyNotExecuted fne = new FinallyNotExecuted();
                        fne.start();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
