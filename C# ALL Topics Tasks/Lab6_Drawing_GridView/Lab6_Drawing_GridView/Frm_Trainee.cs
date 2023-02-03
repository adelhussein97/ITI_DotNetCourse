using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Drawing_GridView
{
    public partial class Frm_Trainee : Form
    {
        
        List<string> Labs = new List<string>() { "Lab1","Lab2","Lab3" };
        List<Cls_Lab> lab = new List<Cls_Lab>();
        public Frm_Trainee()
        {
            InitializeComponent();
        }

        private void Frm_Trainee_Load(object sender, EventArgs e)
        {
            Fill_ListTrainee();
            cmb_Labs.DataSource = Labs;
            
        }
        void Fill_ListTrainee()
        {
            list_Trainee.Items.Add("Ahmed");
            list_Trainee.Items.Add("Ali");
            list_Trainee.Items.Add("Adel");
            list_Trainee.Items.Add("Mohamed");
            list_Trainee.Items.Add("Ragab");
            list_Trainee.Items.Add("Saleh");
            list_Trainee.Items.Add("Mostafa");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            
            // Checked from list trainee
            for (int i = list_Trainee.Items.Count - 1; i >= 0; i--)
            {
                if (list_Trainee.GetItemChecked(i))
                {
                    Cls_Lab cls = new Cls_Lab();
                    cls.labID = cmb_Labs.SelectedIndex;
                    cls.trainneName = list_Trainee.Items[i].ToString();
                    lab.Add(cls);
                    Lab_Trainee.Items.Clear();
                    Lab_Trainee.Items.AddRange(lab.FindAll(l=>l.labID==cmb_Labs.SelectedIndex).ToArray());

                    list_Trainee.Items.Remove(list_Trainee.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Move all trainee to lab
            for (int i = 0; i < list_Trainee.Items.Count; i++)
            {
                Cls_Lab cls = new Cls_Lab();
                cls.labID = cmb_Labs.SelectedIndex;
                cls.trainneName = list_Trainee.Items[i].ToString();
                lab.Add(cls);
                Lab_Trainee.Items.Add(lab);
                
            }
            list_Trainee.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Move Checked from lab to trainee
            for (int i = Lab_Trainee.Items.Count - 1; i >= 0; i--)
            {
                if (Lab_Trainee.GetItemChecked(i))
                {
                    list_Trainee.Items.Add(Lab_Trainee.Items[i].ToString());
                    Lab_Trainee.Items.Remove(Lab_Trainee.Items[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Move all labs to traineee
            for (int i = 0; i < Lab_Trainee.Items.Count; i++)
            {
                list_Trainee.Items.Add(Lab_Trainee.Items[i].ToString());
               
            }
            Lab_Trainee.Items.Clear();
        }

        private void cmb_Labs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lab_Trainee.Items.Clear();
            if(lab!=null)
            {
                foreach (Cls_Lab item in lab)
                {

                    if (item.labID == cmb_Labs.SelectedIndex)
                        Lab_Trainee.Items.Add(item.trainneName.ToString());

                }
            }
           
              
               
            
        }
    }
}
