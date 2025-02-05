using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Test
{
   
    public class UcitajTestove : OpstaSistemskaOperacija
        {
            public override object Izvrsi(IOpstiDomenskiObjekat odo)
            {
                return BrokerBazePodataka.dajSesiju().vratiSveJoin(odo).OfType<Domen.Test>().ToList<Domen.Test>();

            }
        }

    
}
