using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//tomarzjarzynski.pl
namespace FabrykaAbstrakcyjnaHul
{
    class Program
    {
        static void Main(string[] args)
        {
            FabrykaAbstrakcyjna fabryka = new ChinskaFabryka();
            Klient Tomasz = new Klient(fabryka);
            Tomasz.SprawdzKolorKolek();

            Console.ReadLine();
        }
    }
}
