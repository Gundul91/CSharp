using System;

namespace ProgettoEsempi
{
    class Program
    {
        static void Main(string[] args)
        {
            numeri num = new numeri();
            Console.Write("numMaggiore: ");
            num.numMaggiore = Convert.ToInt32(Console.ReadLine());
            Console.Write("numMinore: ");
            num.numMinore = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("numMaggiore: " + num.numMaggiore + ",numMinore: " + num.numMinore);

            Random rand = new Random();
            Console.WriteLine("Ho creato un numero random: " + rand.Next());
        }
    }
}
