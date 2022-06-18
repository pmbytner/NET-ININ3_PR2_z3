using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z3
{
    class Model
    {
        public ObservableCollection<Osoba> Osoby { get; set; } = new ObservableCollection<Osoba>();

        public Model()
        {
            Osoby.Add(new Osoba("Adam", "Wiśniewski") { DataUrodzenia = DateTime.Parse("1.1.1990")});
            Osoby.Add(new Osoba("Beata", "Dąbrowska") { DataUrodzenia = DateTime.Parse("2.2.1995") });
            Osoby.Add(new Osoba("Cyprian", "Topolski") { DataUrodzenia = DateTime.Parse("3.3.2000") });
            Osoby.Add(new Osoba("Danuta", "Lipowicz") { DataUrodzenia = DateTime.Parse("4.4.2005") });
            Osoby.Add(new Osoba("Edward", "Sosnowski") { DataUrodzenia = DateTime.Parse("5.5.2010") });
            Osoby.Add(new Osoba("Felicja", "Jabłońska") { DataUrodzenia = DateTime.Parse("6.6.2020") });
        }

        internal Osoba DodajNowąOsobę()
        {
            Osoba nowa = new Osoba();
            Osoby.Add(nowa);
            return nowa;
        }
    }
}
