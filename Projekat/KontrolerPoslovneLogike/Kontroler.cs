using Domen;
using Komunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KontrolerPoslovneLogike
{
    public class Kontroler
    {
        public static Komunkacija komunikacija;

        public static Kurs kurs = new Kurs();
        public static Nastavnik n;
        public static Polaznik p;
        public static Grupa grupa = new Grupa();
        public static Grupa polaznik = new Grupa();
        public static Test t = new Test();
        public static Test testovi = new Test();
        public static Test pk = new Test();
        public static Test testoviRez = new Test();
        public static bool Login(TextBox txtUsername, TextBox txtPass)
        {
            n = new Nastavnik();
            n.Username = txtUsername.Text;
            n.Pass = txtPass.Text;

            n = komunikacija.Login(n) as Nastavnik;

            if (n == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje nastavnika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspesno prijavio nastavnika!");
                return true;
            }
        }

        public static bool ObrisiPolaznika(DataGridView dgvPronadjeniPolaznici)
        {

            Object obj;
            Polaznik o = new Polaznik();    
            try
            {
                o = dgvPronadjeniPolaznici.SelectedRows[0].DataBoundItem as Polaznik;
              
                if (o == null)
                {
                    DataRowView drv = dgvPronadjeniPolaznici.SelectedRows[0].DataBoundItem as DataRowView;


                    if (drv != null)
                    {
                        DataRow row = drv.Row;

                        // Now get the respective column value say PersonId and assuming PersonId is a column in the bounded DataView

                        if (row != null)
                        {
                            o = new Polaznik();
                            var personId = row["PolaznikID"];
                            var ime = row["Ime"];
                            var prezime = row["Prezime"];
                            var pol = row["Pol"];
                            var jmbg = row["JMBG"];
                            var telefon = row["telefon"];
                            o.PolaznikID = Convert.ToInt32(personId);
                            o.Ime = (string)ime;
                            o.Prezime = (string)prezime;
                            o.Pol = Convert.ToString(pol);
                            o.JMBG = (string)jmbg;
                            o.Telefon = Convert.ToInt32(telefon);
                            
                        }
                    }

                }
            }
            finally
            {
                obj = komunikacija.ObrisiPolaznika(o);

            }
            
                if (obj == null)
                {
                    MessageBox.Show("Sistem ne može da obrise izabranog člana!");
                    return false;
                }
                else
                {
                    Osvezi(dgvPronadjeniPolaznici);
                    MessageBox.Show("Sistem je obrisao izabranog člana!");
                    return true;
                }
            

               
            
            }
        public static void Osvezi(DataGridView dgvPronadjeniPolaznici)
        {

            List<Polaznik> lista = komunikacija.PronadjiPolaznike(p);
            dgvPronadjeniPolaznici.DataSource = lista;
        }

        public static bool PoveziSeNaServer()
        {
            if (komunikacija == null) komunikacija = new Komunikacija.Komunkacija();
            return komunikacija.poveziSeNaServer();
        }

        public static void UcitajPolaznika(TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrojTel)
        {
            txtIme.Text = p.Ime;
            txtPrezime.Text = p.Prezime;
            txtJMBG.Text = p.JMBG;
            txtBrojTel.Text = p.Telefon.ToString();

            p = komunikacija.PrikaziPolaznika(p);
        }

        public static bool ZapamtiNovogPolaznika(TextBox txtIme, TextBox txtPrez, TextBox txtJMBG, TextBox txtTelefon, RadioButton btnZenski)
        {
            p = new Polaznik();
            p.Ime = txtIme.Text;
            if (string.IsNullOrEmpty(p.Ime))
            {
                MessageBox.Show("Nije uneto ime!");
                return false;
            }

            p.Prezime = txtPrez.Text;
            if (string.IsNullOrEmpty(p.Prezime))
            {
                MessageBox.Show("Nije uneto prezime!");
                return false;
            }
            p.JMBG = txtJMBG.Text;
            try
            {
                long a = Convert.ToInt64(p.JMBG
                    );
            }
            catch (Exception)
            {

                MessageBox.Show("JMBG nije ispravno unet!");
                return false;
            }
            if (p.JMBG.Length != 13)
            {
                MessageBox.Show("JMBG nije ispravno unet!");
                return false;
            }
            p.Telefon = Convert.ToInt32
                (txtTelefon.Text);
            
            if (btnZenski.Checked)
            {
                p.Pol = "Ženski";
            }else
            {
                p.Pol= "Muški";   
            }
            p.Grupa = null;
            try
            {
                long a = Convert.ToInt64(txtTelefon.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Broj telefona nije ispravno unet! ");
                return false;
            }


            Object rez = komunikacija.ZapamtiNovogPolaznika(p);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti člana!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio unetog člana!");
                return true;
            }



        }

        public bool detaljiOPolazniku(DataGridView dgvPronadjeniPolaznici)
        {

            try
            {
                p = dgvPronadjeniPolaznici.SelectedRows[0].DataBoundItem as Polaznik;
                if (p==null)
                {
                    DataRowView drv = dgvPronadjeniPolaznici.SelectedRows[0].DataBoundItem as DataRowView;


                    if (drv != null)
                    {
                        DataRow row = drv.Row;

                        // Now get the respective column value say PersonId and assuming PersonId is a column in the bounded DataView

                        if (row != null)
                        {
                            p = new Polaznik();
                            var personId = row["PolaznikID"];
                            var ime = row["Ime"];
                            var prezime = row["Prezime"];
                            var pol = row["Pol"];
                            var jmbg = row["JMBG"];
                            var telefon = row["telefon"];
                            p.PolaznikID = Convert.ToInt32(personId);
                            p.Ime = (string)ime;
                            p.Prezime = (string)prezime;
                            p.Pol = Convert.ToString(pol);
                            p.JMBG = (string)jmbg;
                            p.Telefon = Convert.ToInt32(telefon);
                        }
                    }

                }
                
                return true;
            }
            catch (Exception)
            {


                MessageBox.Show("Niste odabrali člana za prikaz! ");
                return false;
            }
        }

        public void PretraziPolaznika(TextBox txtPrez, DataGridView dgvPronadjeniPolaznici)
        {
            Polaznik polaznik = new Polaznik();
            polaznik.Prezime = txtPrez.Text;
            polaznik.Ime = txtPrez.Text;
            List<Polaznik> lista = komunikacija.PronadjiPolaznike(polaznik);

            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moče da nadje člana po zadatoj vrednosti. ");
            }
            else
            {
                dgvPronadjeniPolaznici.DataSource = lista;
                MessageBox.Show("Sistem je pronašao člana. ");
            }
        }

        public static bool ZapmatiNoviKurs(TextBox txtNazivK, TextBox txtCenaK, ComboBox cmbProfesor, ComboBox cmbJezik, ComboBox cmbNivo)
        {
            kurs.NazivKursa = txtNazivK.Text;
            if (string.IsNullOrEmpty(kurs.NazivKursa))
            {
                MessageBox.Show("Niste uneli naziv!");
                return false;

            }
            try
            {
                kurs.Cena = Convert.ToDouble(txtCenaK.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste uneli validnu cenu");
            }
            kurs.Nastavnik = cmbProfesor.SelectedItem as Nastavnik;
            if (kurs.Nastavnik == null)
            {
                MessageBox.Show("Niste odabrali nastavnika!");
            }
            kurs.Jezik = cmbJezik.SelectedItem as Jezik;
            if (kurs.Jezik == null)
            {
                MessageBox.Show("Niste odabrali jezik!");
            }
            kurs.Nivo = cmbNivo.SelectedItem as Nivo;
            if (kurs.Nivo == null)
            {
                MessageBox.Show("Niste odabrali nivo!");
            }
            Object rez = komunikacija.ZapamtiNoviKurs(kurs);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti kurs!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio uneti kurs!");
                return true;
            }
        }

        public static void KreirajGrupu(DataGridView dataGridView1)
        {
            //kurs = new Kurs();
            grupa = new Grupa();
            grupa.Testovi = new System.ComponentModel.BindingList<Test>();
            dataGridView1.DataSource = grupa.ListaUnetih;
            dataGridView1.DataSource = grupa.Testovi;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            //dataGridView1.Columns[2].Visible = false;
            //dataGridView1.Columns[4].Visible = false;
        }

        public static void popuniComboJezik(ComboBox cmbJezik)
        {
            cmbJezik.Items.Clear();
            List<Jezik> lista = (List<Jezik>)komunikacija.UcitajJezike();
            foreach (Jezik j in lista)
            {
                cmbJezik.Items.Add(j);
            }
            cmbJezik.Text = "Izaberite jezik!";
        }

        public static void popuniComboNastavnik(ComboBox cmbNastavnik)
        {
            cmbNastavnik.Items.Clear();
            List<Nastavnik> lista = (List<Nastavnik>)komunikacija.UcitajNastavnike();
            foreach (Nastavnik p in lista)
            {
                cmbNastavnik.Items.Add(p);
            }
            cmbNastavnik.Text = "Izaberite nastavnika!";
        }

        public static void popuniComboPolaznik(ComboBox cmbPolaznik)
        {
            cmbPolaznik.Items.Clear();
            List<Polaznik> lista = (List<Polaznik>)komunikacija.UcitajPolaznike();
            foreach (Polaznik c in lista)
            {
                cmbPolaznik.Items.Add(c);
            }
            cmbPolaznik.Text = "Izaberite polaznika!";
        }

        public static void popuniComboNivo(ComboBox cmbNivo)
        {
            cmbNivo.Items.Clear();
            List<Nivo> lista = (List<Nivo>)komunikacija.UcitajNivoe();
            foreach (Nivo p in lista)
            {
                cmbNivo.Items.Add(p);
            }
            cmbNivo.Text = "Izaberite nivo!";

        }

        public static void popuniComboKurs(ComboBox cmbKurs)
        {
            cmbKurs.Items.Clear();
            List<Kurs> lista = (List<Kurs>)komunikacija.UcitajKurseve();
            foreach (Kurs p in lista)
            {
                cmbKurs.Items.Add(p);
            }
            cmbKurs.Text = "Izaberite kurs!";

        }

        public static void DodajPolaznika(ComboBox cmbPolaznik)
        {
            Test pk = new Test();


            pk.Polaznik = cmbPolaznik.SelectedItem as Polaznik;
            if (pk.Polaznik == null)
            {
                MessageBox.Show("Niste izabrali clana!");
                return;
            }
            if (grupa.Testovi.Contains(pk))
            {
                MessageBox.Show("Vec ste uneli izabranog polaznika!");
                return;
            }

            grupa.Testovi.Add(pk);



        }


        public static void Obrisi(DataGridView dataGridView1)
        {
            try
            {
                grupa.Testovi.Remove(dataGridView1.CurrentRow.DataBoundItem as Test);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali polaznika");
            }
        }

        public static bool ZapmatiNovuGrupu(TextBox txtNazivGrupe, TextBox txtTermin, ComboBox cmbKurs)
        {
            grupa.NazivGrupe = txtNazivGrupe.Text;
            if (string.IsNullOrEmpty(grupa.NazivGrupe))
            {
                MessageBox.Show("Niste uneli naziv!");
                return false;

            }
            grupa.Termin = txtTermin.Text;
            if (string.IsNullOrEmpty(grupa.Termin))
            {
                MessageBox.Show("Niste uneli termin!");
                return false;

            }
            grupa.Kurs = cmbKurs.SelectedItem as Kurs;
            if (grupa.Kurs == null)
            {
                MessageBox.Show("Niste odabrali kurs!");
            }

            Object rez = komunikacija.ZapamtiNovuGrupu(grupa);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti grupu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio uneti grupu!");
                return true;
            }
        }


        public static void pretraziGrupe(ComboBox txtNaziv, DataGridView dataGridView1)
        {

            grupa = new Grupa();
            grupa.NazivGrupe = txtNaziv.Text;
            List<Grupa> lista = new List<Grupa>();
            lista = komunikacija.PronadjiGrupe(grupa);
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da nadje grupu po zadatoj vrednosti. ");
            }
            else
            {
                MessageBox.Show("Sistem je pronasao trazene grupe. ");
                dataGridView1.DataSource = lista;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }

            }
        }

        public static bool detaljiOGrupi(DataGridView dataGridView1)
        {
            try
            {
                grupa = dataGridView1.SelectedRows[0].DataBoundItem as Grupa;

                if(grupa == null)
                {
                    DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;


                    if (drv != null)
                    {
                        DataRow row = drv.Row;

                        

                        if (row != null)
                        {
                            grupa = new Grupa();
                            var grupaId = row["GrupaID"];
                            var naziv = row["NazivGrupe"];
                            var termin = row["Termin"];
                            var kurs = row["Kurs_ID"];
                            var uslov = row["uslovPrimarni"];
                            grupa.GrupaID = Convert.ToInt32(grupaId);
                            grupa.NazivGrupe = (string)naziv;
                            grupa.Termin = (string)termin;
                            grupa.Kurs = new Kurs
                            {
                                KursID = Convert.ToInt32(kurs),
                              
                            };

                        }
                    }
                }
                MessageBox.Show("Podaci o izabranoj grupi. ");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali podatke za pregled! ");
                return false;
            }
        }

        public static void PopuniPoljaGrupe(TextBox txtNazivGrupe, TextBox txtTermin, ComboBox cmbKurs, DataGridView dataGridView1)
        {
            try
            {

                grupa = komunikacija.PrikaziGrupu(grupa) as Grupa;
                txtNazivGrupe.Text = grupa.NazivGrupe;
                txtTermin.Text = grupa.Termin;
                cmbKurs.SelectedItem = grupa.Kurs;
                dataGridView1.DataSource = grupa.ListaPolaznika;

            }
            catch (Exception)
            {


            }

        }

        public static void Kreiraj(DataGridView dataGridView1)
        {
            grupa = new Grupa();
            grupa.Testovi = new System.ComponentModel.BindingList<Test>();
            dataGridView1.DataSource = grupa.ListaUnetih;
            dataGridView1.DataSource = grupa.Testovi;
        }

        public static bool IzmeniGrupu(TextBox txtNazivGrupe, TextBox txtTermin, ComboBox cmbKurs)
        {

       
            grupa.NazivGrupe = txtNazivGrupe.Text;
            if (string.IsNullOrEmpty(grupa.NazivGrupe))
            {
                MessageBox.Show("Niste uneli naziv!");
                return false;

            }

            grupa.Termin = txtTermin.Text;
            grupa.Kurs = cmbKurs.SelectedItem as Kurs;
            if(grupa.Kurs == null)
            {
                MessageBox.Show("Niste izabrali kurs!");
                return false;
            }
            Object rez = komunikacija.IzmeniGrupu(grupa);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da izmeni grupu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno izmenio unetu grupu!");
                return true;
            }
        }

        
        public static bool ObrisiGrupu()
        {
            Object rez = komunikacija.ObrisiGrupu(grupa);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obrise grupu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno obrisao unetu grupu!");
                return true;
            }
        }

        public static bool IzmeniPolaznika(TextBox txtIme, TextBox txtPrezime, TextBox txtJMBG, TextBox txtBrojTel)
        {
            p.Ime = txtIme.Text;
            if (string.IsNullOrEmpty(p.Ime))
            {
                MessageBox.Show("Niste uneli ime!");
                return false;

            }
            p.Prezime = txtPrezime.Text;
            if (string.IsNullOrEmpty(p.Prezime))
            {
                MessageBox.Show("Niste uneli prezime!");
                return false;

            }
            p.JMBG = txtJMBG.Text;
            if (string.IsNullOrEmpty(p.JMBG))
            {
                MessageBox.Show("Niste uneli JMBG!");
                return false;

            }
            try
            {
                p.Telefon = Convert.ToInt32(txtBrojTel.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Niste uneli ispravan telefon!");
                return false;

            }


            Object rez = komunikacija.IzmeniPolaznika(p);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da izmeni polaznika!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno izmenio unetog polaznika!");
                return true;
            }

        }

        public static void popuniComboGrupe(ComboBox cmbGrupe)
        {
            cmbGrupe.Items.Clear();
            List<Grupa> lista = (List<Grupa>)komunikacija.UcitajGrupe();
            foreach (Grupa p in lista)
            {
                cmbGrupe.Items.Add(p);
            }
            cmbGrupe.Text = "Izaberite grupu!";
        }

        public static bool PretraziTest(ComboBox cmbGrupa, DataGridView dgvPronadjeniTestovi)
        {
            Test t = new Test();
            //t.DatumPolaganjaTesta = (DateTime)dtpDatum.Value.Date;
            //t.DatumPolaganja = t.DatumPolaganjaTesta.ToString("yyyy-MM-dd");

            //t.Polaznik = cmbPolaznik.SelectedItem as Polaznik;
            t.Grupa = cmbGrupa.SelectedItem as Grupa;
            List<Test> lista = komunikacija.PronadjiTestove(t);

            if (lista.Count == 0)
            {
                dgvPronadjeniTestovi.DataSource = null;
                MessageBox.Show("Sistem ne može da nadje test po zadatoj vrednosti. ");

                return false;
            }
            else
            {

                dgvPronadjeniTestovi.DataSource = lista;
                MessageBox.Show("Sistem je pronašao test. ");
                return true;
            }
        }

        public static bool detaljiOTestu(DataGridView dgvPronadjeniTestovi)
        {
            try
            {
                t = dgvPronadjeniTestovi.SelectedRows[0].DataBoundItem as Test;
                if (t.DatumPolaganjaTesta == new DateTime(1, 1, 1))
                {
                    MessageBox.Show("Izabrani test nema rezultate");
                    return false;
                }


                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali test za prikaz! ");
                return false;
            }
        }

        public static void popuniComboPolaznikIzGrupe(ComboBox cmbPolaznik, ComboBox cmbGrupe)
        {
            cmbPolaznik.Items.Clear();
            Grupa izabrana = cmbGrupe.SelectedItem as Grupa;
            List<Polaznik> lista = (List<Polaznik>)komunikacija.UcitajPolaznike();
            foreach (Polaznik c in lista)
            {
                if (c.Grupa.GrupaID == izabrana.GrupaID)
                {
                    cmbPolaznik.Items.Add(c);
                }
            }

            cmbPolaznik.Text = "Izaberite polaznika!";
        }

        public static void UcitajTest(DateTimePicker dtpDatum, TextBox txtRezultat, TextBox txtGrupa, TextBox txtPolaznik)
        {

            dtpDatum.Value = t.DatumPolaganjaTesta;


            txtRezultat.Text = t.RezultatTesta.ToString();
            txtPolaznik.Text = t.Polaznik.PolaznikID.ToString();
            txtGrupa.Text = t.Grupa.GrupaID.ToString();

            t = (Test)komunikacija.PrikaziTest(t);

        }

        public static void End()
        {
            komunikacija.Kraj();

        }

        public static void kreirajTest(DataGridView dataGridView1)
        {
            testovi = new Test();
            dataGridView1.DataSource = testovi.ListaUnetih;
            dataGridView1.DataSource = testovi.Testovi;

        }

        public static bool ZapamtiRezultateTesta(ComboBox cmbGrupe, ComboBox cmbPolaznik)
        {
            //t.DatumPolaganjaTesta = dtpDatum.Value;
            //t.RezultatTesta = Convert.ToInt32(txtRezultat.Text);



            testovi.Grupa = cmbGrupe.SelectedItem as Grupa;
            testovi.Polaznik = cmbPolaznik.SelectedItem as Polaznik;


            if (testovi.Grupa == null)
            {
                MessageBox.Show("Niste odabrali grupu");
                return false;

            }
            if (testovi.Polaznik == null)
            {
                MessageBox.Show("Niste odabrali polaznika");
                return false;
            }

            Object rez = komunikacija.ZapamtiRezultateTesta(testovi);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti rezultate testova!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio unete testove!");
                return true;
            }

        }

        public static void DodajTest(TextBox txtRezultat, DateTimePicker dtpDatum, ComboBox cmbPolaznik, ComboBox cmbGrupa)
        {
            Test pk = new Test();


            try
            {
                pk.Polaznik = cmbPolaznik.SelectedItem as Polaznik;
                pk.RezultatTesta = int.Parse(txtRezultat.Text);
                pk.DatumPolaganjaTesta = dtpDatum.Value;
                pk.Grupa = cmbGrupa.SelectedItem as Grupa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste lepo uneli vrednosti");
            }


            testovi.Testovi.Add(pk);


        }

        public static List<Polaznik> UcitajPolaznike()
        {
            List<Polaznik> lista = (List<Polaznik>)komunikacija.UcitajPolaznike();

            return lista;
        }

        public static bool DodajPolaznikeUGrupu(DataGridView dataGridView1)
        {
            try
            {
                grupa = dataGridView1.SelectedRows[0].DataBoundItem as Grupa;

                MessageBox.Show("Izaberite polaznike za datu grupu. ");
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali polaznike za datu grupu! ");
                return false;
            }
        }

        public static bool ZapmatiNovuGrupu(TextBox txtNazivGrupe, TextBox txtTermin, ComboBox cmbKurs, DataGridView dataGridView1)
        {
            grupa.NazivGrupe = txtNazivGrupe.Text;
            if (string.IsNullOrEmpty(grupa.NazivGrupe))
            {
                MessageBox.Show("Niste uneli naziv!");
                return false;

            }
            grupa.Termin = txtTermin.Text;
            if (string.IsNullOrEmpty(grupa.Termin))
            {
                MessageBox.Show("Niste uneli termin!");
                return false;

            }
            grupa.Kurs = cmbKurs.SelectedItem as Kurs;
            if (grupa.Kurs == null)
            {
                MessageBox.Show("Niste odabrali kurs!");
            }

            grupa.Nastavnik = n;
            Kontroler.DodajPolaznike(dataGridView1);


            Object rez = komunikacija.ZapamtiNovuGrupu(grupa);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti grupu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio uneti grupu!");
                return true;
            }
        }

        private static void DodajPolaznike(DataGridView dataGridView1)
        {
            Test pk = new Test();
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pk = new Test();
                pk.Polaznik = dataGridView1.Rows[i].DataBoundItem as Polaznik;
               // pk.Polaznik.PolaznikID = 
                if (pk.Polaznik.Dodaj == true)
                {
                    grupa.Testovi.Add(pk);
                }
            }


        }

        public static List<Grupa> UcitajGrupe()
        {
            List<Grupa> lista = (List<Grupa>)komunikacija.UcitajGrupe();

            return lista;
        }

        public static void ObrisiPolaznikaIzTestova(DataGridView dataGridView1)
        {

            try
            {
                grupa.ListaPolaznika.Remove(dataGridView1.CurrentRow.DataBoundItem as Polaznik);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali polaznika");
            }
        }

        public static List<Test> UcitajTestove()
        {
            List<Test> lista = (List<Test>)komunikacija.UcitajTestove();

            return lista;

        }

       
        public static bool ZakaziTest(DateTimePicker dtpDatum, ComboBox cmbGrupa)
        {
            testovi.Grupa = cmbGrupa.SelectedItem as Grupa;
            //testovi.Polaznik = cmbPolaznik.SelectedItem as Polaznik;


            if (testovi.Grupa == null)
            {
                MessageBox.Show("Niste odabrali grupu");
                return false;

            }

            testovi.DatumPolaganjaTesta = dtpDatum.Value;

            Object rez = komunikacija.ZakaziTest(testovi);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zakaže test!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zakazao test!");
                return true;
            }
        }

        public static bool ZapamtiRezultateTesta(DataGridView dataGridView1)
        {
            Kontroler.ZapamtiRezultate(dataGridView1);


            Object rez = komunikacija.ZapamtiRezultateTesta(testoviRez);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti rezultate testova!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je uspešno zapamtio unete testove!");
                return true;
            }

        }

        private static void ZapamtiRezultate(DataGridView dataGridView1)
        {
           

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                pk = new Test();    
               // pk.Polaznik = dataGridView1.Rows[i].DataBoundItem as Polaznik;
                pk.DatumPolaganjaTesta = (DateTime)dataGridView1.Rows[i].Cells["DatumPolaganjaTesta"].Value;
                pk.RezultatTesta = (int)dataGridView1.Rows[i].Cells["RezultatTesta"].Value;
                pk.TestID = (int)dataGridView1.Rows[i].Cells["TestID"].Value;

                testoviRez.Testovi.Add(pk);
                
            }
            
          

        }

        public static List<Nastavnik> UcitajNastavnike()
        {
            List<Nastavnik> lista = (List<Nastavnik>)komunikacija.UcitajNastavnike();

            return lista;
        }

        public static void pretraziGrupe(TextBox txtNaziv, DataGridView dataGridView1)
        {
            throw new NotImplementedException();
        }
    }
}
