using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ShowConversion_Click(object sender, EventArgs e)
        {
            Frm_Conversion frm = new Frm_Conversion();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Registration frm = new Frm_Registration();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Calculator frm = new Frm_Calculator();
            frm.ShowDialog();
        }
    }
}
