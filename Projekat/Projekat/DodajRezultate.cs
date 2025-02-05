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
    public partial class DodajRezultate : Form
    {
        public DodajRezultate()
        {
            InitializeComponent();
        }

        private void DodajRezultate_Load(object sender, EventArgs e)
        {
            Kontroler.popuniComboGrupe(cmbGrupe);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapamtiRezultateTesta(dataGridView1)) this.Close();

        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(Kontroler.UcitajTestove());
            DataView dataView = dt.DefaultView;
            dataView.RowFilter = "Ime_Polaznika like '" + txtPretrazi.Text + "%'";
            dataGridView1.DataSource = dataView;
            dataGridView1.Columns["TestID"].Visible = false;
            dataGridView1.Columns["DatumPolaganja"].Visible = false;
            dataGridView1.Columns["Polaznik"].Visible = false;
            dataGridView1.Columns["Grupa"].Visible = false;
            dataGridView1.Columns["primarniKljuc"].Visible = false;
            dataGridView1.Columns["uslovPrimarni"].Visible = false;
            dataGridView1.Columns["uslovOstalo2"].Visible = false;
            dataGridView1.Columns["uslovOstalo"].Visible = false;
            dataGridView1.Columns["uslovOstalo3"].Visible = false;
            dataGridView1.Columns["uslovOstalo"].Visible = false;
            dataGridView1.Columns["izmena"].Visible = false;
            dataGridView1.Columns["izmena2"].Visible = false;
            dataGridView1.Columns["unos"].Visible = false;
            dataGridView1.Columns["nazivTabele"].Visible = false;
            dataGridView1.Columns["uslovJoin"].Visible = false;
            dataGridView1.Columns["izvuci"].Visible = false;


        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Kontroler.PretraziTest(cmbGrupe, dataGridView1);
            dataGridView1.Columns["TestID"].Visible=false;
        }
    }
}
