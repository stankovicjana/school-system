using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   
    public interface IOpstiDomenskiObjekat
    {
        string nazivTabele { get; }
        string primarniKljuc { get; }
        string uslovPrimarni { get; }
        string uslovOstalo { get; }
        string izmena { get; }
        string unos { get; }
        string uslovOstalo2 { get; }
        string izvuci { get; }
        string uslovJoin { get; }
        string izmena2 { get; }
        string uslovOstalo3 { get; }

        IOpstiDomenskiObjekat procitaj(DataRow red);

    }
}
