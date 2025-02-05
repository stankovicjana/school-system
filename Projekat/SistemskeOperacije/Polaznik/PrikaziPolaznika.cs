using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrikaziPolaznika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Polaznik clan = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(odo) as Domen.Polaznik;
            return clan;
        }
    }
}
