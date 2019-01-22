using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrykaAbstrakcyjnaHul
{
    //UML Client
    public class Klient
    {
        private Kolka _kolka;

        public Klient(FabrykaAbstrakcyjna fabrykaAbstrakcyjna)
        {
            _kolka = fabrykaAbstrakcyjna.WyprodukujKolka();
        }

        public void SprawdzKolorKolek()
        {
            Console.WriteLine(_kolka.Kolor);
        }
    }
}
