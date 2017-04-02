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

namespace Graphs
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        string[] number_of_vertexes_ArrayString;
        List<int> list_of_vertex_degrees = new List<int>();
        List<int> list_of_matrix_degrees = new List<int>();
        List<Ellipse> ellipses = new List<Ellipse>();
        List<Line> lines = new List<Line>();     

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Create_ellipses()
        {
            Random number = new Random();

            for (int j = 0; j < 5; j++)
            {
                ellipses.Add(new Ellipse()
                {
                    Width = 20,
                    Height = 20,
                    Fill = Brushes.Orange,
                    Margin = new Thickness(number.Next(0, Convert.ToInt32(can.Width)),
                    number.Next(0, Convert.ToInt32(can.Height)), 0, 0)
                });
            }
          
        }

        public void Create_lines()
        {
            int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (k < 10)
                    {
                        if (Generate_number()[k] == 1)
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


         public List<int> Generate_number()
        {
            List<int> binary_number = new List<int>();
            Random generate = new Random();
            int number;

            for (int i = 0; i < 10; i++)
            {
                number = generate.Next(0, 2);
                binary_number.Add(number);
            }

            return binary_number;
        }

        public void Vetrexes_degrees(List<int>liczbaBinarna)
        {
            list_of_vertex_degrees.Sort();

            list_of_matrix_degrees.Add((liczbaBinarna[0] + liczbaBinarna[1] + liczbaBinarna[2] + liczbaBinarna[3]));
            list_of_matrix_degrees.Add((liczbaBinarna[4] + liczbaBinarna[5] + liczbaBinarna[6] + liczbaBinarna[0]));
            list_of_matrix_degrees.Add((liczbaBinarna[1] + liczbaBinarna[4] + liczbaBinarna[7] + liczbaBinarna[8]));
            list_of_matrix_degrees.Add((liczbaBinarna[2] + liczbaBinarna[5] + liczbaBinarna[7] + liczbaBinarna[9]));
            list_of_matrix_degrees.Add((liczbaBinarna[3] + liczbaBinarna[6] + liczbaBinarna[8] + liczbaBinarna[9]));

            list_of_matrix_degrees.Sort();

        }

        private void given_graph_Click(object sender, RoutedEventArgs e)
        {
            list_of_vertex_degrees.Clear();
            ellipses.Clear();
            lines.Clear();
            can.Children.Clear();
            int sum = 0;

            number_of_vertexes_ArrayString = Regex.Split(enter_vertexes.Text, " ");

            for (int i = 0; i < number_of_vertexes_ArrayString.Length; i++)
            {
                list_of_vertex_degrees.Add(Int32.Parse(number_of_vertexes_ArrayString[i]));
            }

            for (int i = 0; i < list_of_vertex_degrees.Count; i++)
            {
                sum += list_of_vertex_degrees[i];
            }

            if ((sum % 2 == 0) && (list_of_vertex_degrees.Count == 5))
            {
                Vetrexes_degrees(Generate_number());

                while (!(list_of_vertex_degrees.SequenceEqual(list_of_matrix_degrees)) || (list_of_matrix_degrees.Count == 0))
                {
                    list_of_matrix_degrees.Clear();
                    Vetrexes_degrees(Generate_number());

               }

                Create_ellipses();
                Create_lines();
            }

            else
            {
                MessageBox.Show("Incorrect graph");
            }
        }

   
    }
}
