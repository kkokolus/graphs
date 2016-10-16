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

namespace Graph_WF
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
            visualization.Width = 400;
            Punkty();
        }

        string[] num_of_vert;
        int alpha;
        Random r = new Random();
        // Generowanie punktow na okregu
        Dictionary<Point, int> points = new Dictionary<Point, int>();

        public void Punkty()
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
            vertexes.KeyUp += TextBoxKeyUp;
            // to sie teraz wykonalo string[] num_of_vert = Regex.Split(vertexes.Text, ", ");



            
        }


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





        // Nacisniecie entera w textboxie
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
        }








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
         //   Rysuj();
            
        }

        private void visualization_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vertexes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
