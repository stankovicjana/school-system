using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class PrikaziGrupu:OpstaSistemskaOperacija
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo)
        {
            Domen.Grupa g = odo as Domen.Grupa;
            g = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(g) as Domen.Grupa;
            g.Kurs = new Domen.Kurs();
            g.Kurs = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(g.Kurs) as Domen.Kurs;
           
            Domen.Test t = new Domen.Test();
            t.Grupa = g;
            
            List<Domen.Test> testovi = BrokerBazePodataka.dajSesiju().vratiSveZaUslovOstalo3(t).OfType<Domen.Test>().ToList<Domen.Test>();
            //List<Domen.Test> testovi = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(t) as List<Domen.Test>;
          
            /* (Domen.Test test in testovi)
               
            {
                test.Polaznik = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(test.Polaznik) as Domen.Polaznik;
                g.Testovi.Add(p);
            }*/

            foreach (Domen.Test test in testovi)
            {
                test.Polaznik = BrokerBazePodataka.dajSesiju().VratiZaUslovPrimarni(test.Polaznik) as Domen.Polaznik;
                g.ListaPolaznika.Add(test.Polaznik);
            }
            return g;
        }
    }
}
