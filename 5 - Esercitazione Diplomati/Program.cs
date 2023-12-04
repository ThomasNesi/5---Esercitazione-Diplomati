using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Esercitazione_Diplomati
{
    class Diplomati
    {
        public string[] Nomivecchi { get; set; }
        public int[] Votivecchi { get; set; }

        public Diplomati(string[] nomivecchi,int[] votivecchi)
        {
            Nomivecchi = nomivecchi;
            Votivecchi = votivecchi;
        }
        public virtual string visualizzavecchi()
        {
            Console.WriteLine("Vecchi studenti: " +  Nomivecchi + " Voto: " + Votivecchi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
