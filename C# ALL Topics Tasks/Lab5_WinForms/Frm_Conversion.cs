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
    public partial class Frm_Conversion : Form
    {
        public Frm_Conversion()
        {
            InitializeComponent();
        }

        private void btn_ShowConversion_Click(object sender, EventArgs e)
        {
           
        }

        private void rdb_MtoKM_CheckedChanged(object sender, EventArgs e)
        {
            if(txt_Value.Text!="")
            {
                if (rdb_MtoKM.Checked)
                    txt_Result.Text = (Convert.ToDouble(txt_Value.Text) / 1000).ToString();
                if (rdb_MToMill.Checked)
                    txt_Result.Text = (Convert.ToDouble(txt_Value.Text) * 1000).ToString();
                if (rdb_MillToM.Checked)
                    txt_Result.Text = (Convert.ToDouble(txt_Value.Text) / 1000).ToString();
            }
        }

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
            if (txt_Value.Text == "")
                txt_Value.Text = "0";
        }
    }
}
