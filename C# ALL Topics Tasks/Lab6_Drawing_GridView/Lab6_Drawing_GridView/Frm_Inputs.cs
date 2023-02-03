using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Drawing_GridView
{
   
    public partial class Frm_Inputs : Form
    {
        
        Frm_FontFormats frmstyle = new Frm_FontFormats();
        public Frm_Inputs()
        {
            InitializeComponent();
           
        }

        private void btn_format_Click(object sender, EventArgs e)
        {
           
            frmstyle.Show();
            frmstyle.StylingChanged += ChangeStyle;
        }

        private void ChangeStyle(object sender, EventArgs e)
        {
            txt_name.Font = frmstyle.styleFonts;
            txt_name.ForeColor = frmstyle.collorStyling;
        }

        private void Frm_Inputs_Load(object sender, EventArgs e)
        {

        }
    }
}
