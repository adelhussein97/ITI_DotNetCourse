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
    public partial class Frm_FontStyle : Form
    {
        public Frm_FontStyle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillColors();
            FillFonts();
        }

        void FillColors()
        {
            cmb_colors.DataSource = typeof(Color).GetProperties()
            .Where(x => x.PropertyType == typeof(Color))
             .Select(x => x.GetValue(null)).ToList();
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

        private void cmb_fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Font newFont= new Font(cmb_fonts.SelectedItem.ToString(), 12);
            txt_name.Font =newFont;
        }

        private void cmb_colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_name.ForeColor = (Color)cmb_colors.SelectedValue;
        }

        private void cmb_colors_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
