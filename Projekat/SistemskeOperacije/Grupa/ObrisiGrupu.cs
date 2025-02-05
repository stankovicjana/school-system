using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class ObrisiGrupu : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().ObrisiZaUslovPrimarni(odo);
        }
    
    }
}
