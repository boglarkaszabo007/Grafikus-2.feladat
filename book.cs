using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafikus_2.feladat
{
    internal class Book
    {
            public string Kategoria { get; set; }
            public string Cim { get; set; }
            public int Ar { get; set; }
            public int Darabszam { get; set; }

            public Book(string kategoria, string cim, int ar, int darabszam)
            {
                Kategoria = kategoria;
                Cim = cim;
                Ar = ar;
                Darabszam = darabszam;
            }
        }
    }

