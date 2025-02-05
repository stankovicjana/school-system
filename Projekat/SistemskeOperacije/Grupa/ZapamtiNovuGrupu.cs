using Broker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Grupa
{
    public class ZapamtiNovuGrupu : OpstaSistemskaOperacija
    {
        public override object Izvrsi(Domen.IOpstiDomenskiObjekat odo)
        {

            Domen.Grupa g = odo as Domen.Grupa;
            g.GrupaID = BrokerBazePodataka.dajSesiju().VratiSifru(odo);
            BrokerBazePodataka.dajSesiju().IzmeniUslovPrimarni(g);
            BrokerBazePodataka.dajSesiju().Sacuvaj(g);
            foreach (Domen.Test t in g.Testovi)
            {
                t.TestID = BrokerBazePodataka.dajSesiju().VratiSifru(t);

                t.Grupa = new Domen.Grupa();
                t.Grupa.GrupaID = g.GrupaID; 
               
                
                BrokerBazePodataka.dajSesiju().Sacuvaj(t);
            }
         

            return g;
        }
    }
   
}
