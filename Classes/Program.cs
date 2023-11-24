using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //private int ciao;
            Cittadino c = new Cittadino(false, 30, 28, 100, 2, 2, 100000, true);
            Console.WriteLine("Hello World!");
            c.Verifica();
            //Console.WriteLine(value: c.Verifica());
        }
        public class Cittadino
        {
            private bool militare;
            private int eta;
            private int media_Maturita;
            private int media_Univ;
            private int anni_No_Reddito;
            private int figli_Carico;
            private int pil_Comune;
            private bool debiti;

            private int temp;

            public Cittadino(bool militare, int eta, int media_Maturita, int media_Univ,
                             int anni_No_Reddito, int figli_Carico, int pil_Comune, bool debiti)
            {  
                this.militare        = militare;
                this.eta             = eta;
                this.media_Maturita  = media_Maturita;
                this.media_Univ      = media_Univ;
                this.anni_No_Reddito = anni_No_Reddito;
                this.figli_Carico    = figli_Carico;
                this.pil_Comune      = pil_Comune;
                this.debiti          = debiti;
            }
            public void Verifica()
            {
                if (this.militare = true)
                    this.temp = +5;
                else if (this.eta >= 18 && this.eta <= 25)
                    this.temp = +5;
                else if (this.anni_No_Reddito > 2)
                    this.temp = +4;
                else if (this.media_Maturita > 28)
                    this.temp = +4;
                else if (this.media_Univ > 90)
                    this.temp = +4;
                else if (this.pil_Comune < 100000)
                    this.temp = +4;
                else if (this.debiti = true)
                    this.temp = +4;
                if(this.temp > 25 )
                    Console.WriteLine("Hai ottenuto il RdC");
                else                    
                    Console.WriteLine("Non hai ottenuto il RdC");
                
            }

        }
    }
}
