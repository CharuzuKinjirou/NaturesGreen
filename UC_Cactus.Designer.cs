namespace Nature_s_Green
{
    partial class UC_Cactus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cactus));
            this.UC_NamesPnl = new System.Windows.Forms.Panel();
            this.CactusInfo = new System.Windows.Forms.RichTextBox();
            this.UC_NamesPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // UC_NamesPnl
            // 
            this.UC_NamesPnl.BackgroundImage = global::Nature_s_Green.Properties.Resources.UC_pictures_BG;
            this.UC_NamesPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UC_NamesPnl.Controls.Add(this.CactusInfo);
            this.UC_NamesPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_NamesPnl.Location = new System.Drawing.Point(0, 0);
            this.UC_NamesPnl.Name = "UC_NamesPnl";
            this.UC_NamesPnl.Size = new System.Drawing.Size(600, 516);
            this.UC_NamesPnl.TabIndex = 0;
            // 
            // CactusInfo
            // 
            this.CactusInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.CactusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CactusInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CactusInfo.Location = new System.Drawing.Point(27, 27);
            this.CactusInfo.Name = "CactusInfo";
            this.CactusInfo.Size = new System.Drawing.Size(541, 467);
            this.CactusInfo.TabIndex = 1;
            this.CactusInfo.Text = resources.GetString("CactusInfo.Text");
            // 
            // UC_Cactus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UC_NamesPnl);
            this.Name = "UC_Cactus";
            this.Size = new System.Drawing.Size(600, 516);
            this.UC_NamesPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UC_NamesPnl;
        private System.Windows.Forms.RichTextBox CactusInfo;
    }
}
