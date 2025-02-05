using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Komunikacija
{
    public class Komunkacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object Login(Nastavnik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Login;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object ZapamtiNovogPolaznika(object polaznik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNovogPolaznika;
            transfer.TransferObjekat = polaznik;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public List<Polaznik> PronadjiPolaznike(Polaznik polaznik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiPolaznike;
            transfer.TransferObjekat = polaznik;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Polaznik>;
        }

        public Polaznik PrikaziPolaznika(Polaznik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziPolaznika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Polaznik;
        }

        public object ObrisiPolaznika(Polaznik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiPolaznika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object ZapamtiNoviKurs(Kurs kurs)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNoviKurs;
            transfer.TransferObjekat = kurs;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UcitajJezike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajJezike;
            transfer.TransferObjekat = new Jezik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UcitajNastavnike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajNastavnike;
            transfer.TransferObjekat = new Nastavnik();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Nastavnik>;
        }

        public Object UcitajPolaznike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajPolaznike;
            transfer.TransferObjekat = new Polaznik();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UcitajNivoe()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajNivoe;
            transfer.TransferObjekat = new Nivo();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object UcitajKurseve()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajKurseve;
            transfer.TransferObjekat = new Kurs();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat; 
        }

        public object ZapamtiNovuGrupu(Grupa grupa)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNovuGrupu;
            transfer.TransferObjekat = grupa;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public List<Grupa> PronadjiGrupe(Grupa grupa)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiGrupe;
            transfer.TransferObjekat = grupa;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Grupa>;
        }

        public Object PrikaziGrupu(Grupa grupa)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziGrupu;
            transfer.TransferObjekat = grupa;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object ObrisiGrupu(Grupa grupa)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiGrupu;
            transfer.TransferObjekat = grupa;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object IzmeniGrupu(Grupa grupa)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniGrupu;
            transfer.TransferObjekat = grupa;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object IzmeniPolaznika(Polaznik p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniPolaznika;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        
        }

        public Object UcitajGrupe()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajGrupe;
            transfer.TransferObjekat = new Grupa();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object ZapamtiNoviTest(Test t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNoviTest;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public List<Test> PronadjiTestove(Test t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiTestove;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Test>;
        }

        public object ZapamtiRezultatTesta(Test t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiRezultatTesta;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public Object PrikaziTest(Test t)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziTest;
            transfer.TransferObjekat = t;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Test;
        }

        public object ZapamtiRezultateTesta(Test testovi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiRezultate;
            transfer.TransferObjekat = testovi;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object UcitajTestove()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajTestove;
            transfer.TransferObjekat = new Test();
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }

        public object ZakaziTest(Test testovi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZakaziTest;
            transfer.TransferObjekat = testovi;
            formater.Serialize(tok, transfer);

            return ((TransferKlasa)formater.Deserialize(tok)).Rezultat;
        }
    }
}
