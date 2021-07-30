using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace ZadatakPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public static BindingList<Classes.Fudbaler> Fudbaleri { get; set; }

        public static int maxBroj=11;
       
        public MainWindow()
        {

          
            Fudbaleri = new BindingList<Classes.Fudbaler>();


            DataContext = this;
            InitializeComponent();
        }

        private void buttonIzlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        int brojac=0;
        private void buttonDodajNovogIgraca_Click(object sender, RoutedEventArgs e)
        {
            if (brojac <maxBroj)
            {
                Dodaj addWin = new Dodaj();
                addWin.ShowDialog();
                brojac++;

            }
            else
            {
                MessageBox.Show("Uneli ste maxBroj igraca!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        
        }




        private void buttonProcitaj_Click(object sender, RoutedEventArgs e)
        {
            Read procitaj = new Read(Fudbaleri[dataGrid.SelectedIndex].RtfFajl,Fudbaleri[dataGrid.SelectedIndex].Slika, Fudbaleri[dataGrid.SelectedIndex].Ime, Fudbaleri[dataGrid.SelectedIndex].DatumRodjenja, Fudbaleri[dataGrid.SelectedIndex].Broj, Fudbaleri[dataGrid.SelectedIndex].Pozicija);
            procitaj.ShowDialog();
        }

         
        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Izmena noviIzmena = new Izmena(dataGrid.SelectedIndex, Fudbaleri[dataGrid.SelectedIndex].RtfFajl, Fudbaleri[dataGrid.SelectedIndex].Slika, Fudbaleri[dataGrid.SelectedIndex].Ime, Fudbaleri[dataGrid.SelectedIndex].DatumRodjenja,Fudbaleri[dataGrid.SelectedIndex].Broj, Fudbaleri[dataGrid.SelectedIndex].Pozicija);
            noviIzmena.ShowDialog();
            dataGrid.Items.Refresh();
        }

        private void buttonObrisiIgraca_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(Fudbaleri[dataGrid.SelectedIndex].RtfFajl);
            Fudbaleri.RemoveAt(dataGrid.SelectedIndex);        
            brojac--;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



    }
}
