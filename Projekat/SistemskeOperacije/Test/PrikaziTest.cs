using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
    public class PrikaziTest : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Test test = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(odo) as Domen.Test;
            return test;
        }
    
    }
}
