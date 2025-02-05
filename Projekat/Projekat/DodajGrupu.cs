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
using static Projekat.DodajPolaznika;

namespace Projekat
{
    public partial class DodajGrupu : Form
    {
        public DodajGrupu()
        {
            InitializeComponent();
        }

        private void DodajGrupu_Load(object sender, EventArgs e)
        {
          
            Kontroler.popuniComboKurs(cmbKurs);
            dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            dataGridView2.DataSource = Kontroler.UcitajGrupe();
            dataGridView2.Columns["Izabrani_Kurs"].Visible = false;
            
        }

        private void btnZapamtiGrupu_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapmatiNovuGrupu(txtNazivGrupe, txtTermin, cmbKurs, dataGridView1)) this.Close();
           

        }

        private void btnPrikaziGrupu_Click(object sender, EventArgs e)
        {
            if (Kontroler.detaljiOGrupi(dataGridView2)) new IzmenaGrupe().ShowDialog();
            dataGridView2.Refresh();
            dataGridView2.DataSource = Kontroler.UcitajGrupe();
        }

      
        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(Kontroler.UcitajGrupe());
            DataView dataView = dt.DefaultView;
            dataView.RowFilter = "NazivGrupe like '" + txtPretrazi.Text + "%'";
            dataGridView2.DataSource = dataView;
           
            dataGridView2.Columns["GrupaID"].Visible = false;
            dataGridView2.Columns["Kurs"].Visible = false;
            dataGridView2.Columns["uslovOstalo2"].Visible = false;
            dataGridView2.Columns["uslovOstalo3"].Visible = false;
            dataGridView2.Columns["nazivTabele"].Visible = false;
            dataGridView2.Columns["izmena2"].Visible = false;
            dataGridView2.Columns["primarniKljuc"].Visible = false;
            dataGridView2.Columns["uslovPrimarni"].Visible = false; 
            dataGridView2.Columns["uslovOstalo"].Visible = false;
            dataGridView2.Columns["izmena"].Visible = false;
            dataGridView2.Columns["unos"].Visible = false;
            dataGridView2.Columns["izvuci"].Visible = false;
            dataGridView2.Columns["uslovJoin"].Visible = false;
            dataGridView2.Columns["Testovi"].Visible = false;

        }
    }
}
