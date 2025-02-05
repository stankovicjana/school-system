using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Test : IOpstiDomenskiObjekat
    {
       

        
        public int TestID { get; set; }
        public string Naziv_Grupe { get { return Grupa.NazivGrupe; } }
        public string Ime_Polaznika { get { return Polaznik.Ime + " " + Polaznik.Prezime; } }
        public string JMBG { get { return Polaznik.JMBG; } }
        //[Browsable(false)]
        public DateTime DatumPolaganjaTesta { get; set; }
        [Browsable(false)]
        public string DatumPolaganja { get; set; }
        //[Browsable(false)]
        public int RezultatTesta { get; set;}
        [Browsable(false)]
        public Polaznik Polaznik { get; set; }
        [Browsable(false)]
        public Grupa Grupa { get; set; }
        
        [Browsable(false)]
        public string primarniKljuc
        {
            get
            {
                return "TestID";
            }
        }
         public BindingList<Test> Testovi = new BindingList<Test>();
        public override bool Equals(object obj)
        {
            return obj is Test t &&
                    Polaznik.PolaznikID == t.Polaznik.PolaznikID 
                   ;
        }
        
        public BindingList<Test> ListaUnetih = new BindingList<Test>();
        [Browsable(false)]
        public string uslovPrimarni { get { return "Grupa=" + Grupa.GrupaID; } }
        [Browsable(false)]
        public string uslovOstalo2 {get{ return "TestID=" + TestID; } }
        [Browsable(false)]
        public string uslovOstalo { get { return "TestID=" + TestID;} }

        [Browsable(false)]
        public string uslovOstalo3 { get { return "Grupa=" + Grupa.GrupaID; } }



        [Browsable(false)]
        public string izmena {
            get { return "DatumPolaganjaTesta='" + DatumPolaganjaTesta +"'"; }
        }
        [Browsable(false)]
        public string izmena2
        {
            get { return "DatumPolaganjaTesta='" + DatumPolaganjaTesta + "'" +" ,RezultatTesta="+RezultatTesta+""; }
        }
        DateTime now = DateTime.ParseExact("2012-04-05", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        [Browsable(false)]
        public string unos { 
            get {
                return "values (" + TestID + ",'" + DatumPolaganjaTesta.ToString("yyyy-MM-dd") + "'," + RezultatTesta + ", " + Polaznik.PolaznikID + "," + Grupa.GrupaID + ")";
            
            } }
        [Browsable(false)]
        public string nazivTabele
        {

            get
            {
                return "Test";
            }
        }
        public override string ToString()
        {
            return Polaznik.Ime;

        }
        [Browsable(false)]
        public string uslovJoin { get { return "t join polaznik p on t.polaznik = p.polaznikID join grupa g on t.grupa = g.grupaID"; } }


        [Browsable(false)]
        public string izvuci { get { return "TestID, DatumPolaganjaTesta, RezultatTesta, Polaznik, Ime, Prezime, Pol, JMBG, GrupaID, NazivGrupa, Nastavnik"; } }



        [Browsable(false)]


        public BindingList<Polaznik> ListaPolaznika = new BindingList<Polaznik>();
       
        public string FindPersonById(int Id)
        {
            return ListaPolaznika.FirstOrDefault(p => p.PolaznikID == Id).Ime;
        }
        public IOpstiDomenskiObjekat procitaj(DataRow red)
        {
            Test pk = new Test();
            pk.TestID = Convert.ToInt32(red[0]);
            pk.DatumPolaganjaTesta = (DateTime)red[1];
            pk.RezultatTesta = Convert.ToInt32(red[2]);
            pk.Polaznik = new Polaznik();
            pk.Polaznik.PolaznikID = Convert.ToInt32(red[3]);
            pk.Polaznik.Ime= Convert.ToString(red[4]);
            pk.Polaznik.Prezime = Convert.ToString(red[5]);
            pk.Polaznik.Pol = Convert.ToString(red[6]);
            pk.Polaznik.JMBG = Convert.ToString(red[7]);
            pk.Grupa = new Grupa();

            pk.Grupa.GrupaID = Convert.ToInt32(red[8]);
            pk.Grupa.NazivGrupe = Convert.ToString(red[9]); 
            pk.Grupa.Nastavnik = new Nastavnik();
            pk.Grupa.Nastavnik.NastavnikID = Convert.ToInt32(red[10]);
            return pk;
        }

       
    }
}
