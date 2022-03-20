using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Brown);
            Point[] points = new Point[4];
            //table
            g.DrawRectangle(pen,300, 300, 300, 4);
            g.FillRectangle(brush, 300, 300, 300, 4);
            //tlegs
            g.DrawRectangle(pen, 550, 304, 50, 70);
            g.FillRectangle(brush, 550, 304, 50, 70);
            g.DrawRectangle(pen, 300, 304, 50, 70);
            g.FillRectangle(brush, 300, 304, 50, 70);
            //comp
            brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, 550, 250, 30, 50);
            g.FillRectangle(brush, 550, 250, 30, 50);
            //monitor
            brush = new SolidBrush(Color.Blue);
            g.DrawRectangle(pen, 400, 230, 120, 60);
            g.FillRectangle(brush, 400, 230, 120, 60);
            brush = new SolidBrush(Color.Black);


            g.DrawRectangle(pen, 450, 290, 20, 10);
            g.FillRectangle(brush, 450, 290, 20, 10);


        }
    }
}
