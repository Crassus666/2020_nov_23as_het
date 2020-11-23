using System;

namespace primszame_Pelsoczi_Domokos_12A
{
    class Program
    {
        static bool prim_e(int a)
        {
            int i = 2;
            double gyok = Math.Round(Math.Sqrt(a));
            while (a % i != 0 && i <= gyok)
            {
                i++;
            }
            if (i > gyok)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.WriteLine("A szám: ");
            string line = Console.ReadLine();
            int a = Convert.ToInt32(line);
            if (prim_e(b))
            {
                Console.WriteLine(a + " prímszám.");
            }
            else
            {
                Console.WriteLine(a + " nem prímszám.");
            }
            Console.ReadKey();
            
        }
}
