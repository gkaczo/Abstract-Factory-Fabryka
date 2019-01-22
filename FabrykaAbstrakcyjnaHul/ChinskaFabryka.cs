using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjnaHul
{
    //UML Concrete Factory1
    public class ChinskaFabryka:FabrykaAbstrakcyjna
    {
        public override Kolka WyprodukujKolka()
        {
            var kolka = new ChinskieKolka();
            Console.WriteLine("Produkcja chinskie kolka");
            kolka.Kolor = "black";
            return kolka;
        }
    }
}
