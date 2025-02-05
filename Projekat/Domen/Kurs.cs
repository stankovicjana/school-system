using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Kurs:IOpstiDomenskiObjekat
    {
        public int KursID{ get; set; }
        public string NazivKursa { get; set; }
        public double Cena { get; set; }
        public Nastavnik Nastavnik { get; set; }    
        public Jezik Jezik { get; set; }
        public Nivo Nivo { get;set; }
        public override string ToString()
        {
            return NazivKursa;
        }
        [Browsable(false)]
        public string izmena2
        {
            get { return ""; }
        }
        [Browsable(false)]
        public string uslovOstalo3 { get { return ""; } }
        [Browsable(false)]
        public string izvuci
        {
            get { return ""; }
        }
        [Browsable(false)]
        public string uslovJoin
        {
            get
            {
                return "";
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Kurs kurs &&
                               KursID == kurs.KursID;
        }
        public string nazivTabele
        {
            get { return "Kurs"; }
        }
        [Browsable(false)]
        public string primarniKljuc
        {
            get
            {
                return "KursID";
            }
        }
        //[Browsable(false)]
        public string uslovPrimarni
        {
            get { return "KursID=" + KursID; }
        }
        [Browsable(false)]
        public string uslovOstalo
        {
            get { return "Naziv like '" + NazivKursa + "%'"; }
        }
        [Browsable(false)]
        public string izmena
        {
            get { return " naziv= '" + NazivKursa + "',datumPocetka= '"  + "',cena=" + Cena + ", nastavnikID= " + Nastavnik.NastavnikID + ", jezikID= " + Jezik.JezikID + "+ ,nivo=" +Nivo.NivoId + " "; }
        }
        [Browsable(false)]
        public string unos
        {
            get { return "values (" + KursID + "," + Cena + ", '" + NazivKursa + "',"  + Nastavnik.NastavnikID + ", " + Jezik.JezikID + ","+Nivo.NivoId  + ")"; }
        }
        [Browsable(false)]

        public string uslovOstalo2
        {
            get
            {
                return "Naziv like '" + NazivKursa + "%'";
            }
        }

        //public BindingList<Polaznik> ListaPolaznika { get ; set; }

        public IOpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Kurs k = new Kurs();
            k.KursID = Convert.ToInt32(red[0]);
            
            k.NazivKursa = red[2].ToString();
            k.Cena = Convert.ToDouble(red[1]);
            k.Jezik = new Jezik();
            k.Jezik.JezikID = Convert.ToInt32(red[4]);
            k.Nastavnik = new Nastavnik();
            k.Nastavnik.NastavnikID = Convert.ToInt32(red[3]);
            k.Nivo = new Nivo();
            k.Nivo.NivoId = Convert.ToInt32(red[5]);


            return k;
        }

    }
}
