using System;
using System.IO.Pipes;

namespace inluppg6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string menyVal = "";
            while (menyVal != "3")
            {
                Console.WriteLine("1. Är n ett primtal?");
                Console.WriteLine("2. Antalet primtal mindre än n");
                Console.WriteLine("3. Avsluta program");
                menyVal = Console.ReadLine();

                switch(menyVal)
                {
                    case "1":
                        Console.WriteLine("Skriv in ett heltal");
                        int primtalQuery = int.Parse(Console.ReadLine());
                        if (IsPrimtal(primtalQuery))
                        {
                            Console.WriteLine($"{primtalQuery} är ett primtal\n");
                        }
                        else { Console.WriteLine($"{primtalQuery} är inte ett primtal\n"); }
                        break;

                    case "2":
                        Console.WriteLine("Skriv ett heltal");
                        int tal = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Det finns {PrimtalMindre(tal)} mindre än {tal}\n");
                        break;
                    case "3":
                        break;
                    default: Console.WriteLine("Fel inmatning\n"); break;
                }
            }
        }

        static int PrimtalMindre(int tal)
        {
            int primCounter = 0;
            for (int i = 1; i < tal; i += 2)
            {
                if (IsPrimtal(i))
                {
                    primCounter++;
                }
            }
            return primCounter;
        }

        static bool IsPrimtal(int x)
        {
            if (x == 1)
            {
                return true;
            }
            else if (x == 2)
            {
                return true;
            }


            if (x % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < x; i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}