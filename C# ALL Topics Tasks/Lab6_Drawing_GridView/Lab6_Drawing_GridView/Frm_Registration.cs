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
    public partial class Frm_Registration : Form
    {

        List<Employee> employees = new List<Employee>();
       
        int empID = 0;
        public Frm_Registration()
        {
            InitializeComponent();
        }

        private void Frm_Registration_Load(object sender, EventArgs e)
        {
           
        }
        void RefreshData()
        {
            dgv_items.DataSource = null;
            dgv_items.DataSource = employees;
        }
        void AddEmp()
        {
            Employee emp = new Employee();
            emp.ID = empID;
            emp.Name = txt_name.Text;
            emp.Age = int.Parse(txt_Age.Text);
            emp.Address = txt_Address.Text;
            emp.Birthday = date_Birthday.Text;
            empID++;
            employees.Add(emp);
            RefreshData();
        }

        void Clear()
        {
            txt_Address.Text = "";
            txt_Age.Text = "";
            txt_name.Text = "";
            txt_name.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            AddEmp();
            Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            employees.RemoveAt(dgv_items.SelectedRows[0].Index);
            RefreshData();
           
        }

        private void dgv_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            employees.RemoveAt(dgv_items.SelectedRows[0].Index);
            
            AddEmp();
            RefreshData();
        }

        private void dgv_items_DoubleClick(object sender, EventArgs e)
        {
            txt_name.Text = dgv_items.CurrentRow.Cells[1].Value.ToString();
            txt_Age.Text = dgv_items.CurrentRow.Cells[2].Value.ToString();
            txt_Address.Text = dgv_items.CurrentRow.Cells[3].Value.ToString();
            date_Birthday.Text = dgv_items.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
