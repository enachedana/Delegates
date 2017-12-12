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

            }
        }
    }
}
