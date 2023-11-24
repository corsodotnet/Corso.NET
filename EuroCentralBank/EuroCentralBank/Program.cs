using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace EuroCentralBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci Paese");
            string inputPaese = Console.ReadLine();
            //come si prendono i valori di un file csv?
            //bool militare = bool.Parse(Console.ReadLine());
            bool ciao = string.Parse(Console.ReadLine());
            Console.WriteLine(inputPaese);

            Country Italia = new Country("Italia", "no");
            Country Arabia = new Country("Arabia", "si");
            // quando prendi valori in input poi li devo tradurre in oggetti?
            // come si traducono valori in input in oggetti
            // potri fare if che preso il paese restituisce subito se rispetta o no diritti
            // potrei fare
            if (inputPaese.Contains(Arabia)
                Console.WriteLine($"Questo paese { i diritti umani");
            else
                Console.WriteLine("Rispetti i diritti umani");

        }
        public interface IOrganizzazione
        {
            string Name { get; }
            string Calcola();
        }
        public abstract class OrgDirittiUmani : IOrganizzazione
        {
            public string Name { get; set; }

            public string Calcola()
            {
                throw new NotImplementedException();
            }
        }
        public abstract class OrgEconominca : IOrganizzazione
        {
            public string Name { get; set; }
            public string Calcola()
            {
                throw new NotImplementedException();
            }
        }
        public interface IPunishment
        {
            public bool isPunish();
        }
        public abstract class Ente
        {
            private String name;
        }
        public class Country : Ente, IPunishment
        {
            private string name;
            private String punishment;
            public Country(String n, String pena) : base(n)
            {
                base.name = n;
                this.punishment = pena;
            }
            public bool isPunish()
            {
                DisablePrivateReflectionAttribute 
                return ret;
            }
        }

    }
}
