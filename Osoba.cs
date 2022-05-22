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
        void OnPropertyChanged([CallerMemberName] string właściwość = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(właściwość));
            foreach (string powiązanaWłaściwość in powiązaneWłaściwości[właściwość])
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(powiązanaWłaściwość));

        }

    }
}
