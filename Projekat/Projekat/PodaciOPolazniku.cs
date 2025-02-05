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
    public partial class PodaciOPolazniku : Form
    {
        public PodaciOPolazniku()
        {
            InitializeComponent();
        }

        private void PodaciOPolazniku_Load(object sender, EventArgs e)
        {
            Kontroler.UcitajPolaznika(txtIme, txtPrezime, txtJMBG, txtBrojTel);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
           
            if (Kontroler.IzmeniPolaznika(txtIme, txtPrezime, txtJMBG, txtBrojTel) ) this.Visible = false;
            
        }
    }
}
