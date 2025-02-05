using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Grupa : IOpstiDomenskiObjekat
    { 
        Kurs kursID;
        //[Browsable(false)]
        public int GrupaID { get; set; }
        public string NazivGrupe { get; set; }
        public string Termin { get; set; }
        [Browsable(false)]
        public Kurs Kurs { get => kursID; set => kursID = value; }
        public int Kurs_ID { get { return Kurs.KursID; } }
        public string Izabrani_Kurs { get { return Kurs.NazivKursa; } }
        [Browsable(false)]
        public Nastavnik Nastavnik { get; set; }
        BindingList<Test> testovi;
       
        public override bool Equals(object obj)
        {
            return obj is Grupa g &&
                               GrupaID == g.GrupaID;
        }
        public Grupa()
        {
            testovi = new BindingList<Test>();
        }
        [Browsable(false)]
        public string uslovOstalo3 { get { return ""; } }
        [Browsable(false)]


        public string nazivTabele
        {
            get { return "Grupa"; }
        }
        [Browsable(false)]
        public string izmena2
        {
            get { return ""; }
        }
        [Browsable(false)]
        public string primarniKljuc
        {
            get
            {
                return "GrupaID";
            }
        }
        [Browsable(false)]
        public string uslovPrimarni
        {
            get { return "GrupaID=" + GrupaID; }
        }
        [Browsable(false)]
        public string uslovOstalo
        {
            get { return "NazivGrupa like '" + NazivGrupe + "%'"; }
        }
        [Browsable(false)]
        public string izmena
        {
            get { return " nazivGrupa= '" + NazivGrupe + "',termin='" + Termin + "', kurs= " + Kurs.KursID + " "; }
        }
        [Browsable(false)]
        public string unos
        {
            get { return "values (" + GrupaID + ",'" + NazivGrupe + "','" + Termin + "', " + Kurs.KursID +", "+Nastavnik.NastavnikID +")"; }
        }
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
        public IOpstiDomenskiObjekat procitaj(DataRow red)
        {
            Grupa g = new Grupa();
            g.GrupaID = Convert.ToInt32(red[0]);
            g.NazivGrupe = red[1].ToString();
            g.Termin = red[2].ToString();
            Kurs k = new Kurs();
            k.KursID = Convert.ToInt32(red[3]);
            g.Nastavnik = new Nastavnik();
            g.Nastavnik.NastavnikID = Convert.ToInt32(red[4]);
            g.Kurs = k;


            return g;
        }
        public BindingList<Polaznik> ListaPolaznika = new BindingList<Polaznik>();
        public BindingList<Polaznik> ListaUnetih = new BindingList<Polaznik>();
        public BindingList<Test> Testovi { get => testovi; set => testovi = value; }
        [Browsable(false)]

        public string uslovOstalo2
        {
            get
            {
                return "NazivGrupa like '" + NazivGrupe + "%'";
            }

        }
        public override string ToString()
        {
            return NazivGrupe;
        }
    }

    }

