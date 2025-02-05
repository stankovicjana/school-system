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
    public partial class DodajTest : Form
    {
        public DodajTest()
        {
            InitializeComponent();
        }

        private void DodajTest_Load(object sender, EventArgs e)
        {

            KontrolerPoslovneLogike.Kontroler.popuniComboGrupe(cmbGrupa);


            /* DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn()
             {
                 DataSource = Kontroler.UcitajTestove(),
                 HeaderText = "Polaznik",
                 DataPropertyName ="Test",
                 ValueMember = "Polaznik",
                 DisplayMember="Polaznik"
             }; 

             dataGridView1.Columns.Add(cb);
             */



        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (Kontroler.ZakaziTest(dtpDatum,cmbGrupa)) this.Close();

        }
    }
}
