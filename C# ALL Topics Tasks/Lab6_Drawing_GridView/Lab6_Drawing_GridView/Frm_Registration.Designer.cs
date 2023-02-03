
namespace Lab6_Drawing_GridView
{
    partial class Frm_Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.date_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(117, 22);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(255, 29);
            this.txt_name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address :";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Address.Location = new System.Drawing.Point(117, 110);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(255, 29);
            this.txt_Address.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Age :";
            // 
            // txt_Age
            // 
            this.txt_Age.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Age.Location = new System.Drawing.Point(117, 66);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(255, 29);
            this.txt_Age.TabIndex = 8;
            // 
            // date_Birthday
            // 
            this.date_Birthday.Location = new System.Drawing.Point(117, 146);
            this.date_Birthday.Name = "date_Birthday";
            this.date_Birthday.Size = new System.Drawing.Size(255, 23);
            this.date_Birthday.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday :";
            // 
            // dgv_items
            // 
            this.dgv_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_items.Location = new System.Drawing.Point(0, 238);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RowTemplate.Height = 25;
            this.dgv_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_items.Size = new System.Drawing.Size(700, 236);
            this.dgv_items.TabIndex = 12;
            this.dgv_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_items_CellContentClick);
            this.dgv_items.DoubleClick += new System.EventHandler(this.dgv_items_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(117, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(236, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(355, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_Birthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Name = "Frm_Registration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.DateTimePicker date_Birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

