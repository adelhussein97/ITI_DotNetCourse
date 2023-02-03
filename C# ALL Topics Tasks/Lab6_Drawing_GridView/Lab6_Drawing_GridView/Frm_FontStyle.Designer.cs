
namespace Lab6_Drawing_GridView
{
    partial class Frm_FontStyle
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
            this.cmb_fonts = new System.Windows.Forms.ComboBox();
            this.cmb_colors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(117, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(255, 29);
            this.txt_name.TabIndex = 0;
            // 
            // cmb_fonts
            // 
            this.cmb_fonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fonts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_fonts.FormattingEnabled = true;
            this.cmb_fonts.Location = new System.Drawing.Point(12, 87);
            this.cmb_fonts.Name = "cmb_fonts";
            this.cmb_fonts.Size = new System.Drawing.Size(177, 28);
            this.cmb_fonts.TabIndex = 1;
            this.cmb_fonts.SelectedIndexChanged += new System.EventHandler(this.cmb_fonts_SelectedIndexChanged);
            // 
            // cmb_colors
            // 
            this.cmb_colors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_colors.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_colors.FormattingEnabled = true;
            this.cmb_colors.Location = new System.Drawing.Point(195, 87);
            this.cmb_colors.Name = "cmb_colors";
            this.cmb_colors.Size = new System.Drawing.Size(177, 28);
            this.cmb_colors.TabIndex = 2;
            this.cmb_colors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_colors_DrawItem);
            this.cmb_colors.SelectedIndexChanged += new System.EventHandler(this.cmb_colors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fonts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Name :";
            // 
            // Frm_FontStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 141);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_colors);
            this.Controls.Add(this.cmb_fonts);
            this.Controls.Add(this.txt_name);
            this.Name = "Frm_FontStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Styling Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_fonts;
        private System.Windows.Forms.ComboBox cmb_colors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

