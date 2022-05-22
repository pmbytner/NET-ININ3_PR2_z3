﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z3
{
    public class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> powiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Imię"] = new string[] { "ImięNazwisko" },
                ["Nazwisko"] = new string[] { "ImięNazwisko" },
                ["DataUrodzenia"] = new string[] { "Wiek" },
                ["DataŚmierci"] = new string[] { "Wiek" },
                ["Wiek"] = new string[] { "Szczegóły" },
                ["ImięNazwisko"] = new string[] { "Szczegóły" },
            };
        void OnPropertyChanged(
            [CallerMemberName] string właściwość = null,
            HashSet<string> załatwioneWłaściwości = null
            )
        {
            if (załatwioneWłaściwości == null)
                załatwioneWłaściwości = new HashSet<string>();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(właściwość));
            załatwioneWłaściwości.Add(właściwość);

            if(powiązaneWłaściwości.ContainsKey(właściwość))
                foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                    if(!załatwioneWłaściwości.Contains(powiązanaWłaściwość))
                        OnPropertyChanged(powiązanaWłaściwość, załatwioneWłaściwości);
        }

        DateTime?
            dataUrodzenia = null,
            dataŚmierci = null
            ;
        string
            imię,
            nazwisko
            ;

        public string Imię {
            get => imię;
            set
            {
                imię = value;
                OnPropertyChanged();
            }
        }
        public string Nazwisko {
            get => nazwisko;
            set
            {
                nazwisko = value;
                OnPropertyChanged();
            }
        }

        public string ImięNazwisko => $"{imię} {nazwisko}";

        public DateTime? DataUrodzenia {
            get => dataUrodzenia;
            set {
                dataUrodzenia = value;
                OnPropertyChanged();
            }
        }
        public DateTime? DataŚmierci {
            get => dataŚmierci;
            set
            {
                dataŚmierci = value;
                OnPropertyChanged();
            }
        }
        public string Wiek
        {
            get
            {
                if (dataUrodzenia == null)
                    return "BD";

                DateTime? koniec;
                if (dataŚmierci == null)
                    koniec = DateTime.Now;
                else
                    koniec = dataŚmierci;

                TimeSpan czasŻycia = (TimeSpan)(koniec - dataUrodzenia);

                return Math.Ceiling(czasŻycia.Days / 365.25).ToString();
            }
        }
        public string Szczegóły => $"{ImięNazwisko}, {Wiek} lat(a)";

        public Osoba(
            string imię,
            string nazwisko
            )
        {
            Imię = imię;
            Nazwisko = nazwisko;
        }
        public Osoba() {}
        /*public override string ToString()
        {
            return ImięNazwisko;
        }*/
    }
}
