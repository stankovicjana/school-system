using Domen;
using Komunikacija;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            lblPoruka.Text = "Server je pokrenut!";
            lblPoruka.ForeColor = Color.Green;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnKrajRada_Click(object sender, EventArgs e)
        {
            Kontroler.End();
            this.Dispose();
        }

        private void prikaziPolaznikeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //new FrmPrikaziPolaznike().ShowDialog();
        }

        private void dodajPolaznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DodajPolaznika().ShowDialog();
        }

       

        private void prikaziTestoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DodajRezultate().ShowDialog();
            this.Show();
        }

        private void pretraziPolaznikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretragaPolaznika().ShowDialog();
            this.Show();
        }

        private void dodajKursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new UnosGrupe().ShowDialog();
            new FrmDodajGrupu().ShowDialog();

            this.Show();

        }

        private void pretraziGrupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPretragaGrupa().ShowDialog();
            this.Show();
        }

        private void dodajTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DodajTest().ShowDialog();
        }

        private void novaGrupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new UnosGrupe().ShowDialog();
            new DodajGrupu().ShowDialog();

            this.Show();
        }

        private void prikaziPolaznikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new DodajPolaznika().ShowDialog();
        }

        private void grupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void kurseviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UnosKursa().ShowDialog();
            this.Show();
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void polazniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Graph().ShowDialog();
            this.Show();
        }

        private void nastavniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GraphNastavnici().ShowDialog();
            this.Show();
        }

        private void izmenaPolaznikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IzmeniPolaznika().ShowDialog();
        }

        private void dodajPolaznikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new DodajPolaznika().ShowDialog();
        }

        private void dodajGrupuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new DodajGrupu().ShowDialog();
            this.Show();
        }

        private void izmeniGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PretraziGrupe().ShowDialog();
            this.Show();
        }

        private void uspehNastavnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GraphResults().ShowDialog();
            this.Show();

        }
    }
}
