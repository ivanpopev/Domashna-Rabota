using System;
//Homework by Ivan Popev p.28/ex.12

namespace p._28_ex._12
{
    class Program
    {
        public static bool plndrm(string duma)
        {

            char[] duma_simvoli = duma.ToCharArray();
            int broqch = duma.Length - 1;
            bool isFalse = false;
            for (int i = 0; i < duma_simvoli.Length; i++)
            {
                if (duma_simvoli[i] != duma_simvoli[broqch]) isFalse = true;
                broqch--;
            }
            return isFalse;
        }
        static void Main(string[] args)
        {
            Console.Write("Vkaraite duma, koqto da bude proverena: ");
            string duma = Console.ReadLine();
            if (!plndrm(duma)) Console.WriteLine("Dumata e palindrom");
            else Console.WriteLine("Dumata ne e palindrom");
        }
    }
}

