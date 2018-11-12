using System;
using System.IO;

namespace ProgettoEccezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Qui si inserisce il codice da provare ad eseguire
            {
                //StreamReader f = new StreamReader("prova.txt");
                Dividi(0,2);
            }
            catch (FileNotFoundException e) // Questo è un catch specifico per quel tipo di errore (ce ne sono molti altri)
            {
                Console.WriteLine("File inesistente");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (EccezionePersonale e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) // Questo è un catch generico per 1 errore
            {
                Console.WriteLine("Errore: ", e.ToString());
            }
            finally // Quello contenuto nel finally viene eseguito in qualunque caso
            {
                Console.WriteLine("Passaggio nel finally");
            }
        }

        static int Dividi(int a, int b)
        {
            if(b == 0)
            {
                // throw lancia un eccezione e se gli passo una stringa setto il messaggio dell'eccezione
                throw new DivideByZeroException("Eccezione della divisione per 0");
            }
            if(a == 0)
            {
                // Lancio l'eccezione creata da me
                throw new EccezionePersonale("Eccezione personale!");
            }
            return a/b;
        }
    }
}
