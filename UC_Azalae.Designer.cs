namespace Nature_s_Green
{
    partial class UC_Azalae
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Azalae));
            this.UC_AlzaePnl = new System.Windows.Forms.Panel();
            this.AlzaeInfo = new System.Windows.Forms.RichTextBox();
            this.UC_AlzaePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // UC_AlzaePnl
            // 
            this.UC_AlzaePnl.BackgroundImage = global::Nature_s_Green.Properties.Resources.UC_pictures_BG;
            this.UC_AlzaePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UC_AlzaePnl.Controls.Add(this.AlzaeInfo);
            this.UC_AlzaePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_AlzaePnl.Location = new System.Drawing.Point(0, 0);
            this.UC_AlzaePnl.Name = "UC_AlzaePnl";
            this.UC_AlzaePnl.Size = new System.Drawing.Size(600, 516);
            this.UC_AlzaePnl.TabIndex = 0;
            // 
            // AlzaeInfo
            // 
            this.AlzaeInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.AlzaeInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlzaeInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlzaeInfo.Location = new System.Drawing.Point(24, 28);
            this.AlzaeInfo.Name = "AlzaeInfo";
            this.AlzaeInfo.Size = new System.Drawing.Size(545, 465);
            this.AlzaeInfo.TabIndex = 0;
            this.AlzaeInfo.Text = resources.GetString("AlzaeInfo.Text");
            // 
            // UC_Azalae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_AlzaePnl);
            this.Name = "UC_Azalae";
            this.Size = new System.Drawing.Size(600, 516);
            this.UC_AlzaePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UC_AlzaePnl;
        private System.Windows.Forms.RichTextBox AlzaeInfo;
    }
}
