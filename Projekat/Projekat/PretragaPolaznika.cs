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
    public partial class PretragaPolaznika : Form
    {
        private DataTable stdDataTable = new DataTable();
        public PretragaPolaznika()
        {
            InitializeComponent();
        }

        private void PretragaPolaznika_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Kontroler.UcitajPolaznike();
            stdDataTable.Columns.Clear();
            

        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            
        }
    } 
}
