using Domen;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekat
{
    public partial class GraphResults : Form
    {
        public GraphResults()
        {
            InitializeComponent();
            Kontroler.popuniComboNastavnik(cmbNastavnik);

        }
        public void ConfigureChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();


            chart1.ChartAreas.Add(new ChartArea("Rezultati"));


            Series series = new Series("Uspeh nastavnika");
            

            List<Test> testovi = Kontroler.UcitajTestove();
            Nastavnik nastavnik = cmbNastavnik.SelectedItem as Nastavnik;
            double totalScore = 0;
            double averageScore = 0;
            int brojac = 0;
            foreach (var result in testovi)
            {
                if(result.Grupa.Nastavnik.NastavnikID == nastavnik.NastavnikID)
                {
                    totalScore += result.RezultatTesta;
                    brojac++;
                }
               
            }
            chart1.Visible = true;

            averageScore = totalScore / brojac;
            series.Points.AddXY("Položili",averageScore );
            series.Points.AddXY("Pali", 100-averageScore);
            //series.Points.AddXY("Nisu polozili", 100-averageScore);

            lblUspesnost.Text = averageScore.ToString();    
            series.ChartType = SeriesChartType.Doughnut;
            chart1.Series.Add(series);
        }
      

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            ConfigureChart();
            ConfigureChart2();

        }

        private void ConfigureChart2()
        {
            /*chart2.Series.Clear();
            chart2.ChartAreas.Clear();

            chart2.ChartAreas.Add(new ChartArea("Rezultati svih polaznika"));


            Series series = new Series("Uspeh nastavnika");
           
            List<Test> testovi = Kontroler.UcitajTestove();
            Nastavnik nastavnik = cmbNastavnik.SelectedItem as Nastavnik;
            
            foreach (var result in testovi)
            {
                if(result.Grupa.Nastavnik.NastavnikID == nastavnik.NastavnikID)
                {
                    series.Points.AddXY(result.Ime_Polaznika, result.RezultatTesta);
                }
                
            }

            
            series.ChartType = SeriesChartType.Line;
            chart2.Series.Add(series);
            */

            /////////////////
            ///
            /// 
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();


            chart2.ChartAreas.Add(new ChartArea("Rezultati"));


            Series series = new Series("Rezultati svih polaznika");
            
            List<Test> testovi = Kontroler.UcitajTestove();
            Nastavnik nastavnik = cmbNastavnik.SelectedItem as Nastavnik;
            foreach (var result in testovi)
            {
                if(result.Grupa.Nastavnik.NastavnikID == nastavnik.NastavnikID)
                series.Points.AddXY(result.Ime_Polaznika, result.RezultatTesta);
            }
            chart2.Visible = true;

            series.ChartType = SeriesChartType.Bubble;
            chart2.Series.Add(series);
        }

        private void GraphResults_Load(object sender, EventArgs e)
        {

        }
    }
}
