using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForma : Form
    {
        Server s;


        private Button btnPokreni;
        private Button btnZaustavi;
        public ServerForma()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                lblError.Text = "Server je pokrenut!";
                lblError.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Server ne moze biti ugasen!\nPostoje korisnici na sistemu!");
                return;
            }

            if (s.zaustaviServer())
            {
                lblError.Text = "Server nije pokrenut!";
                lblError.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
