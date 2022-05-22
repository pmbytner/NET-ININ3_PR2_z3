using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_ININ3_PR2_z3
{
    class Osoba : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        readonly static Dictionary<string, string[]> powiązaneWłaściwości
            = new Dictionary<string, string[]>()
            {
                ["Imię"] = new string[] {"ImięNazwisko"}
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

            foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                if(!załatwioneWłaściwości.Contains(powiązanaWłaściwość))
                    OnPropertyChanged(powiązanaWłaściwość, załatwioneWłaściwości);
        }

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
    }
}
