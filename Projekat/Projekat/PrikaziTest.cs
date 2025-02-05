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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Projekat
{
    public partial class PrikaziTest : Form
    {
        public PrikaziTest()
        {
            InitializeComponent();
        }

        private void PrikaziGrupu_Load(object sender, EventArgs e)
        {
            try
            {
                Kontroler.UcitajTest(dtpDatum, txtRezultat, txtGrupa, txtPolaznik);
            }catch(Exception ex)
            {
                MessageBox.Show("Datum polaganja testa nije unet");
                return;
            }
        }
    }
}
