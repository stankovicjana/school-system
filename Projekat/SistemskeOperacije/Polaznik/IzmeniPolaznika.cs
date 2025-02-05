using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Polaznik
{
    public class IzmeniPolaznika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Polaznik p = odo as Domen.Polaznik;
            BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(p);
           
            return 1;
        }
    
    }
}
