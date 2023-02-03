using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Drawing_GridView
{
    public partial class Frm_DrawingMouse : Form
    {
        Point lastPoint;
        public Frm_DrawingMouse()
        {
            InitializeComponent();
        }

        private void Frm_DrawingMouse_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.FillRectangle(Brushes.Blue, e.X, e.Y,10,10);
            // graphics.DrawLine(Pens.Black, lastPoint, e.Location);


        }

        

        private void Frm_DrawingMouse_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void Frm_DrawingMouse_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            graphics.FillRectangle(Brushes.White, e.X, e.Y,20,20);
        }

        private void Frm_DrawingMouse_Load(object sender, EventArgs e)
        {

        }
    }
}
