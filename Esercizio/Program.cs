using System;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int righe = 9;
            int colonne = 9;
            Boolean morto = false;
            char tasto;
            Car[] macchine = new Car[7];
            for(int i=0; i<7; i++)
            {
                macchine[i] = new Car();
            }
            string[,] matrice = new string[righe, colonne];
            for(int i=0; i<righe; i++)
            {
                for(int j=0; j<colonne; j++)
                {
                    matrice[i,j] = " - ";
                }
            }
            Persona pg = new Persona((righe - 1), (colonne - 1));
            do {
                pg.showPersona(matrice);
                stampaMappa(matrice, righe, colonne);
                Console.WriteLine("Scegli come muoverti con WASD");
                tasto = Console.ReadKey().KeyChar;
                Console.WriteLine(tasto);
                matrice[pg.y, pg.x] = " - ";
                switch(tasto)
                {
                    case 'w':
                        pg.y--;
                        break;
                    case 's':
                        pg.y++;
                        break;
                    case 'a':
                        pg.x--;
                        break;
                    case 'd':
                        pg.x++;
                        break;
                    default:
                        Console.WriteLine("Non è passato in nessuno dei casi");
                        break;
                }
                foreach(Car macchina in macchine)
                {
                    int vx = macchina.x;
                    int vy = macchina.y;
                    macchina.moveCar(matrice, (righe - 1), (colonne - 1));
                    macchina.showCar(matrice);
                    if(pg.y == vy && pg.x > vx)
                    {
                        if(macchina.x > vx)
                        {
                            if(pg.x <= macchina.x)
                                morto = true;
                        } else {
                            morto = true;
                        }
                    }
                }
            } while(pg.y > 0 && !morto);
            if(morto)
            {
                Console.WriteLine("Sei stato preso sotto...");
            } else {
                Console.WriteLine("Sei passato!");
            }
        }

        static void stampaMappa(string[,] matrice, int righe, int colonne)
        {
            for(int i=0; i<righe; i++)
            {
                for(int j=0; j<colonne; j++)
                {
                    Console.Write(matrice[i,j]);
                }
                Console.Write("\n");
            }
        }
    }
}
