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
   
    public partial class Frm_Department : Form
    {
        public event EventHandler RefreshCmbDept;
        CLS_Department cls_dept = new CLS_Department();
        Department dept = new Department();
        public Frm_Department()
        {
            InitializeComponent();
            RefreshData();
        }
        void RefreshData()
        {
            dgv_items.DataSource = null;
            dgv_items.DataSource = cls_dept.Select_Department();
            txt_deptID.Text = cls_dept.SelectLastDeptID().ToString();
        }
        void Clear()
        {
            txt_Dname.Text = "";
           
        }
        private void Frm_Department_Load(object sender, EventArgs e)
        {
            RefreshData();
            txt_Dname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // insert new departments
            dept.Dnum = int.Parse(txt_deptID.Text);
            dept.Dname = txt_Dname.Text;
            cls_dept.InsertDept(dept);
            RefreshData();
            Clear();
            
            RefreshCmbDept(sender, e);

        }

        private void dgv_items_Click(object sender, EventArgs e)
        {
            txt_deptID.Text = dgv_items.CurrentRow.Cells[0].Value.ToString();
            txt_Dname.Text = dgv_items.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update Dept
            dept.Dnum = int.Parse(txt_deptID.Text);
            dept.Dname = txt_Dname.Text;
            cls_dept.UpdateDept(dept);
            RefreshData();
            Clear();
            RefreshCmbDept(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls_dept.DeleteDept(int.Parse(txt_deptID.Text));
            RefreshData();
            Clear();
        }
    }
}
