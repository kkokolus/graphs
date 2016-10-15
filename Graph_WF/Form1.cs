using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_WF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = 400;
            
        }
        
        public void Rysuj()
        {
            /*Point p1 = new Point(50, 50);
            Point p2 = new Point(10, 10);*/
            Pen pen = new Pen(Color.Green);
            Graphics g = pictureBox1.CreateGraphics();
            //g.DrawLine(pen, p1, p2);
           // g.DrawEllipse(pen, 100, 50, 180, 180);

            Random r = new Random();
            int ile = 5;

            Point [] points = new Point[ile];

            for (int i = 0; i < ile; i++)
            {
                g.Clear(Form1.DefaultBackColor);
                int alpha = r.Next(-180, 180);
                
                points[i] = new Point((int)((pictureBox1.Width / 2) + 100 * Math.Cos(alpha)),
                                      (int)((pictureBox1.Height / 2) + 100 * Math.Sin(alpha)));

                int previous_alpha = alpha;
                if (previous_alpha - alpha < 30)
                {
                    alpha = r.Next(-180, 180);
                }
			}

            for (int i = 0; i < ile-1; i++)
            {
                
                g.DrawLine(pen, points[i], points[i+1]);
            }

            

          /*  int alpha = r.Next(-180, 180);
            Point p1 = new Point((int)(50 + 20 * Math.Cos(alpha)),
                                 (int)(50 + 20 * Math.Cos(alpha)));

            int beta = r.Next(-180, 180);

            Point p2 = new Point((int)(50 + 20 * Math.Cos(beta)),
                                 (int)(50 + 20 * Math.Cos(beta)));*/

            //g.DrawLine(pen, p1, p2);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Rysuj();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
