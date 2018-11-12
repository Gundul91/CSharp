using System;
using System.IO;

// System.IO serve per lavorare con i file

namespace ProgettoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parole = {"ciao", "we", "hey"};
            StreamWriter f = new StreamWriter("prova.txt", true); //Apre il file (il true serve per indicare di aggiungere le informazioni se già esiste)

            foreach(string s in parole)
            {
                f.WriteLine(s); // Scrive nel file questa linea
            }

            f.Close();  // Ricordare di chiudere sempre i file dopo averli usati

            // Sintassi utile per non dimenticarsi di chiudere il file
            using(StreamWriter g = new StreamWriter("prova.txt", true))
            {
                foreach(string s in parole)
                {
                    g.WriteLine(s); // Scrive nel file questa linea
                }
            }

            File.AppendAllLines("prova.txt", parole); //Riceve percorso e array e aggiunge al file quelle righe (deve essere fatto quando il file non è aperto)

            StreamReader letto = new StreamReader("prova.txt");
            
            /* Console.WriteLine("while(!letto.EndOfStream)");
            while(!letto.EndOfStream)
            {
                Console.WriteLine(letto.ReadLine());
            }*/
            Console.WriteLine("letto.ReadToEnd()");
            string a = letto.ReadToEnd(); // ReadToEnd() esegue la stessa funzione del while precedente
            Console.WriteLine(a);

            letto.Close();
        }
    }
}
