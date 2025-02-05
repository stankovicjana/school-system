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
    public partial class UnosKursa : Form
    {
        public UnosKursa()
        {
            InitializeComponent();
        }

        private void btnZapamtiKurs_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapmatiNoviKurs(txtNazivK, txtCenaK, cmbNastavnik, cmbJezik, cmbNivo)) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UnosKursa_Load(object sender, EventArgs e)
        {
           // Kontroler.KreirajKurs(dataGridView1);
            Kontroler.popuniComboJezik(cmbJezik);
            Kontroler.popuniComboNastavnik(cmbNastavnik);
            //Kontroler.popuniComboPolaznik(cmbPolaznik);
            Kontroler.popuniComboNivo(cmbNivo);

        }

      
    }
}
