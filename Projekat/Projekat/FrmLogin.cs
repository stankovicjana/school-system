using Domen;
using KontrolerPoslovneLogike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (Kontroler.PoveziSeNaServer())
            {
                if (Kontroler.Login(txtKorisnickoIme, txtSifra))
                {
                    this.Hide();
                    Form1 forma = new Form1();
                    forma.ShowDialog();
                   


                   // this.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Neuspesno povezivanje na server!");
            }
        }
   

        private void FrmLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
