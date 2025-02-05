using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class ZapamtiRezultate : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            /* Domen.Grupa g = odo as Domen.Grupa;
             BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(g);
             Domen.Test t = new Domen.Test();
             t.Grupa = g;

             BrokerBazePodataka.dajSesiju().ObrisiZaUslovOstalo(t);*/
            Domen.Test t = odo as Domen.Test;
            foreach (Domen.Test test in t.Testovi)
            {

                BrokerBazePodataka.dajSesiju().IzmeniUslovOstalo(test);
            }
            return 1;
        }

    }
}
