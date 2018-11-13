using System;

namespace Esercizio
{
    public class car
    {
        int velocità;
        int altezza;
        int posizione;
        public car()
        {
            Random rand = new Random();
            velocità = rand.Next(1,5);
            altezza = rand.Next(10);
        }
    }
}