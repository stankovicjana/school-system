using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class DodajPolaznika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Polaznik p = odo as Domen.Polaznik;
            p.PolaznikID = BrokerBazePodataka.dajSesiju().VratiSifru(odo);
            BrokerBazePodataka.dajSesiju().Sacuvaj(p);
            return p;
        }
    }
}
