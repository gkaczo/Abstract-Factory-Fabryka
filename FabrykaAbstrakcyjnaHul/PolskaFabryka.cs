using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjnaHul
{
    //UML Concrete Factory1
    public class PolskaFabryka:FabrykaAbstrakcyjna
    {
        public override Kolka WyprodukujKolka()
        {
            var kolka = new PolskieKolka();
            Console.WriteLine("Produkcja polskie kolka");
            kolka.Kolor = "white";
            return kolka;
        }
    }
}
