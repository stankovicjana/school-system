using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class PronadjiGrupe: OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Domen.Grupa>().ToList<Domen.Grupa>();
        }
    
    }
}
