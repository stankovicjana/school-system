using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Broker
{
    public class BrokerBazePodataka
    {

        SqlConnection konekcija;
        SqlTransaction transakcija;


        public static BrokerBazePodataka instanca;

        public static BrokerBazePodataka dajSesiju()
        {
            if (instanca == null)
            {
                instanca = new BrokerBazePodataka();
            }
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                //konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Baza;Integrated Security=True");

               //konekcija.Open();

                konekcija   = new SqlConnection();
                konekcija.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                konekcija.Open();
               

            }
            catch (Exception)
            {


            }
        }

        public void zatvoriKonekciju()
        {
            try
            {

                konekcija.Close();
            }
            catch (Exception)
            {

            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {


            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {

            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
            }
        }
        public List<IOpstiDomenskiObjekat> vratiSveZaUslovOstalo(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IOpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public List<IOpstiDomenskiObjekat> vratiSveZaUslovOstalo2(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo2;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IOpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
        public List<IOpstiDomenskiObjekat> vratiSveZaUslovOstalo3(IOpstiDomenskiObjekat odo)
        {
            string upit = "select " + odo.izvuci + " from " + odo.nazivTabele + " " + odo.uslovJoin + " where " + odo.uslovOstalo3 ;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IOpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public IOpstiDomenskiObjekat VratiZaUslovOstalo(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.procitaj(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int VratiSifru(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT MAX(" + odo.primarniKljuc + ") FROM " + odo.nazivTabele;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                Object o = komanda.ExecuteScalar();
                if (o == DBNull.Value) return 1;
                else return Convert.ToInt32(o) + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Sacuvaj(IOpstiDomenskiObjekat odo)
        {
            string upit = "INSERT INTO " + odo.nazivTabele + " " + odo.unos;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public IOpstiDomenskiObjekat VratiZaUslovPrimarni(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }
                return odo.procitaj(red);
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }

        public int ObrisiZaUslovPrimarni(IOpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }

        }

        public List<IOpstiDomenskiObjekat> vratiSve(IOpstiDomenskiObjekat odo)
        {
            string upit = "SELECT * FROM " + odo.nazivTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IOpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
     
        public int IzmeniUslovPrimarni(IOpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena + " WHERE " + odo.uslovPrimarni;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }

        }
        public int IzmeniUslovOstalo(IOpstiDomenskiObjekat odo)
        {
            string upit = "UPDATE " + odo.nazivTabele + " SET " + odo.izmena2 + " WHERE " + odo.uslovOstalo;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }

        }


        public int ObrisiZaUslovOstalo(IOpstiDomenskiObjekat odo)
        {
            string upit = "DELETE FROM " + odo.nazivTabele + " WHERE " + odo.uslovOstalo2;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
        }

        public List<IOpstiDomenskiObjekat> vratiSveJoin(IOpstiDomenskiObjekat odo)
        {
            //string upit = "SELECT * FROM " + odo.nazivTabele + "JOIN" +odo.drugaTabela+ "on"+odo.primarniKljuc+"=="+odo.drugaTabelaSpoljni;
            //string upit = "Select TestID, DatumPolaganjaTesta, RezultatTesta, Polaznik, Ime, GrupaID, NazivGrupa from test t join polaznik p on t.polaznik = p.polaznikID join grupa g on t.grupa = g.grupaID";

            string upit = "select " + odo.izvuci + " from " + odo.nazivTabele + " "+ odo.uslovJoin;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
                foreach (DataRow red in tabela.Rows)
                {
                    IOpstiDomenskiObjekat pom = odo.procitaj(red);
                    lista.Add(pom);
                }
                return lista;
            }
            catch (Exception)
            {
                throw new Exception("Greska u radu sa bazom!");
            }
            finally
            {
                if (citac != null)
                {
                    citac.Close();
                }
            }
        }
    }
}
