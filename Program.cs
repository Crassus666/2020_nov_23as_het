using System;

namespace kozos_oszto_Pelsoczi_Domokos12A
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, szam1, szam2, j, eredmeny = 1;

            Console.Write("Kérem adja meg az első számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 < szam2)
                j = szam1;
            else
                j = szam2;
            for (i = 1; i <= j; i++)
            {
                if (szam1 % i == 0 && szam2 % i == 0)
                {
                    eredmeny = i;
                }
            }
            Console.Write("\nA legnagyobb közös osztó a(z) {0}\n\n",eredmeny);
        }
    }
}
