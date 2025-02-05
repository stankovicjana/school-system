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
    public partial class FrmDodajGrupu : Form
    {
        public FrmDodajGrupu()
        {
            InitializeComponent();
        }

      

        private void btnZapamtiGrupu_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapmatiNovuGrupu(txtNazivGrupe, txtTermin, cmbKurs)) this.Close();


        }

        private void FrmDodajGrupu_Load(object sender, EventArgs e)
        {
            Kontroler.popuniComboKurs(cmbKurs);
            dgvPolaznici.DataSource = Kontroler.UcitajPolaznike();
        }
    }
}
