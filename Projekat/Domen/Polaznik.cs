using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Polaznik : IOpstiDomenskiObjekat
    {

        [Browsable(false)]
        public int PolaznikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string Pol { get; set; }
        public string JMBG { get; set; }
        public int Telefon { get; set; }
        [Browsable(false)]
        public string uslovOstalo3 { get { return ""; } }
        [Browsable(false)]
        public string izmena2
        {
            get { return ""; }
        }
        [Browsable(false)]
        public Grupa Grupa { get; set; }    
        public bool Dodaj { get; set; } 

        [Browsable(false)]
        public string nazivTabele
        {
            get { return "Polaznik"; }
        }
        [Browsable(false)]
        public string primarniKljuc
        {
            get
            {
                return "PolaznikID";
            }
        }
        [Browsable(false)]
        public string uslovPrimarni
        {
            get { return "PolaznikID=" + PolaznikID; }
        }
        [Browsable(false)]
        public string uslovOstalo
        {
            get { return "Ime like '" + Ime + "%' or Prezime like '" + Prezime + "%'"; }
        }
        [Browsable(false)]
        public string izmena
        {
            get { return "PolaznikID= " + PolaznikID + ", Ime='" + Ime + "', Prezime='" + Prezime + "', Jmbg='" + JMBG + "', Telefon=" + Telefon+ ", Pol= '"+Pol+"'"; }
        }
        [Browsable(false)]
        public string unos
        {
            get { return "values (" + PolaznikID + ",'" + Ime + "','" + Prezime + "','" + JMBG + "'," + Telefon+",'"+ Pol+"')"; }
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
        [Browsable(false)]

        public string uslovOstalo2
        {
            //get { return "Ime like '" + Ime + "%' or Prezime like '" + Prezime + "%'"; }
            get { return "Dodaj == true"; }
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
       
   
        public IOpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Polaznik p = new Polaznik();
            p.PolaznikID = Convert.ToInt32(red[0]);
            p.Ime = red[1].ToString();
            p.Prezime = red[2].ToString();
            p.JMBG = red[3].ToString();
            p.Telefon = Convert.ToInt32(red[4]);
            p.Pol = Convert.ToString(red[5]);
           /* p.Grupa = new Grupa();
            p.Grupa.GrupaID = Convert.ToInt32(red[5]);
           */

            return p;
        }

        
    }
}
