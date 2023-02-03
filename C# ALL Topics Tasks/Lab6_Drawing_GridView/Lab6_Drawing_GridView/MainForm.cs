using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Drawing_GridView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ShowConversion_Click(object sender, EventArgs e)
        {
            Frm_FontStyle frm = new Frm_FontStyle();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Registration frm = new Frm_Registration();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Trainee frm = new Frm_Trainee();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Frm_DrawingMouse frm = new Frm_DrawingMouse();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Inputs frm = new Frm_Inputs();
            frm.ShowDialog();
        }
    }
}
