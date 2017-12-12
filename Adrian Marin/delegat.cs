using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_7_CSharp_afisare_prin_delegati
{
    class Persoane
    {
        public string prenume { set; get; }
        public string nume { set; get; }
        public int varsta { set; get; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persoane []p=new Persoane [3];
            p [0] = new Persoane();
            p[1] = new Persoane();
            p[2] = new Persoane();
            p[0].nume = "Iancu";
            p[0].prenume = "Toma";
            p[0].varsta = 23;
            p[1].nume = "George";
            p[1].prenume = "Ion";
            p[1].varsta = 17;
            p[2].nume = "Marian";
            p[2].prenume = "Georgescu";
            p[2].varsta = 43;

           // for (int i = 0; i < p.Length; i++)
             // Console.WriteLine(p[i].nume.ToString());
            //for (int i = 0; i < p.Length; i++)
            // Console.WriteLine(String.Format("Nume: {0}, Prenume: {1}, Varsta: {2}", p[i].nume, p[i].prenume, p[i].varsta));
            Utility.PrintToScreen(x => { return x.nume == "Iancu"; },p);
                

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_7_CSharp_afisare_prin_delegati
{
    class Utility
    {
        public static void PrintToScreen(Func<Persoane, bool> function, Persoane[] arr)
        {
            //StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (Persoane p in arr)
            {
                if (function(p) == true)
                    Console.WriteLine(String.Format("Nume: {0}, Prenume: {1}, Varsta: {2}", arr[i].nume, arr[i].prenume, arr[i].varsta));
                Console.WriteLine();
                i++;
            }
        }
    }
        }

