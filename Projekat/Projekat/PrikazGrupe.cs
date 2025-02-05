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
    public partial class PrikazGrupe : Form
    {
       
        public PrikazGrupe()
        {
            InitializeComponent();
        }

        private void PrikazGrupe_Load(object sender, EventArgs e)
        {
            Kontroler.popuniComboKurs(cmbKurs);
            Kontroler.popuniComboPolaznik(cmbPolaznik); 
            Kontroler.PopuniPoljaGrupe(txtNazivGrupe, txtTermin, cmbKurs, dataGridView1);
            //Kontroler.Kreiraj(dataGridView1);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           Kontroler.DodajPolaznika(cmbPolaznik);
        }
         
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Kontroler.Obrisi(dataGridView1);

        }

        private void btnIzmeniGrupu_Click(object sender, EventArgs e)
        {
            Kontroler.IzmeniGrupu(txtNazivGrupe, txtTermin, cmbKurs);
        }

        
        
    }
}
