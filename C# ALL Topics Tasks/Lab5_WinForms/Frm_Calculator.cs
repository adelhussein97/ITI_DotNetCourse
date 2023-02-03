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
    public partial class Frm_Calculator : Form
    {
        double firstNo = 0, secondNo = 0;
        char Operator;
        public Frm_Calculator()
        {
            InitializeComponent();
        }

        private void btn_ShowConversion_Click(object sender, EventArgs e)
        {
           
        }

        private void rdb_MtoKM_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
           txtDisplay.Text +="1";
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstNo = double.Parse(txtDisplay.Text);
            txtDisplay.Text += "+";
            Operator = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNo = double.Parse(txtDisplay.Text);
            txtDisplay.Text += "-";
            Operator = '-';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNo = double.Parse(txtDisplay.Text);
            txtDisplay.Text += "*";
            Operator = '*';
        }

        private void button39_Click(object sender, EventArgs e)
        {
            firstNo = double.Parse(txtDisplay.Text);
            txtDisplay.Text += "/";
            Operator = '/';
        }

        private void button33_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Contains(".")==true)
                txtDisplay.Text += ".";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {

            secondNo = double.Parse(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(Operator)+1));
            txtDisplay.Text += "=";
            txt_history.Text += txtDisplay.Text;
            switch (Operator)
            {
                case '+':
                    txtDisplay.Text = (firstNo + secondNo).ToString();
                    txt_history.Text += txtDisplay.Text+"\r\n";
                    break;
                case '-':
                    txtDisplay.Text = (firstNo - secondNo).ToString();
                    txt_history.Text += txtDisplay.Text+"\r\n";
                    break;
                case '*':
                    txtDisplay.Text = (firstNo * secondNo).ToString();
                    txt_history.Text += txtDisplay.Text + "\r\n";
                    break;
                case '/':
                    txtDisplay.Text = (firstNo / secondNo).ToString();
                    txt_history.Text += txtDisplay.Text+"\r\n";
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txt_history.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtDisplay.Text))
                txtDisplay.Text =txtDisplay.Text.Substring(0,txtDisplay.TextLength-1);
        }

        private void Frm_Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
