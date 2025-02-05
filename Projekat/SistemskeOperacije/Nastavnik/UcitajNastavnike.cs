using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Nastavnik
{
    public class UcitajNastavnike : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            List<Domen.Nastavnik> lista = BrokerBazePodataka.dajSesiju().vratiSve(odo).OfType<Domen.Nastavnik>().ToList<Domen.Nastavnik>();

            /*foreach (Domen.Nastavnik p in lista)
            {
                p.Jezik = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(p.Jezik) as Jezik;

            }*/

            return lista;
        }
    }
}
