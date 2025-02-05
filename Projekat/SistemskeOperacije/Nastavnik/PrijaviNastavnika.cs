using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrijaviNastavnika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().VratiZaUslovOstalo(odo) as Domen.Nastavnik;
        }
    }
    
}
