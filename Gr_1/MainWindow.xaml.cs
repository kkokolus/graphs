using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gr_1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        string[] iloscWierzcholkowArrayString;
        List<int> listaStopniWierzcholkow = new List<int>();
        List<int> listaStopniMacierzy = new List<int>();
        List<Ellipse> ellipses = new List<Ellipse>();
        List<Line> lines = new List<Line>();     

        public MainWindow()
        {
            InitializeComponent();
        }

        public void TworzElipsy()
        {
            Random liczba = new Random();

            for (int j = 0; j < 5; j++)
            {
                ellipses.Add(new Ellipse()
                {
                    Width = 20,
                    Height = 20,
                    Fill = Brushes.Orange,
                    Margin = new Thickness(liczba.Next(0, Convert.ToInt32(can.Width)),
                    liczba.Next(0, Convert.ToInt32(can.Height)), 0, 0)
                });
            }
          
        }

        public void TworzLinie()
        {
            int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (k < 10)
                    {
                        if (LosujLiczbe()[k] == 1)
                        {
                            lines.Add(new Line()
                            {
                                X1 = ellipses[i].Margin.Left + ellipses[i].Width / 2,
                                X2 = ellipses[j].Margin.Left + ellipses[j].Width / 2,
                                Y1 = ellipses[i].Margin.Top + ellipses[i].Height / 2,
                                Y2 = ellipses[j].Margin.Top + ellipses[j].Width / 2,
                                Stroke = Brushes.DarkGray,
                                Fill = Brushes.DarkGray
                            });
                        }
                    }
                    k++;
                }

            }

            for (int i = 0; i < lines.Count; i++)
            {
                can.Children.Add(lines[i]);
            }

            for (int i = 0; i < ellipses.Count; i++)
            {
                can.Children.Add(ellipses[i]);
            }
        }


         public List<int> LosujLiczbe()
        {
            List<int> liczbaBinarna = new List<int>();
            Random losuj = new Random();
            int liczba;

            for (int i = 0; i < 10; i++)
            {
                liczba = losuj.Next(0, 2);
                liczbaBinarna.Add(liczba);
            }

            return liczbaBinarna;
        }

        public void StopnieGrafuZTextboxa(List<int>liczbaBinarna)
        {
            listaStopniWierzcholkow.Sort();

            listaStopniMacierzy.Add((liczbaBinarna[0] + liczbaBinarna[1] + liczbaBinarna[2] + liczbaBinarna[3]));
            listaStopniMacierzy.Add((liczbaBinarna[4] + liczbaBinarna[5] + liczbaBinarna[6] + liczbaBinarna[0]));
            listaStopniMacierzy.Add((liczbaBinarna[1] + liczbaBinarna[4] + liczbaBinarna[7] + liczbaBinarna[8]));
            listaStopniMacierzy.Add((liczbaBinarna[2] + liczbaBinarna[5] + liczbaBinarna[7] + liczbaBinarna[9]));
            listaStopniMacierzy.Add((liczbaBinarna[3] + liczbaBinarna[6] + liczbaBinarna[8] + liczbaBinarna[9]));

            listaStopniMacierzy.Sort();

        }

        private void podanyGraf_Click(object sender, RoutedEventArgs e)
        {
            listaStopniWierzcholkow.Clear();
            ellipses.Clear();
            lines.Clear();
            can.Children.Clear();
            int sum = 0;

            iloscWierzcholkowArrayString = Regex.Split(wpiszWierzcholki.Text, " ");

            for (int i = 0; i < iloscWierzcholkowArrayString.Length; i++)
            {
                listaStopniWierzcholkow.Add(Int32.Parse(iloscWierzcholkowArrayString[i]));
            }

            for (int i = 0; i < listaStopniWierzcholkow.Count; i++)
            {
                sum += listaStopniWierzcholkow[i];
            }

            if ((sum % 2 == 0) && (listaStopniWierzcholkow.Count == 5))
            {
                StopnieGrafuZTextboxa(LosujLiczbe());

                while (!(listaStopniWierzcholkow.SequenceEqual(listaStopniMacierzy)) || (listaStopniMacierzy.Count == 0))
                {
                    listaStopniMacierzy.Clear();
                    StopnieGrafuZTextboxa(LosujLiczbe());

               }

                TworzElipsy();
                TworzLinie();
            }

            else
            {
                MessageBox.Show("Nieprawidłowy graf");
            }
        }

   
    }
}
