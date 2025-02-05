using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Nastavnik : IOpstiDomenskiObjekat
    {
        public int NastavnikID { get; set; }
        public string Ime { get; set; }
        public string Username { get; set; }
        public string Pass { get ; set; }
        public string Prezime { get; set; }
        public int Pol { get; set; }
        public double Plata { get; set; }

        public int Telefon { get; set; }
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
        public string nazivTabele
        {
            get { return "Nastavnik"; }
        }
        public string primarniKljuc
        {
            get
            {
                return "NastavnikID";
            }
        }
        public string uslovPrimarni
        {
            get { return "NastavnikID=" + NastavnikID; }
        }

        public string uslovOstalo
        {
            get { return "Username='" + Username + "' and Password='" + Pass + "'"; }
        }

        public string izmena
        {
            get { return null; }
        }

        public string unos
        {
            get { return " values(" + NastavnikID + ",'" + Ime + "','" + Prezime + "','" + Username + "','" + Pass + "'," + ")"; }
        }
        [Browsable(false)]

        public string uslovOstalo2
        {
            get { return "Username='" + Username + "' and Password='" + Pass + "'"; }
        }

        public IOpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Nastavnik n= new Nastavnik();
            n.NastavnikID = Convert.ToInt32(red[0]);
            n.Ime = red[1].ToString();
            n.Prezime = red[2].ToString();
            n.Pol = Convert.ToInt32(red[3]);
            n.Plata = Convert.ToDouble(red[4]);
            n.Telefon = Convert.ToInt32(red[5]);
            n.Username = Convert.ToString(red[6]);  
            n.Pass = Convert.ToString(red[7]);  

            return n;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
