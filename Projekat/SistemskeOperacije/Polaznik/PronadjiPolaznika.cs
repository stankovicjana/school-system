using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PronadjiPolaznika : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {

            List<Domen.Polaznik> lista = BrokerBazePodataka.dajSesiju().vratiSveZaUslovOstalo(odo).OfType<Domen.Polaznik>().ToList<Domen.Polaznik>();
            return lista;
        }
    }

    
    
}
