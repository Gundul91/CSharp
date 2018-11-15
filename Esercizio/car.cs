using System;

namespace Esercizio
{
    public class Persona
    {
        public int y;
        public int x;
        public Persona(int righe, int colonne)
        {
            y = righe;
            x = (colonne/2);
        }
        public void showPersona(string[,] matrice)
        {
            matrice[y,x] = " * ";
        }
    }
    public class Car
    {
        int velocità;
        public int y;
        public int x;
        public Car()
        {
            Random rand = new Random();
            velocità = rand.Next(1,6);
            y = rand.Next(9);
            x = 0;
        }

        public void moveCar(string[,] matrice, int righe, int colonne)
        {
            matrice[y, x] = " - ";
            if(((x + velocità) < colonne))
            {
                x = (x + velocità);
            } else {
                Random rand = new Random();
                y = rand.Next(righe);
                x = 0;
            }
        }

        public void showCar(string[,] matrice)
        {
            matrice[y,x] = " > ";
        }
    }
}