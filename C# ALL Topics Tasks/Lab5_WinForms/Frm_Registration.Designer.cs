
namespace Lab5_WinForms
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_ErrorName = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ch_football = new System.Windows.Forms.CheckBox();
            this.ch_tennis = new System.Windows.Forms.CheckBox();
            this.ch_swimming = new System.Windows.Forms.CheckBox();
            this.lbl_ErrorHoppies = new System.Windows.Forms.Label();
            this.lbl_ErrorEmail = new System.Windows.Forms.Label();
            this.lbl_Errorgender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Andalus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(282, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(321, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Registration Form";
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_female.Location = new System.Drawing.Point(253, 128);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(76, 24);
            this.rdb_female.TabIndex = 15;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_male.Location = new System.Drawing.Point(148, 128);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(61, 24);
            this.rdb_male.TabIndex = 13;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Your Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Your Name :";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_email.Location = new System.Drawing.Point(152, 83);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(213, 27);
            this.txt_email.TabIndex = 10;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(154, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 27);
            this.txt_name.TabIndex = 9;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ErrorName
            // 
            this.lbl_ErrorName.AutoSize = true;
            this.lbl_ErrorName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ErrorName.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorName.Location = new System.Drawing.Point(371, 37);
            this.lbl_ErrorName.Name = "lbl_ErrorName";
            this.lbl_ErrorName.Size = new System.Drawing.Size(0, 20);
            this.lbl_ErrorName.TabIndex = 17;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_success.ForeColor = System.Drawing.Color.Green;
            this.lbl_success.Location = new System.Drawing.Point(358, 296);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(0, 20);
            this.lbl_success.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hoppies :";
            // 
            // ch_football
            // 
            this.ch_football.AutoSize = true;
            this.ch_football.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ch_football.Location = new System.Drawing.Point(148, 183);
            this.ch_football.Name = "ch_football";
            this.ch_football.Size = new System.Drawing.Size(84, 24);
            this.ch_football.TabIndex = 21;
            this.ch_football.Text = "Football";
            this.ch_football.UseVisualStyleBackColor = true;
            // 
            // ch_tennis
            // 
            this.ch_tennis.AutoSize = true;
            this.ch_tennis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ch_tennis.Location = new System.Drawing.Point(253, 183);
            this.ch_tennis.Name = "ch_tennis";
            this.ch_tennis.Size = new System.Drawing.Size(69, 24);
            this.ch_tennis.TabIndex = 22;
            this.ch_tennis.Text = "tennis";
            this.ch_tennis.UseVisualStyleBackColor = true;
            // 
            // ch_swimming
            // 
            this.ch_swimming.AutoSize = true;
            this.ch_swimming.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ch_swimming.Location = new System.Drawing.Point(343, 182);
            this.ch_swimming.Name = "ch_swimming";
            this.ch_swimming.Size = new System.Drawing.Size(99, 24);
            this.ch_swimming.TabIndex = 23;
            this.ch_swimming.Text = "Swimming";
            this.ch_swimming.UseVisualStyleBackColor = true;
            // 
            // lbl_ErrorHoppies
            // 
            this.lbl_ErrorHoppies.AutoSize = true;
            this.lbl_ErrorHoppies.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ErrorHoppies.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorHoppies.Location = new System.Drawing.Point(458, 179);
            this.lbl_ErrorHoppies.Name = "lbl_ErrorHoppies";
            this.lbl_ErrorHoppies.Size = new System.Drawing.Size(0, 20);
            this.lbl_ErrorHoppies.TabIndex = 18;
            // 
            // lbl_ErrorEmail
            // 
            this.lbl_ErrorEmail.AutoSize = true;
            this.lbl_ErrorEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorEmail.Location = new System.Drawing.Point(371, 90);
            this.lbl_ErrorEmail.Name = "lbl_ErrorEmail";
            this.lbl_ErrorEmail.Size = new System.Drawing.Size(0, 20);
            this.lbl_ErrorEmail.TabIndex = 24;
            // 
            // lbl_Errorgender
            // 
            this.lbl_Errorgender.AutoSize = true;
            this.lbl_Errorgender.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Errorgender.ForeColor = System.Drawing.Color.Red;
            this.lbl_Errorgender.Location = new System.Drawing.Point(371, 132);
            this.lbl_Errorgender.Name = "lbl_Errorgender";
            this.lbl_Errorgender.Size = new System.Drawing.Size(0, 20);
            this.lbl_Errorgender.TabIndex = 25;
            // 
            // Frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 322);
            this.Controls.Add(this.lbl_Errorgender);
            this.Controls.Add(this.lbl_ErrorEmail);
            this.Controls.Add(this.ch_swimming);
            this.Controls.Add(this.ch_tennis);
            this.Controls.Add(this.ch_football);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ErrorHoppies);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_ErrorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdb_female);
            this.Controls.Add(this.rdb_male);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                 Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_ErrorName;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ch_football;
        private System.Windows.Forms.CheckBox ch_tennis;
        private System.Windows.Forms.CheckBox ch_swimming;
        private System.Windows.Forms.Label lbl_ErrorHoppies;
        private System.Windows.Forms.Label lbl_ErrorEmail;
        private System.Windows.Forms.Label lbl_Errorgender;
    }
}

