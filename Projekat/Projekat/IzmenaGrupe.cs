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
    public partial class IzmenaGrupe : Form
    {
        public IzmenaGrupe()
        {
            InitializeComponent();
        }

        private void btnIzmeniGrupu_Click(object sender, EventArgs e)
        {
            if(Kontroler.IzmeniGrupu(txtNazivGrupe, txtTermin, cmbKurs))
                this.Visible = false;
            dataGridView1.Refresh();
            
        }

        private void IzmenaGrupe_Load(object sender, EventArgs e)
        {
            Kontroler.popuniComboKurs(cmbKurs);
            Kontroler.PopuniPoljaGrupe(txtNazivGrupe, txtTermin, cmbKurs, dataGridView1);

            dataGridView1.Columns["Dodaj"].Visible = false;

           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Kontroler.ObrisiPolaznikaIzTestova(dataGridView1);
            dataGridView1.Refresh();    
        }
    }
}
