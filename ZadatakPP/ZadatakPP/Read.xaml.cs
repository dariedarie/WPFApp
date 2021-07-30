using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ZadatakPP
{
    /// <summary>
    /// Interaction logic for Read.xaml
    /// </summary>
    public partial class Read : Window
    {
        public Read(string putanjaRtf,string putanjaSlike, string ime,DateTime datumRodjenja ,int broj, string pozicija)
        {
            InitializeComponent();
            slikaIgraca.Source = new BitmapImage(new Uri(putanjaSlike));
            labelIme.Content = ime;           
            datumRodj.Content = datumRodjenja;

            TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
            using (FileStream fileStream = new FileStream(putanjaRtf, FileMode.Open))
            {
                range.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void buttonPovratak_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }







    }
}
