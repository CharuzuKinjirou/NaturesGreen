namespace Nature_s_Green
{
    partial class UC_Pachira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Pachira));
            this.panel = new System.Windows.Forms.Panel();
            this.CactusInfo = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Nature_s_Green.Properties.Resources.UC_pictures_BG;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.CactusInfo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(600, 516);
            this.panel.TabIndex = 1;
            // 
            // CactusInfo
            // 
            this.CactusInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.CactusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CactusInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CactusInfo.Location = new System.Drawing.Point(30, 25);
            this.CactusInfo.Name = "CactusInfo";
            this.CactusInfo.Size = new System.Drawing.Size(541, 467);
            this.CactusInfo.TabIndex = 2;
            this.CactusInfo.Text = resources.GetString("CactusInfo.Text");
            // 
            // UC_Pachira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UC_Pachira";
            this.Size = new System.Drawing.Size(600, 516);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox CactusInfo;
    }
}
