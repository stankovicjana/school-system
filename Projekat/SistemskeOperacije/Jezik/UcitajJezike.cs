using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Jezik
{
    public class UcitajJezike : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Jezik>().ToList<Domen.Jezik>(); ;
        }
    }
    
    
}
