using KontrolerPoslovneLogike;
using System;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmPretragaPolaznika : Form
    {

        Kontroler ko;
        public FrmPretragaPolaznika()
        {
            ko = new Kontroler();
            InitializeComponent();
        }

        private void btnNadjiPolaznika_Click(object sender, EventArgs e)
        {
            ko.PretraziPolaznika(txtPrez, dgvPronadjeniPolaznici);
        }

        private void btnPrikaziPolaznika_Click(object sender, EventArgs e)
        {
            if (ko.detaljiOPolazniku(dgvPronadjeniPolaznici)) new PodaciOPolazniku().ShowDialog();
            
        }

        private void btnObrisiPolaznika_Click(object sender, EventArgs e)
        {
            if (Kontroler.ObrisiPolaznika(dgvPronadjeniPolaznici)) { }


        }
    }
}
