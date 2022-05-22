using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z3
{
    class Model
    {
        LinkedList<Osoba> osoby = new LinkedList<Osoba>();
        internal LinkedList<Osoba> Osoby { get => osoby; set => osoby = value; }

        public Model()
        {
            osoby.AddLast(new Osoba("Adam","Wiśniewski"));
            osoby.AddLast(new Osoba("Beata","Dąbrowska"));
            osoby.AddLast(new Osoba("Cyprian","Topolski"));
            osoby.AddLast(new Osoba("Danuta","Lipowicz"));
        }
    }
}
