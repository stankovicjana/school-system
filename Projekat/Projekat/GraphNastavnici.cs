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
    public partial class GraphNastavnici : Form
    {
        public GraphNastavnici()
        {
            InitializeComponent();
            ConfigureChart5();
            ConfigureChart2();
            ConfigureChart3();
            ConfigureChart();
        }
        private void ConfigureChart5()
        {

            chart5.Series.Clear();
            chart5.ChartAreas.Clear();


            chart5.ChartAreas.Add(new ChartArea("Plata"));
            List<Nastavnik> nastavnici = Kontroler.UcitajNastavnike();

            int ukNastavnici = nastavnici.Count;

            int totalMales = 0;
            int veca = 0;
            foreach (Nastavnik nastavnik in nastavnici)
            {
                if (nastavnik.Pol == 0)
                {
                    if (nastavnik.Plata > averagePay())
                    {
                        veca++;
                    }
                    totalMales++;
                }

            }
           
            double passingPercentage = (double)veca / totalMales * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Iznad proseka", passingPercentage);
            series.Points.AddXY("Ispod proseka", 100 - passingPercentage);


            chart5.Series.Add(series);

        }
        private void ConfigureChart()
        {

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();


            chart1.ChartAreas.Add(new ChartArea("Plata"));
            List<Nastavnik> nastavnici = Kontroler.UcitajNastavnike();

            int ukNastavnici = nastavnici.Count;

            int totalMales = 0;
            int veca = 0;
            foreach (Nastavnik nastavnik in nastavnici)
            {
                if (nastavnik.Pol == 1)
                {
                    if (nastavnik.Plata > averagePay())
                    {
                        veca++;
                    }
                    totalMales++;
                }

            }

            double passingPercentage = (double)veca / totalMales * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Iznad proseka", passingPercentage);
            series.Points.AddXY("Ispod proseka", 100 - passingPercentage);


            chart1.Series.Add(series);

        }
        private void ConfigureChart2()
        {

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();


            chart2.ChartAreas.Add(new ChartArea("Plata"));
            List<Nastavnik> nastavnici = Kontroler.UcitajNastavnike();

            int ukNastavnici = nastavnici.Count;

            int totalMales = 0;
            int veca = 0;
            foreach (Nastavnik nastavnik in nastavnici)
            {
                if (nastavnik.Pol == 0)
                {
                    if (nastavnik.Plata > averagePay())
                    {
                        veca++;
                    }
                    totalMales++;
                }

            }

            double passingPercentage = (double)veca / ukNastavnici * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;
            series.Points.AddXY("Iznad proseka u odnosu na sve zaposlene", passingPercentage);
            series.Points.AddXY("Ispod proseka u odnosu na sve zaposlene", 100 - passingPercentage);


            chart2.Series.Add(series);

        }
        private void ConfigureChart3()
        {



            chart3.Series.Clear();
            chart3.ChartAreas.Clear();


            chart3.ChartAreas.Add(new ChartArea("Plata"));
            List<Nastavnik> nastavnici = Kontroler.UcitajNastavnike();

            int ukNastavnici = nastavnici.Count;

            int totalFemales = 0;
            int veca = 0;
            foreach (Nastavnik nastavnik in nastavnici)
            {
                if (nastavnik.Pol == 1)
                {
                    if (nastavnik.Plata > averagePay())
                    {
                        veca++;
                    }
                    totalFemales++;
                }

            }

            double passingPercentage = (double)veca / ukNastavnici * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Iznad proseka u odnosu na sve zaposlene", passingPercentage);
            series.Points.AddXY("Ispod proseka u odnosu na sve zaposlene", 100 - passingPercentage);


            chart3.Series.Add(series);

        }
        public double averagePay()
        {
            List<Nastavnik> nastavnici = Kontroler.UcitajNastavnike();
            int ukNastavnici = nastavnici.Count;
            double plataUk = 0;
            foreach(Nastavnik n in nastavnici)
            {
                plataUk += n.Plata;
            }

            return   plataUk/ukNastavnici;
        }
    }
}
