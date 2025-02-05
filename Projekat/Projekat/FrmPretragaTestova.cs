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
    public partial class FrmPretragaTestova : Form
    {
        public FrmPretragaTestova()
        {
            InitializeComponent();
        }

        private void btnNadjiTest_Click(object sender, EventArgs e)
        {
            Kontroler.PretraziTest(cmbPolaznik, dgvPronadjeniTestovi);
            //if (Kontroler.PretraziTest(cmbPolaznik, dgvPronadjeniTestovi)) 
            //dgvPronadjeniTestovi.Columns[2].Visible = false;
            // dgvPronadjeniTestovi.Columns[3].Visible = false;
        }

        private void btnPrikaziTest_Click(object sender, EventArgs e)
        {
           
              if(  Kontroler.detaljiOTestu(dgvPronadjeniTestovi))
                
                new PrikaziTest().ShowDialog();
            
        }

        private void FrmPretragaTestova_Load(object sender, EventArgs e)
        {
            Kontroler.popuniComboPolaznik(cmbPolaznik);
        }
    }
}
