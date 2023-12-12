using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Esercitazione_Diplomati
{
    class Diplomati
    {
        public string[] Nomi { get; set; }
        public int[] Voti{ get; set; }

        public Diplomati(string[] nomi,int[] voti)
        {
            Nomi = nomi;
            Voti = voti;
        }
        public virtual string visualizzadiplomati()
        {
            return $"Vecchi studenti: " +  Nomi + " Voto: " + Voti;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire numero Diplomati: ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Inserire nome Diplomato e voto: ");
            string[] n = new string[num];
            int[] v = new int[num];
            for (int i=0; i < num; i++)
            {
                Console.Write("Nome: ");
                n[i] = Console.ReadLine();
                Console.Write("Voto: ");
                v[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Diplomati diplomati = new Diplomati(n, v);
            Console.WriteLine(diplomati.visualizzadiplomati());
            Console.ReadLine();
            
        }
    }
}
