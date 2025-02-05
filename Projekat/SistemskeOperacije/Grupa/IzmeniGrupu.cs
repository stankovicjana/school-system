using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class IzmeniGrupu : OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Grupa g = odo as Domen.Grupa;
            BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(g);
            Domen.Test t = new Domen.Test();
            t.Grupa = g;
            
            BrokerBazePodataka.dajSesiju().ObrisiZaUslovOstalo(t);
            foreach (Domen.Test test in g.Testovi)
            {
                test.Grupa = g;
                test.TestID = BrokerBazePodataka.dajSesiju().VratiSifru(test);
                BrokerBazePodataka.dajSesiju().Sacuvaj(test);
            }
            return 1;
        }
    
    }
}
