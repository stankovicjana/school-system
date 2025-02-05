using Domen;
using KontrolerPoslovneLogike;
using SistemskeOperacije;
using SistemskeOperacije.Grupa;
using SistemskeOperacije.Jezik;
using SistemskeOperacije.Kurs;
using SistemskeOperacije.Nastavnik;
using SistemskeOperacije.Polaznik;
using SistemskeOperacije.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ObradaKlijenta
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public ObradaKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {
                        case Operacije.Login:
                            PrijaviNastavnika pn = new PrijaviNastavnika();
                            transfer.Rezultat = pn.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiNovogPolaznika:
                            DodajPolaznika znc = new DodajPolaznika();
                            transfer.Rezultat = znc.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiPolaznike:
                            PronadjiPolaznika prc = new PronadjiPolaznika();
                            transfer.Rezultat = prc.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziPolaznika:
                            PrikaziPolaznika pc = new PrikaziPolaznika();
                            transfer.Rezultat = pc.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiPolaznika:
                            ObrisiPolaznika oc = new ObrisiPolaznika();
                            transfer.Rezultat = oc.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajPolaznike:
                            UcitajPolaznike uc = new UcitajPolaznike();
                            transfer.Rezultat = uc.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                       
                        case Operacije.UcitajGrupe:
                            UcitajGrupe ug = new UcitajGrupe();
                            transfer.Rezultat = ug.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokova.Remove(tok);
                            break;
                        case Operacije.ZapamtiNoviKurs:
                            ZapamtiNoviKurs znk = new ZapamtiNoviKurs();
                            transfer.Rezultat = znk.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajNastavnike:
                            UcitajNastavnike up = new UcitajNastavnike();
                            transfer.Rezultat = up.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajJezike:
                            UcitajJezike uj = new UcitajJezike();
                            transfer.Rezultat = uj.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajNivoe:
                            UcitajNivoe un = new UcitajNivoe();
                            transfer.Rezultat = un.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajKurseve:
                            UcitajKurseve uk = new UcitajKurseve();
                            transfer.Rezultat = uk.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiNovuGrupu:
                            ZapamtiNovuGrupu zng = new ZapamtiNovuGrupu();
                            transfer.Rezultat = zng.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiGrupe:
                            PronadjiGrupe pkk = new PronadjiGrupe();
                            transfer.Rezultat = pkk.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziGrupu:
                            PrikaziGrupu pk = new PrikaziGrupu();
                            transfer.Rezultat = pk.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniGrupu:
                            IzmeniGrupu ik = new IzmeniGrupu();
                            transfer.Rezultat = ik.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiGrupu:
                            ObrisiGrupu ok = new ObrisiGrupu();
                            transfer.Rezultat = ok.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.IzmeniPolaznika:
                            IzmeniPolaznika ip = new IzmeniPolaznika();
                            transfer.Rezultat = ip.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRezultatTesta:
                            ZapamtiRezultatTesta znt = new ZapamtiRezultatTesta();
                            transfer.Rezultat = znt.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PronadjiTestove:
                            PronadjiTest pt = new PronadjiTest();
                            transfer.Rezultat = pt.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziTest:
                            PrikaziTest rpt = new PrikaziTest();
                            transfer.Rezultat = rpt.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRezultateTesta:
                            ZapamtiRezultateTesta zrt = new ZapamtiRezultateTesta();
                            transfer.Rezultat = zrt.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajTestove:
                            UcitajTestove ut = new UcitajTestove();
                            transfer.Rezultat = ut.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZakaziTest:
                            ZakaziTest zak = new ZakaziTest();
                            transfer.Rezultat = zak.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiRezultate:
                            ZapamtiRezultate z = new ZapamtiRezultate();
                            transfer.Rezultat = z.izvrsiSO(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

                Server.listaTokova.Remove(tok);

            }
        }
    }
}
