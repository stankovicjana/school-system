using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{

    public enum Operacije
    {
        Kraj = 1,
        Login = 2,
        ZapamtiNovogPolaznika = 3,
        PronadjiPolaznike = 4,
        PrikaziPolaznika = 5,
        ObrisiPolaznika = 6,
        UcitajPolaznike = 7,
        ZapamtiNoviKurs = 8,
        UcitajNastavnike = 9,
        UcitajJezike = 10,
        UcitajNivoe = 11,
        UcitajKurseve = 12,
        ZapamtiNovuGrupu = 13,
        PronadjiGrupe = 14,
        PrikaziGrupu = 15,
        IzmeniGrupu = 16,
        ObrisiGrupu = 17,
        IzmeniPolaznika = 18,
        UcitajGrupe = 19,
        UcitajPolaznikeIzGrupe = 20,
        ZapamtiNoviTest = 21,
        PronadjiTestove = 22,
        ZapamtiRezultatTesta = 23,
        PrikaziTest = 24,
        ZapamtiRezultateTesta = 25,
        UcitajTestove = 26,
        UcitajPolaznikeZaPretragu = 27,
        ZakaziTest = 28,
        ZapamtiRezultate = 29,
    }
    [Serializable]
    public class TransferKlasa
    {
        private Operacije operacija;
        private Object transferObjekat;
        private Object rezultat;

        public Operacije Operacija { get => operacija; set => operacija = value; }
        public object TransferObjekat { get => transferObjekat; set => transferObjekat = value; }
        public object Rezultat { get => rezultat; set => rezultat = value; }
    }

}
