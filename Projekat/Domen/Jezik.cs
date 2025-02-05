using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Jezik:IOpstiDomenskiObjekat
    {
        public int JezikID { get; set; }
        public string JezikNaziv { get; set; }
        public string nazivTabele
        {
            get { return "Jezik"; }
        }
        [Browsable(false)]
        public string izmena2
        {
            get { return ""; }
        }
        public override string ToString()
        {
            return JezikNaziv;
        }
        [Browsable(false)]
        public string uslovOstalo3 { get { return ""; } }
        public string primarniKljuc
        {
            get
            {
                return "JezikID";
            }
        }
        public string uslovPrimarni
        {
            get { return "JezikID=" + JezikID; }
        }

        public string uslovOstalo
        {
            get { return null; }
        }

        public string izmena
        {
            get { return null; }
        }

        public string unos
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovOstalo2 { get => throw new NotImplementedException();  }
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
        public IOpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Jezik j = new Jezik();
            j.JezikID = Convert.ToInt32(red[0]);
            j.JezikNaziv = red[1].ToString();

            return j;
        }
    }
}
