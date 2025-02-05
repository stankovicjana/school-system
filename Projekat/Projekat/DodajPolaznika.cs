using Domen;
using KontrolerPoslovneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class DodajPolaznika : Form
    {
        Kontroler ko;
        
        public DodajPolaznika()
        {
            ko = new Kontroler();
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZapamtiNovogPolaznika(txtIme, txtPrezime, txtJMBG, txtTelefon, btnZenski))
            {
                dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            }
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtTelefon.Text = "";
            txtJMBG.Text = "";
            btnZenski.Checked = false;
            btnMuski.Checked = false;   
        }

        private void DodajPolaznika_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            
            

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (ko.detaljiOPolazniku(dataGridView1)) new PodaciOPolazniku().ShowDialog();
            dataGridView1.Columns["Dodaj"].Visible = false;
            dataGridView1.Refresh();
            dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            dataGridView1.Columns["Dodaj"].Visible = false;
            txtPretrazi.Text = "";

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (Kontroler.ObrisiPolaznika(dataGridView1)) { }
            dataGridView1.Refresh();
            dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            dataGridView1.Columns["Dodaj"].Visible = false;
            

        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
             ListtoDataTableConverter converter = new ListtoDataTableConverter();
             DataTable dt = converter.ToDataTable(Kontroler.UcitajPolaznike());
             DataView dataView = dt.DefaultView;
             dataView.RowFilter = "Ime like '" + txtPretrazi.Text + "%'";
             dataGridView1.DataSource = dataView;
             dataGridView1.Columns["PolaznikID"].Visible = false;
             dataGridView1.Columns["uslovOstalo3"].Visible = false;
             dataGridView1.Columns["izmena2"].Visible = false;
             dataGridView1.Columns["Grupa"].Visible = false;
             dataGridView1.Columns["nazivTabele"].Visible = false;
             dataGridView1.Columns["uslovPrimarni"].Visible = false;
             dataGridView1.Columns["uslovOstalo"].Visible = false;
             dataGridView1.Columns["unos"].Visible = false;
             dataGridView1.Columns["primarniKljuc"].Visible = false;
             dataGridView1.Columns["izmena"].Visible = false;
             dataGridView1.Columns["izvuci"].Visible = false;
             dataGridView1.Columns["uslovJoin"].Visible = false;
             dataGridView1.Columns["uslovOstalo2"].Visible = false;
            

        }
       
        public class ListtoDataTableConverter
        {
            public DataTable ToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                //put a breakpoint here and check datatable
                return dataTable;
            }
        }

      
    }
}
