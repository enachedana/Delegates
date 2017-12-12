using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    public delegate double Operatie();
    class douaNumere
    {
        public double x;
        public double y;
        public void Operatie(Operatie functie)
        {
           Console.WriteLine(functie());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            douaNumere no = new douaNumere();
            no.x = 5.213;
            no.y = 8442.121111;
            Operatie plus = () => { return no.x + no.y; };
            Operatie minus = () => { return no.x - no.y; };
            no.Operatie(plus);
            no.Operatie(minus);
            
            Console.ReadLine();

        }
    }
}
