using System;

namespace ProgettoEccezioni
{
    public class EccezionePersonale : Exception
    {
        public EccezionePersonale() : base()
        {

        }

        public EccezionePersonale(string msg) : base(msg)
        {
            
        }

        public EccezionePersonale(string msg, Exception inner) : base(msg, inner)
        {
            
        }
    }
}