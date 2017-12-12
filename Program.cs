using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_saipem_20_persoana_delegate_display
{
    public class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        public string FormatString (Func<Persoana, string> function)
        {
            return function(this);
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Persoana[] arr = new Persoana[5]
            {
                new Persoana ()
                {
                    Nume = "Ionescu",
                    Prenume = "Ion",
                    Varsta = 20
                },
                new Persoana ()
                {
                    Nume = "Georgescu",
                    Prenume = "George",
                    Varsta = 30
                },
                new Persoana ()
                {
                    Nume = "Mihailescu",
                    Prenume = "Mihai",
                    Varsta = 40
                },
                new Persoana ()
                {
                    Nume = "Bogdanescu",
                    Prenume = "Bogdan",
                    Varsta = 50
                },
                new Persoana ()
                {
                    Nume = "Vladescu",
                    Prenume = "Vlad",
                    Varsta = 60
                }
            };

            foreach (var item in arr)
            {
                Console.WriteLine(item.FormatString(
                    x =>
                    {
                        return string.Format("Nume: {0}, Prenume: {1}, Varsta: {2}", x.Nume, x.Prenume, x.Varsta);
                    }
                    ));
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item.FormatString(
                    x =>
                    {
                        return string.Format("{0}, {1}, {2} ani", x.Nume, x.Prenume, x.Varsta);
                    }
                    ));
            }
        }
    }
}
