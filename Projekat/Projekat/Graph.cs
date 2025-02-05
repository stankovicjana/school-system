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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();

            //ConfigureChart();
            ConfigureChart3();
            ConfigureChart2();
           
            ConfigureChart4();  
         
        }

      /* private void ConfigureChart()
        {
            
            
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            
            
            chart1.ChartAreas.Add(new ChartArea("Rezultati"));

            
            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Bar;
            List<Test> testovi = Kontroler.UcitajTestove();
            
            foreach (var result in testovi)
            {
                series.Points.AddXY(result.Ime_Polaznika, result.RezultatTesta);
            }

            
            chart1.Series.Add(series);
        }
      */

        private void ConfigureChart2()
        {
            
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();

         
            chart2.ChartAreas.Add(new ChartArea("Rezultati"));
            List<Test> testovi = Kontroler.UcitajTestove();
           
            int totalStudents = testovi.Count;
            int boolPolozio = 0;
            foreach(Test test in testovi)
            {
                if(test.RezultatTesta > 50)
                {
                    boolPolozio++;  
                }
            }
           
            double passingPercentage = (double)boolPolozio / totalStudents * 100;

          
            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Polozio", passingPercentage);
            series.Points.AddXY("Pao", 100 - passingPercentage);

            
            chart2.Series.Add(series);
        }
        private void ConfigureChart3()
        {
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();


            chart3.ChartAreas.Add(new ChartArea("Rezultati muškog pola"));
            List<Test> testovi = Kontroler.UcitajTestove();

            int totalStudents = testovi.Count;
            int totalMales = 0;
            int boolPolozio = 0;
            foreach (Test test in testovi)
            {
                if (test.Polaznik.Pol == "Muški")
                {
                    if (test.RezultatTesta > 50 )
                    {
                        boolPolozio++;
                    }
                    totalMales++;
                }
              
            }

            double passingPercentage = (double)boolPolozio / totalMales * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Polozio", passingPercentage);
            series.Points.AddXY("Pao", 100 - passingPercentage);


            chart3.Series.Add(series);

        }
        private void ConfigureChart4()
        {

            chart4.Series.Clear();
            chart4.ChartAreas.Clear();


            chart4.ChartAreas.Add(new ChartArea("Rezultati ženskog pola"));
            List<Test> testovi = Kontroler.UcitajTestove();

            int totalStudents = testovi.Count;
            int totalfemales = 0;
            int boolPolozio = 0;
            foreach (Test test in testovi)
            {
                if (test.Polaznik.Pol == "Ženski")
                {
                    if (test.RezultatTesta > 50)
                    {
                        boolPolozio++;
                    }
                    totalfemales++;
                }

            }

            double passingPercentage = (double)boolPolozio / totalfemales * 100;


            Series series = new Series("Rezultati");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("Polozio", passingPercentage);
            series.Points.AddXY("Pao", 100 - passingPercentage);


            chart4.Series.Add(series);

        }
        
    }
}
