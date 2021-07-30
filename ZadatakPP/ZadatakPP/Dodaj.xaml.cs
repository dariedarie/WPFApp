using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Dodaj.xaml
    /// </summary>
    public partial class Dodaj : Window
    {
        private string putanjaDoSlike = null;
        private bool promenaKodJedneReci = true;

        

        public Dodaj()
        {
                InitializeComponent();
                comboBoxPozicija.ItemsSource = Classes.IzborPozicije.pozicije;
                cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
                int[] fontSize = new int[12] { 8, 10, 12, 14, 16, 20, 24, 28, 36, 40, 50,70 };
                comboFontSize.ItemsSource = fontSize;


        }
        private bool validate()
        {
            bool result = true;

            if (putanjaDoSlike == null)
            {
                result = false;
                labelSlikaGreska.Content = "Morate odabrati sliku!";
            }
            else
            {
                labelSlikaGreska.Content = "";
            }

            int parsedValue;

            if (textBoxIme.Text.Trim().Equals(""))
            {
                result = false;
                labelImeGreska.Content = "Niste uneli ime!";
                textBoxIme.BorderBrush = Brushes.Yellow;
            }
            else if(int.TryParse(textBoxIme.Text,out parsedValue))
            {
                result = false;
                labelImeGreska.Content = "Uneli ste broj,UNESITE IME!";
                textBoxIme.BorderBrush = Brushes.Yellow;

            }
            else
            {
                labelImeGreska.Content = "";
                textBoxIme.BorderBrush = Brushes.Gray;

            }
           


            if (textBoxBroj.Text.Trim().Equals(""))
            {
                result = false;
                labelBrojGreska.Content = "Niste uneli broj!";
                textBoxBroj.BorderBrush = Brushes.Yellow;
            }
            else
            {
                try
                {
                    if (Int32.Parse(textBoxBroj.Text) > 0)
                    {
                        labelBrojGreska.Content = "";
                        textBoxBroj.BorderBrush = Brushes.Gray;
                    }
                    else
                    {
                        result = false;
                        labelBrojGreska.Content = "Unesite pozitivan broj!";
                        textBoxBroj.BorderBrush = Brushes.Yellow;
                    }
                }
                catch (Exception ex)
                {
                    result = false;
                    labelBrojGreska.Content = "Polje mora biti broj!";
                    textBoxBroj.BorderBrush = Brushes.Yellow;
                    
                }

            }

           

            if (comboBoxPozicija.SelectedItem == null)
            {
                result = false;
                labelPozicijaGreska.Content = "Morate odabrati opciju!";
                comboBoxPozicija.BorderThickness = new Thickness(3);
                comboBoxPozicija.BorderBrush = Brushes.Yellow;
            }
            else
            {
                labelPozicijaGreska.Content = "";
                comboBoxPozicija.BorderBrush = Brushes.Gray;
            }


            if (dataPicker.SelectedDate == null)
            {
                result=false;
                labelGreskaDT.Content = "Morate izabrati datum rodjenja!";
                dataPicker.BorderBrush = Brushes.Yellow;
            }
            else
            {
                labelGreskaDT.Content = "";
                dataPicker.BorderBrush = Brushes.Gray;

            }

            return result;
        }

        private bool postoji(string ime)
        {
            bool result = false;

            foreach (var igrac in MainWindow.Fudbaleri)
            {
                if (igrac.Ime.Equals(ime))
                {
                    
                        result = true;
                        return result;
                    

                }
                else
                {
                    result = false;
                    return result;
                }

            }

            return result;
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            

                if (!postoji(textBoxIme.Text))
                {
                    if (validate())
                    {

                        string putanja = System.IO.Path.GetFullPath("RTF_fajlovi/" + textBoxIme.Text + ".rtf");
                        TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                        if(!range.Text.Trim().Equals(""))
                        {
                            using (FileStream fileStream = new FileStream(putanja, FileMode.Create))
                            {
                                range.Save(fileStream, DataFormats.Rtf);
                            }

                            MainWindow.Fudbaleri.Add(new Classes.Fudbaler(putanja, putanjaDoSlike, textBoxIme.Text, dataPicker.SelectedDate.Value, Int32.Parse(textBoxBroj.Text), comboBoxPozicija.SelectedValue.ToString()));

                            this.Close();
                        }
                       else
                        {
                            System.Windows.MessageBox.Show("RichTextBox je prazan, unesite nesto!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);

                       }
                       
                }
                    else
                    {
                    System.Windows.MessageBox.Show("Polja nisu dobro popunjena!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Igrac vec postoji!", "Greska!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
              

            }


        private void buttonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonSlika_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Odaberi sliku";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                putanjaDoSlike = op.FileName;
                slikaIgraca.Source = new BitmapImage(new Uri(putanjaDoSlike));
            }
        }




        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            promenaKodJedneReci = true;
           

            object bold = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (bold != DependencyProperty.UnsetValue) && (bold.Equals(FontWeights.Bold));

            object italic = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (italic != DependencyProperty.UnsetValue) && (italic.Equals(FontStyles.Italic));

            object underline = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (underline != DependencyProperty.UnsetValue) && (underline.Equals(TextDecorations.Underline));

            object font = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = font;

            object size = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            comboFontSize.SelectedItem = size;

            promenaKodJedneReci = false;

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void font_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null && !promenaKodJedneReci)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
            rtbEditor.Focus();
        }



        private void boje_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                System.Windows.Forms.ColorDialog MyDialog = new System.Windows.Forms.ColorDialog();
                if (MyDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.Drawing.Color color = MyDialog.Color;
                    System.Windows.Media.Color newColor = System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B);
                    rtbEditor.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(newColor));
                }
            }
            catch (Exception ex)
            {
            }

        }


        private void velicinaFonta_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboFontSize.SelectedItem != null && !promenaKodJedneReci)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, comboFontSize.SelectedItem.ToString());
            }
            rtbEditor.Focus();
        }



        private void brojReci_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange brReci = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);

           if (!brReci.Text.Equals(""))
            {
                  string sadrzajRichTextBoxa = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd).Text;

                  int brojac = 0; 
                  int indeks = 0;

                  while (indeks < sadrzajRichTextBoxa.Length && char.IsWhiteSpace(sadrzajRichTextBoxa[indeks]))
                    indeks++;

                  while (indeks < sadrzajRichTextBoxa.Length)
                  {

                      while (indeks < sadrzajRichTextBoxa.Length && !char.IsWhiteSpace(sadrzajRichTextBoxa[indeks]))
                        indeks++;

                        brojac++;


                      while (indeks < sadrzajRichTextBoxa.Length && char.IsWhiteSpace(sadrzajRichTextBoxa[indeks]))
                        indeks++;
                  }


                  labelWords.Content = "Broj reci: " + brojac;

            }
            else
            {
                labelWords.Content = "Broj reci: 0";
            }

        }

        




    }
}
