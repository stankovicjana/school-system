using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
    public class ZapamtiRezultateTesta : OpstaSistemskaOperacija
    
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Test t = odo as Domen.Test;
            foreach (Domen.Test test in t.Testovi)
            {
                test.TestID = BrokerBazePodataka.dajSesiju().VratiSifru(test);
                //test.Grupa = t.Grupa;

                BrokerBazePodataka.dajSesiju().Sacuvaj(test);

            }
            return t;
        }

          
    }
}
