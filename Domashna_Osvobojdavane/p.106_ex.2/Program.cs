using System;
//Homework by Ivan Popev p.106/ex.2

namespace p._106_ex._2
{
    class Program
    {
        public static bool CheckForPairSumEqualToX(int[] chisla, int turseno_chislo)
        {
            int min = 0;
            int max = chisla.Length - 1;
            for (int i = 0; i < chisla.Length; i++)
            {
                if (chisla[min] + chisla[max] > turseno_chislo) max--;
                else if (chisla[min] + chisla[max] < turseno_chislo) min++;
                else if (min != max) return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int turseno_chislo = 10;
            int[] masivChisla = new int[] { 5, 6, 2, 7, 6, 12, 33, 45 };
            if (CheckForPairSumEqualToX(masivChisla, turseno_chislo)) Console.WriteLine($"Ima dvoika, chiito sbor e raven na chisloto {turseno_chislo}");
            else Console.WriteLine($"Nqma dvoika, chiito sbor da e raven na chisloto {turseno_chislo}");
        }
    }
}
