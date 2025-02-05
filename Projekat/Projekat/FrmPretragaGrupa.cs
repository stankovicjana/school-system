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
    public partial class FrmPretragaGrupa : Form
    {
        public FrmPretragaGrupa()
        {
            InitializeComponent();
        }

        private void btnPronadjiGrupu_Click(object sender, EventArgs e)
        {
            //Kontroler.pretraziGrupe(txtNaziv, dataGridView1);

        }

        private void btnPrikaziGrupu_Click(object sender, EventArgs e)
        {
            if (Kontroler.detaljiOGrupi(dataGridView1)) new PrikazGrupe().ShowDialog();

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
