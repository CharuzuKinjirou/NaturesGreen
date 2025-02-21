
namespace Nature_s_Green
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PercentageLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogess = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nature_s_Green.Properties.Resources._274882724_1019926885572377_2734566522296931001_n;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.PercentageLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Myprogess);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 426);
            this.panel1.TabIndex = 1;
            // 
            // PercentageLbl
            // 
            this.PercentageLbl.AutoSize = true;
            this.PercentageLbl.BackColor = System.Drawing.Color.DimGray;
            this.PercentageLbl.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F);
            this.PercentageLbl.ForeColor = System.Drawing.Color.PaleGreen;
            this.PercentageLbl.Location = new System.Drawing.Point(318, 354);
            this.PercentageLbl.Name = "PercentageLbl";
            this.PercentageLbl.Size = new System.Drawing.Size(42, 32);
            this.PercentageLbl.TabIndex = 3;
            this.PercentageLbl.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(155, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading ...";
            // 
            // Myprogess
            // 
            this.Myprogess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Myprogess.Location = new System.Drawing.Point(34, 400);
            this.Myprogess.Name = "Myprogess";
            this.Myprogess.Size = new System.Drawing.Size(462, 14);
            this.Myprogess.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar Myprogess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PercentageLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

