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
    public partial class UnosGrupe : Form
    {
        public UnosGrupe()
        {
            InitializeComponent();
        }

        private void btnZapamtiGrupu_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapmatiNovuGrupu(txtNazivGrupe, txtTermin, cmbKurs)) this.Close();
        }

        private void UnosGrupe_Load(object sender, EventArgs e)
        {
            Kontroler.KreirajGrupu(dataGridView1);
            Kontroler.popuniComboKurs(cmbKurs);
            Kontroler.popuniComboPolaznik(cmbPolaznik);
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kontroler.DodajPolaznika(cmbPolaznik);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kontroler.Obrisi(dataGridView1);
        }

     
    }
}
