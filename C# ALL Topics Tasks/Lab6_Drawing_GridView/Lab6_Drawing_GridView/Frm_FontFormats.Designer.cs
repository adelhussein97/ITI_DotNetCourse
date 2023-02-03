
namespace Lab6_Drawing_GridView
{
    partial class Frm_FontFormats
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_underline = new System.Windows.Forms.CheckBox();
            this.ch_italic = new System.Windows.Forms.CheckBox();
            this.ch_bold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sizefont = new System.Windows.Forms.NumericUpDown();
            this.cmb_fonts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_custom = new System.Windows.Forms.RadioButton();
            this.rdb_blue = new System.Windows.Forms.RadioButton();
            this.rdb_red = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sizefont)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ch_underline);
            this.groupBox1.Controls.Add(this.ch_italic);
            this.groupBox1.Controls.Add(this.ch_bold);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sizefont);
            this.groupBox1.Controls.Add(this.cmb_fonts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Format";
            // 
            // ch_underline
            // 
            this.ch_underline.AutoSize = true;
            this.ch_underline.Location = new System.Drawing.Point(169, 147);
            this.ch_underline.Name = "ch_underline";
            this.ch_underline.Size = new System.Drawing.Size(47, 34);
            this.ch_underline.TabIndex = 13;
            this.ch_underline.Text = "U";
            this.ch_underline.UseVisualStyleBackColor = true;
            // 
            // ch_italic
            // 
            this.ch_italic.AutoSize = true;
            this.ch_italic.Location = new System.Drawing.Point(118, 147);
            this.ch_italic.Name = "ch_italic";
            this.ch_italic.Size = new System.Drawing.Size(38, 34);
            this.ch_italic.TabIndex = 12;
            this.ch_italic.Text = "I";
            this.ch_italic.UseVisualStyleBackColor = true;
            // 
            // ch_bold
            // 
            this.ch_bold.AutoSize = true;
            this.ch_bold.Location = new System.Drawing.Point(67, 147);
            this.ch_bold.Name = "ch_bold";
            this.ch_bold.Size = new System.Drawing.Size(45, 34);
            this.ch_bold.TabIndex = 11;
            this.ch_bold.Text = "B";
            this.ch_bold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Size";
            // 
            // txt_sizefont
            // 
            this.txt_sizefont.Location = new System.Drawing.Point(67, 90);
            this.txt_sizefont.Name = "txt_sizefont";
            this.txt_sizefont.Size = new System.Drawing.Size(177, 36);
            this.txt_sizefont.TabIndex = 9;
            // 
            // cmb_fonts
            // 
            this.cmb_fonts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_fonts.FormattingEnabled = true;
            this.cmb_fonts.Location = new System.Drawing.Point(67, 55);
            this.cmb_fonts.Name = "cmb_fonts";
            this.cmb_fonts.Size = new System.Drawing.Size(177, 28);
            this.cmb_fonts.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fonts";
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_apply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_apply.Location = new System.Drawing.Point(280, 246);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(191, 30);
            this.btn_apply.TabIndex = 9;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_custom);
            this.groupBox2.Controls.Add(this.rdb_blue);
            this.groupBox2.Controls.Add(this.rdb_red);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 228);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Colors";
            // 
            // rdb_custom
            // 
            this.rdb_custom.AutoSize = true;
            this.rdb_custom.Location = new System.Drawing.Point(22, 146);
            this.rdb_custom.Name = "rdb_custom";
            this.rdb_custom.Size = new System.Drawing.Size(103, 34);
            this.rdb_custom.TabIndex = 2;
            this.rdb_custom.TabStop = true;
            this.rdb_custom.Text = "Custom";
            this.rdb_custom.UseVisualStyleBackColor = true;
            this.rdb_custom.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdb_blue
            // 
            this.rdb_blue.AutoSize = true;
            this.rdb_blue.Location = new System.Drawing.Point(22, 99);
            this.rdb_blue.Name = "rdb_blue";
            this.rdb_blue.Size = new System.Drawing.Size(73, 34);
            this.rdb_blue.TabIndex = 1;
            this.rdb_blue.TabStop = true;
            this.rdb_blue.Text = "Blue";
            this.rdb_blue.UseVisualStyleBackColor = true;
            // 
            // rdb_red
            // 
            this.rdb_red.AutoSize = true;
            this.rdb_red.Location = new System.Drawing.Point(22, 55);
            this.rdb_red.Name = "rdb_red";
            this.rdb_red.Size = new System.Drawing.Size(67, 34);
            this.rdb_red.TabIndex = 0;
            this.rdb_red.TabStop = true;
            this.rdb_red.Text = "Red";
            this.rdb_red.UseVisualStyleBackColor = true;
            // 
            // Frm_FontFormats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 282);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_FontFormats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_FontFormats";
            this.Load += new System.EventHandler(this.Frm_FontFormats_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sizefont)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_fonts;
        private System.Windows.Forms.CheckBox ch_underline;
        private System.Windows.Forms.CheckBox ch_italic;
        private System.Windows.Forms.CheckBox ch_bold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_sizefont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_custom;
        private System.Windows.Forms.RadioButton rdb_blue;
        private System.Windows.Forms.RadioButton rdb_red;
        public System.Windows.Forms.Button btn_apply;
    }
}