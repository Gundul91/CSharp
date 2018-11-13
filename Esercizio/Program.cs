using System;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrice = new string[10, 10];
            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    matrice[i,j] = " - ";
                    Console.Write(matrice[i,j]);
                }
                Console.Write("\n");
            }
        }
    }
}
