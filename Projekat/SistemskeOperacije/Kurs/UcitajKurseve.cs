using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Kurs
{
    public class UcitajKurseve : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Kurs>().ToList<Domen.Kurs>(); ;
        }

    }
}
