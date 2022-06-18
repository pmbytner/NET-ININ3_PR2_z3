using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NET_ININ3_PR2_z3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            DataContext = model;
            InitializeComponent();
        }

        private void WyświetlSzczegóły(object sender, RoutedEventArgs e)
        {
            ListBox listaOsób = (ListBox)this.FindName("ListaDanych");
            Osoba dlaKogo = (Osoba)listaOsób.SelectedItem;
            if(dlaKogo != null)
                (new OknoSzczegółów(dlaKogo)).Show();
        }

        private void NowyElement(object sender, RoutedEventArgs e)
        {
            Osoba nowa = model.DodajNowąOsobę();
            ListBox listaOsób = (ListBox)this.FindName("ListaDanych");
            (new OknoSzczegółów(nowa)).Show();
        }

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            model.Serializuj();
        }
    }
}
