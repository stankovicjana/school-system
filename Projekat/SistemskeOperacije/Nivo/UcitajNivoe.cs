using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nivo
{
    public class UcitajNivoe : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Nivo>().ToList<Domen.Nivo>(); ;
        }
    }
   
}
