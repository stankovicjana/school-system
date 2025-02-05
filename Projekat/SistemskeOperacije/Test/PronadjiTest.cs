using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
    public class PronadjiTest : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {

            List<Domen.Test> lista = BrokerBazePodataka.dajSesiju().vratiSveZaUslovOstalo3(odo).OfType<Domen.Test>().ToList<Domen.Test>();
            return lista;
        }
    }
   
}
