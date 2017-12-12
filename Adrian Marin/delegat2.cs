using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_7_CSharp_operatie_prin_delegati
{
    class Numere
    {
        public double a;
        public double b;
        public double Operatie(Func<Numere, double>function)
        {
            return function(this); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numere num = new Numere();
            num.a = 5;
            num.b = 10;
           Console.WriteLine( num.Operatie(
                x => { return x.a + x.b; }
                ));
        }
    }
}
