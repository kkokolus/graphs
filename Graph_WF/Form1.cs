using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Specialized;

namespace Graph_WF
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            visualization.Width = 400;


        }

        string[] num_of_vert;
        int alpha;
        Random r = new Random();
        // Generowanie punktow na okregu
        // OrderedDictionary points = new OrderedDictionary();
        Dictionary<Point, int> points = new Dictionary<Point, int>();
        List<Point> list_of_points;
        List<int> list_of_values;

        /* public void Punkty()
         {
             /* Point p1 = new Point(50, 50);
             Point p2 = new Point(10, 10); */
        //Pen pen = new Pen(Color.Green);
        // Graphics g = visualization.CreateGraphics();
        // g.DrawLine(pen, p1, p2);
        // g.DrawEllipse(pen, 100, 50, 180, 180);


        // int ile = 5;


        //NOWE


        //dziala na enter
        //   vertexes.KeyUp += TextBoxKeyUp;
        // to sie teraz wykonalo string[] num_of_vert = Regex.Split(vertexes.Text, ", ");
        // teraz masz slownik gdzie key to punkt a value to ilosc krawedzi






        //    }


        /* points.Add(Regex.Split(vertexes.Text, ", ");









         for (int i = 0; i < ile; i++)
         {
             g.Clear(Form1.DefaultBackColor);
             alpha = r.Next(-180, 180);

             points[i] = new Point((int)((visualization.Width / 2) + 100 * Math.Cos(alpha)),
                                   (int)((visualization.Height / 2) + 100 * Math.Sin(alpha)));
         }

         // Odstep miedzy punktami
         for (int i = 0; i < points.Length - 1; i++)
         {
             foreach (Point p in points)
             {
                 if (p != points[i] && (Math.Abs(p.X - points[i].X) <= 40 || Math.Abs(p.Y - points[i].Y) <= 40))
                 {
                     alpha = r.Next(-180, 180);
                     points[i] = new Point((int)((visualization.Width / 2) + 100 * Math.Cos(alpha)),
                                  (int)((visualization.Height / 2) + 100 * Math.Sin(alpha)));
                 }
             };

         }

     }
         // Rysowanie krawedzi

         void Rysuj()
         {
             Pen pen = new Pen(Color.Green);
             Graphics g = visualization.CreateGraphics();



         for (int i = 0; i < ile - 1; i++)
             {
                 g.DrawLine(pen, points[i], points[i + 1]);
             }
          }*/







        //Generowanie punktu
        public Point random_point()
        {
            alpha = r.Next(-180, 180);
            return new Point((int)((visualization.Width / 2) + 100 * Math.Cos(alpha)),
                                   (int)((visualization.Height / 2) + 100 * Math.Sin(alpha)));
        }





     /*   // Nacisniecie entera w textboxie
        private void TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                num_of_vert = Regex.Split(vertexes.Text, ", ");
                // Rysuj();
               
                foreach (string v in num_of_vert)
                {
                    points.Add(random_point(), Convert.ToInt32(v));
                }
            }

            */
            


        public void generate_points()
        {
            num_of_vert = Regex.Split(vertexes.Text, ", ");
            
            foreach (string v in num_of_vert)
            {
                points.Add(random_point(), Convert.ToInt32(v));
            }

            list_of_points = points.Keys.ToList();
            list_of_values = points.Values.ToList();
        }


        public void draw()
        {
            Pen pen = new Pen(Color.Green);
            Graphics g = visualization.CreateGraphics();

            int j;

            for (int i = 0; i < num_of_vert.Length; i++)
            {
                j = 1;

                for (; j < list_of_values[i]+1; j++)
                {
                    g.DrawLine(pen, list_of_points[i], list_of_points[j]);
                }

                j++;
            }
           

        }

        
            /*   foreach (var p in points)
               {
                   g.DrawLine(pen, p, points.ElementAt(1));
               }
   
            for (int i = 0; i < num_of_vert.Length - 1; i++)
            {
                points.ElementAt(i);
            }
        }*/





        /*  int alpha = r.Next(-180, 180);
          Point p1 = new Point((int)(50 + 20 * Math.Cos(alpha)),
                               (int)(50 + 20 * Math.Cos(alpha)));

          int beta = r.Next(-180, 180);

          Point p2 = new Point((int)(50 + 20 * Math.Cos(beta)),
                               (int)(50 + 20 * Math.Cos(beta)));*/

        //g.DrawLine(pen, p1, p2);

            


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void visualization_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vertexes_TextChanged(object sender, EventArgs e)
        {

        }

        private void drw_Click(object sender, EventArgs e)
        {
            generate_points();
            draw();

        }
    }}

