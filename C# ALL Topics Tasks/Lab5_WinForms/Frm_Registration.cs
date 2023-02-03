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
    public partial class Frm_Registration : Form
    {
        public Frm_Registration()
        {
            InitializeComponent();
        }

        private void btn_ShowConversion_Click(object sender, EventArgs e)
        {
            Frm_Registration frm = new Frm_Registration();
            frm.ShowDialog();
        }

        bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || txt_name.TextLength < 5)
            {
                lbl_ErrorName.Text = "At Least Length 5 Characters";
                return false;
            }
            if (!txt_email.Text.Contains("@"))
            {
                lbl_ErrorEmail.Text = "Emails Contains @ ";
                return false;
            }
            if(!rdb_male.Checked && !rdb_female.Checked)
            {
                lbl_Errorgender.Text = "check Gender ";
                return false;
            }
            if (!ch_football.Checked && !ch_swimming.Checked && !ch_tennis.Checked)
            {
                lbl_ErrorHoppies.Text = "check at Least one Hoppy ";
                return false;
            }
            else
                return true;
            


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                lbl_ErrorEmail.Text = "";
                lbl_Errorgender.Text = "";
                lbl_ErrorHoppies.Text="";
                lbl_ErrorName.Text = "";
                lbl_success.Text = "Your Data Registerd Successfully";
            }
        }
    }
}
