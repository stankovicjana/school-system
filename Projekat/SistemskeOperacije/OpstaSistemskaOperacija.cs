using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        public Object izvrsiSO(IOpstiDomenskiObjekat odo)
        {
            Object rezultat = null;
            BrokerBazePodataka.dajSesiju().otvoriKonekciju();
            BrokerBazePodataka.dajSesiju().zapocniTransakciju();
            try
            {
                rezultat = Izvrsi(odo);
                BrokerBazePodataka.dajSesiju().potvrdiTransakciju();
            }
            catch (Exception)
            {

                BrokerBazePodataka.dajSesiju().ponistiTransakciju();
            }
            finally
            {
                BrokerBazePodataka.dajSesiju().zatvoriKonekciju();
            }

            return rezultat;
        }

        public abstract object Izvrsi(IOpstiDomenskiObjekat odo);


    }
}
