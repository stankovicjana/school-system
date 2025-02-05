using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Nivo:IOpstiDomenskiObjekat
    {
        public int NivoId { get; set; }
        public string NivoNaziv { get; set; }
        public string nazivTabele
        {
            get { return "Nivo"; }
        }
        public string primarniKljuc
        {
            get
            {
                return "NivoID";
            }
        }
        [Browsable(false)]
        public string izmena2
        {
            get { return ""; }
        }
        [Browsable(false)]
        public string uslovOstalo3 { get { return ""; } }
        public string uslovPrimarni
        {
            get { return "NivoID=" + NivoId; }
        }

        public string uslovOstalo
        {
            get { return null; }
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
        public string izmena
        {
            get { return null; }
        }

        public string unos
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovOstalo2 { get => throw new NotImplementedException(); }

        public IOpstiDomenskiObjekat procitaj(System.Data.DataRow red)
        {
            Nivo n = new Nivo();
            n.NivoId = Convert.ToInt32(red[0]);
            n.NivoNaziv = red[1].ToString();

            return n;
        }
        public override string ToString()
        {
            return NivoNaziv;
        }
    }
}
