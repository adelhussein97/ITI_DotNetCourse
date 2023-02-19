
using DALContext;
using N_TierLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_AppEmploees
{
    public partial class Frm_Employees : Form
    {

        CLS_Employees cls_emp = new CLS_Employees();
        CLS_Department dept = new CLS_Department();
        Employee Emp = new Employee();
        public Frm_Employees()
        {
            InitializeComponent();
        }

        private void Frm_Registration_Load(object sender, EventArgs e)
        {
            RefreshData();
            FillCmbDept(sender,e);


        }
        public void FillCmbDept(object sender, EventArgs e)
        {
            cmb_Dept.DataSource = dept.Select_Department();
            cmb_Dept.DisplayMember = "Dname";
            cmb_Dept.ValueMember = "Dnum";
        }
        void RefreshData()
        {
            dgv_items.DataSource = null;
            dgv_items.DataSource = cls_emp.Select_Employees();
            txt_empID.Text = cls_emp.GetLastID().ToString();
        }
        

        void Clear()
        {
            txt_Salary.Text = "";
            txt_Lname.Text = "";
            txt_Fname.Text = "";
            txt_Fname.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Save Employee
            Emp.SSN = int.Parse(txt_empID.Text);
            Emp.Fname = txt_Fname.Text;
            Emp.Lname = txt_Lname.Text;
            Emp.Salary=int.Parse(txt_Salary.Text);
            Emp.Dno = int.Parse(cmb_Dept.SelectedValue.ToString());

            cls_emp.InsertEmp(Emp);
            RefreshData();
            Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgv_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update Employee
            Emp.SSN = int.Parse(txt_empID.Text);
            Emp.Fname = txt_Fname.Text;
            Emp.Lname = txt_Lname.Text;
            Emp.Salary = int.Parse(txt_Salary.Text);
            Emp.Dno = int.Parse(cmb_Dept.SelectedValue.ToString());
            cls_emp.UpdateEmp(Emp);
            RefreshData();
            Clear();
        }

        private void dgv_items_DoubleClick(object sender, EventArgs e)
        {
            txt_empID.Text = dgv_items.CurrentRow.Cells[0].Value.ToString();
            txt_Fname.Text = dgv_items.CurrentRow.Cells[1].Value.ToString();
            txt_Lname.Text = dgv_items.CurrentRow.Cells[2].Value.ToString();
            txt_Salary.Text = dgv_items.CurrentRow.Cells[3].Value.ToString();
            int idd = 0;
            bool res = int.TryParse(dgv_items.CurrentRow.Cells[4].Value.ToString(), out idd);

            cmb_Dept.SelectedValue = res ? idd : cmb_Dept.SelectedIndex;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Frm_Department frm = new Frm_Department();
            frm.Show();
            frm.RefreshCmbDept += FillCmbDept;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete Employee
            cls_emp.DeleteEmp(int.Parse(txt_empID.Text));
            RefreshData();
            Clear();
        }
    }
}
