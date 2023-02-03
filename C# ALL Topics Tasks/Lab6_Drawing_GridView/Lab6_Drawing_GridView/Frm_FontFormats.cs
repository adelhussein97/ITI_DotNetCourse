using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Drawing_GridView
{
    public partial class Frm_FontFormats : Form
    {
        ColorDialog color = new ColorDialog();
       
        public event EventHandler StylingChanged;

        public Font styleFonts 
        { 
            get
            {
                if(ch_bold.Checked )
                    return new Font(cmb_fonts.Text,float.Parse(txt_sizefont.Value.ToString()), FontStyle.Bold | FontStyle.Italic);
                else if(ch_italic.Checked)
                    return new Font(cmb_fonts.Text, float.Parse(txt_sizefont.Value.ToString()),FontStyle.Italic);
                else if (ch_underline.Checked)
                    return new Font(cmb_fonts.Text, float.Parse(txt_sizefont.Value.ToString()), FontStyle.Underline);
                else
                    return new Font(cmb_fonts.Text, float.Parse(txt_sizefont.Value.ToString()), FontStyle.Regular);

            }

        }
        public Color collorStyling { 
            get 
            {
                if (rdb_red.Checked)
                    return Color.Red;
                else if (rdb_blue.Checked)
                    return Color.Blue;
                else if (rdb_custom.Checked)
                    return color.Color;
                else
                    return Color.Black;

            }
        }
        public Frm_FontFormats()
        {
            InitializeComponent();
            FillFonts();
        }
        void FillFonts()
        {
            List<string> fonts = new List<string>();

            foreach (FontFamily font in FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            cmb_fonts.DataSource = fonts;

        }
        private void Frm_FontFormats_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StylingChanged != null)
                StylingChanged(sender, null);
        }
    }
}
