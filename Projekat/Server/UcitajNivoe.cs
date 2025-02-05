using Broker;
using Domen;
using SistemskeOperacije;
using System.Linq;

namespace Server
{
    public class UcitajNivoe : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            return BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Nivo>().ToList<Domen.Nivo>(); ;
        }
    }
    
}