
namespace Lab6_Drawing_GridView
{
    partial class Frm_Inputs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_format = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your Name :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(113, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(296, 29);
            this.txt_name.TabIndex = 6;
            // 
            // btn_format
            // 
            this.btn_format.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_format.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_format.ForeColor = System.Drawing.Color.Black;
            this.btn_format.Location = new System.Drawing.Point(296, 96);
            this.btn_format.Name = "btn_format";
            this.btn_format.Size = new System.Drawing.Size(113, 38);
            this.btn_format.TabIndex = 14;
            this.btn_format.Text = "Format";
            this.btn_format.UseVisualStyleBackColor = false;
            this.btn_format.Click += new System.EventHandler(this.btn_format_Click);
            // 
            // Frm_Inputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 152);
            this.Controls.Add(this.btn_format);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Name = "Frm_Inputs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Inputs";
            this.Load += new System.EventHandler(this.Frm_Inputs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_format;
    }
}