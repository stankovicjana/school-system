using Broker;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Kurs
{
    public class ZapamtiNoviKurs:OpstaSistemskaOperacija
    {
        public override object Izvrsi(Domen.IOpstiDomenskiObjekat odo)
        {

            Domen.Kurs k = odo as Domen.Kurs;
            k.KursID = BrokerBazePodataka.dajSesiju().VratiSifru(odo);
            BrokerBazePodataka.dajSesiju().Sacuvaj(k);
            /*foreach (Domen.Polaznik pk in k.ListaPolaznika)
            {
                pk.Kurs = k.KursID;
                BrokerBazePodataka.dajSesiju().Sacuvaj(pk);
            }*/
            return k;
        }
    }
}
