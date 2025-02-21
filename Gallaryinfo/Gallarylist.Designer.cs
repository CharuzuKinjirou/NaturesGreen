namespace Nature_s_Green.Gallaryinfo
{
    partial class Gallarylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slide = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
            this.SuspendLayout();
            // 
            // slide
            // 
            this.slide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slide.Image = global::Nature_s_Green.Properties.Resources.Welcome_BG_btn;
            this.slide.Location = new System.Drawing.Point(0, 0);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(604, 527);
            this.slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slide.TabIndex = 0;
            this.slide.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Gallarylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.slide);
            this.Name = "Gallarylist";
            this.Size = new System.Drawing.Size(604, 527);
            ((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slide;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
