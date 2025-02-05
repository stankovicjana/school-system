using Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
    public class ZapamtiRezultatTesta : OpstaSistemskaOperacija
    {
        public override object Izvrsi(Domen.IOpstiDomenskiObjekat odo)
        {
           
            Domen.Test t = odo as Domen.Test;
            foreach (Domen.Test test in t.Testovi)
            {
                test.TestID = BrokerBazePodataka.dajSesiju().VratiSifru(test);
                BrokerBazePodataka.dajSesiju().Sacuvaj(test);
            }
           // t.TestID = BrokerBazePodataka.dajSesiju().VratiSifru(odo);
            //BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(t);
            //BrokerBazePodataka.dajSesiju().Sacuvaj(t);

            return t;

          
        }
    }
   
}
