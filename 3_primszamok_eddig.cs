using System;

namespace Primszamok_eddig_Pelsoczi_Domokos12A
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i, vege, szam;          
            Console.Write("Adja meg a számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("A prímszámok eddig a számig: \n", szam);

            for (j = 1; j <= szam; j++)
            {
                vege = 0;

                for (i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        vege++;
                        break;
                    }
                }

                if (vege == 0 && j != 1)
                    Console.Write("{0} ", j);
            }
            
        }
    }
}
