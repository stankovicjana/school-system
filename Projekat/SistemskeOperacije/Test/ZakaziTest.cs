using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
    public class ZakaziTest : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Test test = odo as Domen.Test;
            BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(test);
            
            return test;
        }

    }
}
