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
        public LinkedList<Osoba> Osoby { get => osoby; set => osoby = value; }

        public Model()
        {
            osoby.AddLast(new Osoba("Adam", "Wiśniewski") { DataUrodzenia=DateTime.Parse("1.1.1990")});
            osoby.AddLast(new Osoba("Beata", "Dąbrowska") { DataUrodzenia = DateTime.Parse("2.2.1995") });
            osoby.AddLast(new Osoba("Cyprian", "Topolski") { DataUrodzenia = DateTime.Parse("3.3.2000") });
            osoby.AddLast(new Osoba("Danuta", "Lipowicz") { DataUrodzenia = DateTime.Parse("4.4.2005") });
            osoby.AddLast(new Osoba("Edward", "Sosnowski") { DataUrodzenia = DateTime.Parse("5.5.2010") });
            osoby.AddLast(new Osoba("Felicja", "Jabłońska") { DataUrodzenia = DateTime.Parse("6.6.2020") });
        }
    }
}
