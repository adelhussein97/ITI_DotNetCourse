
namespace Lab5_WinForms
{
    partial class Frm_Calculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button39 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_history = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisplay.Location = new System.Drawing.Point(4, 19);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDisplay.Size = new System.Drawing.Size(268, 37);
            this.txtDisplay.TabIndex = 20;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(210, 303);
            this.button39.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(62, 51);
            this.button39.TabIndex = 18;
            this.button39.Text = "/";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(210, 246);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(62, 51);
            this.button16.TabIndex = 17;
            this.button16.Text = "*";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(210, 188);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(62, 51);
            this.button12.TabIndex = 16;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(210, 130);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 51);
            this.button8.TabIndex = 15;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(210, 72);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "<--";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Equal
            // 
            this.btn_Equal.Location = new System.Drawing.Point(142, 303);
            this.btn_Equal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(62, 51);
            this.btn_Equal.TabIndex = 13;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(142, 246);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(62, 51);
            this.button15.TabIndex = 12;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(142, 188);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(62, 51);
            this.button11.TabIndex = 19;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(142, 130);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 51);
            this.button7.TabIndex = 2;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 72);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(73, 303);
            this.button35.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(62, 51);
            this.button35.TabIndex = 8;
            this.button35.Text = ".";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(73, 246);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(62, 51);
            this.button14.TabIndex = 7;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(73, 188);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(62, 51);
            this.button10.TabIndex = 6;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 130);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 51);
            this.button6.TabIndex = 5;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(4, 303);
            this.button33.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(62, 51);
            this.button33.TabIndex = 4;
            this.button33.Text = "0";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(4, 246);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(62, 51);
            this.button13.TabIndex = 3;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(4, 188);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 51);
            this.button9.TabIndex = 10;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 130);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 51);
            this.button5.TabIndex = 11;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_history
            // 
            this.txt_history.BackColor = System.Drawing.Color.White;
            this.txt_history.Enabled = false;
            this.txt_history.Location = new System.Drawing.Point(279, 19);
            this.txt_history.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_history.Multiline = true;
            this.txt_history.Name = "txt_history";
            this.txt_history.ReadOnly = true;
            this.txt_history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_history.Size = new System.Drawing.Size(140, 335);
            this.txt_history.TabIndex = 21;
            this.txt_history.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(422, 372);
            this.Controls.Add(this.txt_history);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                       Calculator Form";
            this.Load += new System.EventHandler(this.Frm_Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_history;
    }
}

