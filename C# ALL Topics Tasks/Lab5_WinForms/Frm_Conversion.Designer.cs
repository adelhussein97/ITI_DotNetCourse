
namespace Lab5_WinForms
{
    partial class Frm_Conversion
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
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_MtoKM = new System.Windows.Forms.RadioButton();
            this.rdb_MillToM = new System.Windows.Forms.RadioButton();
            this.rdb_MToMill = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ShowConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Value
            // 
            this.txt_Value.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Value.Location = new System.Drawing.Point(92, 44);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(122, 27);
            this.txt_Value.TabIndex = 0;
            this.txt_Value.Text = "0";
            this.txt_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Value.TextChanged += new System.EventHandler(this.txt_Value_TextChanged);
            // 
            // txt_Result
            // 
            this.txt_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Result.Location = new System.Drawing.Point(92, 90);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.Size = new System.Drawing.Size(122, 27);
            this.txt_Result.TabIndex = 1;
            this.txt_Result.Text = "0";
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // rdb_MtoKM
            // 
            this.rdb_MtoKM.AutoSize = true;
            this.rdb_MtoKM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_MtoKM.Location = new System.Drawing.Point(313, 40);
            this.rdb_MtoKM.Name = "rdb_MtoKM";
            this.rdb_MtoKM.Size = new System.Drawing.Size(115, 24);
            this.rdb_MtoKM.TabIndex = 4;
            this.rdb_MtoKM.TabStop = true;
            this.rdb_MtoKM.Text = "Meter To KM";
            this.rdb_MtoKM.UseVisualStyleBackColor = true;
            this.rdb_MtoKM.CheckedChanged += new System.EventHandler(this.rdb_MtoKM_CheckedChanged);
            // 
            // rdb_MillToM
            // 
            this.rdb_MillToM.AutoSize = true;
            this.rdb_MillToM.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_MillToM.Location = new System.Drawing.Point(313, 90);
            this.rdb_MillToM.Name = "rdb_MillToM";
            this.rdb_MillToM.Size = new System.Drawing.Size(126, 24);
            this.rdb_MillToM.TabIndex = 5;
            this.rdb_MillToM.TabStop = true;
            this.rdb_MillToM.Text = "Mille To Meter";
            this.rdb_MillToM.UseVisualStyleBackColor = true;
            this.rdb_MillToM.CheckedChanged += new System.EventHandler(this.rdb_MtoKM_CheckedChanged);
            // 
            // rdb_MToMill
            // 
            this.rdb_MToMill.AutoSize = true;
            this.rdb_MToMill.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_MToMill.Location = new System.Drawing.Point(313, 65);
            this.rdb_MToMill.Name = "rdb_MToMill";
            this.rdb_MToMill.Size = new System.Drawing.Size(126, 24);
            this.rdb_MToMill.TabIndex = 6;
            this.rdb_MToMill.TabStop = true;
            this.rdb_MToMill.Text = "Meter To Mille";
            this.rdb_MToMill.UseVisualStyleBackColor = true;
            this.rdb_MToMill.CheckedChanged += new System.EventHandler(this.rdb_MtoKM_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Converter";
            // 
            // btn_ShowConversion
            // 
            this.btn_ShowConversion.Font = new System.Drawing.Font("Andalus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_ShowConversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ShowConversion.Location = new System.Drawing.Point(167, 132);
            this.btn_ShowConversion.Name = "btn_ShowConversion";
            this.btn_ShowConversion.Size = new System.Drawing.Size(143, 48);
            this.btn_ShowConversion.TabIndex = 8;
            this.btn_ShowConversion.Text = "Convert";
            this.btn_ShowConversion.UseVisualStyleBackColor = true;
            this.btn_ShowConversion.Click += new System.EventHandler(this.rdb_MtoKM_CheckedChanged);
            // 
            // Frm_Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 192);
            this.Controls.Add(this.btn_ShowConversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_MToMill);
            this.Controls.Add(this.rdb_MillToM);
            this.Controls.Add(this.rdb_MtoKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_Value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Conversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                 Conversion Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_MtoKM;
        private System.Windows.Forms.RadioButton rdb_MillToM;
        private System.Windows.Forms.RadioButton rdb_MToMill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ShowConversion;
    }
}

