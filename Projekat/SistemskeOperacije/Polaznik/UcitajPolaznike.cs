using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Polaznik
{
    public class UcitajPolaznike : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Polaznik>().ToList<Domen.Polaznik>(); 
        }
    }

   
        
    
}
