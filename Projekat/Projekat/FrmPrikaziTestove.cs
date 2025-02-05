using Domen;
using KontrolerPoslovneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmPrikaziTestove : Form
    {
        public FrmPrikaziTestove()
        {
            InitializeComponent();
        }

        private void FrmPrikaziTestove_Load(object sender, EventArgs e)
        {
            KontrolerPoslovneLogike.Kontroler.popuniComboGrupe(cmbGrupe);
            Kontroler.kreirajTest(dataGridView1);
        }

        private void btnDodajPolaznike_Click(object sender, EventArgs e)
        {

            Kontroler.popuniComboPolaznikIzGrupe(cmbPolaznik,cmbGrupe);

        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            //if (Kontroler.ZapamtiRezultateTesta(dtpDatum, txtRezultat, cmbGrupe, cmbPolaznik)) this.Close();

           Kontroler.DodajTest(txtRezultat, dtpDatum, cmbPolaznik, cmbGrupe);
        }

        private void btnZapamtiTestove_Click(object sender, EventArgs e)
        {
            //if (Kontroler.ZapamtiRezultateTesta(dtpDatum, txtRezultat, cmbGrupe, cmbPolaznik)) this.Close();
            if (Kontroler.ZapamtiRezultateTesta(cmbGrupe, cmbPolaznik)) this.Close();

        }


    }
}
