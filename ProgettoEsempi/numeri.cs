namespace ProgettoEsempi
{
    public class numeri
    {
        public int numMaggiore
        {
            // get indica quello che restituirà quando viene chiesto il valore
            get{
                return finalNumMaggiore;
            }
            // set indica quello che viene eseguito quando si prova ad impostargli un valore
            set{
                // Se il valore passato è maggiore di 0 lo setto altrimenti no
                if (value > 0)
                {
                    finalNumMaggiore = value;
                }
            }
        }

        int finalNumMaggiore;

        public int numMinore
        {
            get{
                return finalNumMinore;
            }

            set{
                if (value <= 0)
                {
                    finalNumMinore = value;
                }
            }
        }

        int finalNumMinore;
    }
}