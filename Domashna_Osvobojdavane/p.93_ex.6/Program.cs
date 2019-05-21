using System;
//Homework by Ivan Popev p.93/ex.6

namespace p._93_ex._6
{
    class Program
    {
        static void qbulki(string currPut, ref string kraenPut, int segashenRezultat, ref int kraenRezultat, int row, int col, int[,] pole, int posX, int posY)
        {
            if (posX == row - 1 && posY == col - 1)
            {
                if (segashenRezultat >= kraenRezultat)
                {
                    kraenRezultat = segashenRezultat;
                    currPut = currPut.Substring(0, currPut.Length - 1);
                    kraenPut = currPut;
                }
                segashenRezultat = 0;
                currPut = "";
                return;
            }
            if (posX == row - 1)
            {
                segashenRezultat += pole[posX, posY];
                qbulki(currPut += " dqsno -", ref kraenPut, segashenRezultat, ref kraenRezultat, row, col, pole, posX, posY + 1);
                return;
            }
            if (posY == col - 1)
            {
                segashenRezultat += pole[posX, posY];
                qbulki(currPut + " dolu -", ref kraenPut, segashenRezultat, ref kraenRezultat, row, col, pole, posX + 1, posY);
                return;
            }

            segashenRezultat += pole[posX, posY];

            qbulki(currPut + " dqsno -", ref kraenPut, segashenRezultat, ref kraenRezultat, row, col, pole, posX, posY + 1);
            qbulki(currPut + " dolu -", ref kraenPut, segashenRezultat, ref kraenRezultat, row, col, pole, posX + 1, posY);

        }

        static void Main(string[] args)
        {
            int poziciqX = 0;
            int poziciqY = 0;
            string path = "";
            string pathFinal = "";
            int score = 0;
            int finalScore = 0;
            int[,] duska_qbulki = new int[3, 5] { { 1, 5, 8, 4, 9 }, { 2, 11, 3, 8, 7 }, { 22, 14, 89, 12, 5 } };

            qbulki(path, ref pathFinal, score, ref finalScore, duska_qbulki.GetLength(0), duska_qbulki.GetLength(1), duska_qbulki, poziciqX, poziciqY);

            Console.WriteLine($"Maksimalniqt broi qbulki, koito moje da se subere e : {finalScore}");
            Console.WriteLine($"Putqt koito trqbva da bude poet e sledniqt: {pathFinal}");
        }
    }
}

