using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // ^ = XOR  funziona quando le 2 condizioni danno risultati diversi Vero/Falso
            if(a > 5 ^ b > 5)
            {
                Console.WriteLine("Solo uno dei due numeri è maggiore di 5");
            }
            Console.WriteLine("Hello World!");

            
            Console.Write("Inserire numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // % da il resto della divisione tra num e 2
            if(num % 2 == 0)
            {
                Console.WriteLine("Il numero è pari");
            } else {
                Console.WriteLine("Il numero è dispari");
            }

            Prova prova1 = new Prova("Gun");
            Prova prova2 = new Prova("Andy");
            prova2.nome = "Andrea"; // In questo modo assegno un valore diverso alla variabile nome
            prova1.saluta();
            prova2.saluta();

            Base bas1 = new Base(4,8);
            bas1.stampaNumeri();

            Secondaria sec1 = new Secondaria(5);
            sec1.ComunicaAnni();
        }
    }

    class Prova
    {
        public string nome = "Marco"; // var pubblica
        string soprannome; // var privata

        // costruttore
        public Prova(string soprannome)
        {
            // con il this indico la var della classe mentre l'altro è l'argomento ricevuto
            this.soprannome = soprannome;
        }
        public void saluta()
        {
            Console.WriteLine("Ciao " + nome + " detto " + soprannome + "!");
            Addio();
        }

        // Se non indico nulla la funzione viene dichiarata come private e può esssere richiamata solo all'interno della classe
        void Addio()
        {
            Console.WriteLine("Addio");
        }
    }

    class Base
    {
        protected int anni = 10;
        protected int n1,n2;

        public Base(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        protected void saluto()
        {
            Console.WriteLine("Ciao sono la classe Base");
        }

        // virtual indica che la funzione può essere modificata
        public virtual void stampaNumeri()
        {
            Console.WriteLine("I 2 numeri sono: " + n1 + ", " + n2);
        }
    }

    // COn i ":" indico di ereditare tutto il public e protected della classe indicato, ma non il private
    class Secondaria : Base
    {
        // Richiamo il costruttore della classe base e gli indico che il secondo valore passato sarà 0
        public Secondaria(int n1) : base(n1,0)
        {
            
        }
        public void ComunicaAnni()
        {
            Console.WriteLine("Ho " + anni + " anni");
            stampaNumeri();
        }

        // override indica che si sovrascrive la funzione
        public override void stampaNumeri()
        {
            Console.WriteLine("Il numero è: " + n1);
        }

    }
}
