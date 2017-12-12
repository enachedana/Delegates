using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    public static class extensions
    {
        public static string format;
        public static string Afisare<T>(this T[] arr, string _format) // Method 1
        {
            format = _format;
            StringBuilder sb = new StringBuilder();
            foreach (T item in arr)
            {
                sb.Append(item);
                sb.Append("\n");

            }
            return sb.ToString();
        }

    }

    public class Persoana
    {
       string nume;
        string prenume;
        int varsta;
        public Persoana(string _nume,string _prenume,int _varsta)
        {
            nume = _nume;
            prenume = _prenume;
            varsta = _varsta;
        }
        public override string ToString()
        {
          if (extensions.format == "npv")
                return "Nume " + nume + " Prenume " + prenume + " Varsta " + varsta;
           if (extensions.format == "pnv")
                return " Prenume " + prenume +"Nume " + nume +  " Varsta " + varsta;

            return " Varsta " + varsta+ " Prenume " + prenume +"Nume " + nume  ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            Persoana[] persoane = new Persoana[10];
            persoane[0] = new Persoana("A", "a", r.Next(181));
            persoane[1] = new Persoana("B", "b", r.Next(181));
            persoane[2] = new Persoana("C", "c", r.Next(181));
            persoane[3] = new Persoana("D", "d", r.Next(181));
            persoane[4] = new Persoana("E", "e", r.Next(181));
            persoane[5] = new Persoana("F", "f", r.Next(181));
            persoane[6] = new Persoana("G", "g", r.Next(181));
            persoane[7] = new Persoana("H", "h", r.Next(181));
            persoane[8] = new Persoana("I", "i", r.Next(181));
            persoane[9] = new Persoana("J", "j", r.Next(181));
            Console.WriteLine(persoane.Afisare<Persoana>("npv"));
            Console.Read();

        }
    }
}
