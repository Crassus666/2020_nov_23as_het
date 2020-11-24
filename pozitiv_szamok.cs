using System;

namespace pozitiv_szamok_Pelsoczi_Domokos12A
{
    class Program
    {
        static void Main(string[] args)
        {
            string sor;
            int szam;
            do
            {                
                Console.Write("Kérem írja be a számot: ");
                sor = Console.ReadLine();
                szam = Int32.Parse(sor);
                if (szam <= 0)
                {
                    Console.WriteLine("Pozitív számot írjon be!");
                }
            } 
            while (0 < szam );

        }
    }
}
