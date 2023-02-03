
namespace Lab6_Drawing_GridView
{
    partial class Frm_DrawingMouse
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
            this.SuspendLayout();
            // 
            // Frm_DrawingMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Name = "Frm_DrawingMouse";
            this.Text = "Frm_DrawingMouse";
            this.Load += new System.EventHandler(this.Frm_DrawingMouse_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_DrawingMouse_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_DrawingMouse_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_DrawingMouse_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}