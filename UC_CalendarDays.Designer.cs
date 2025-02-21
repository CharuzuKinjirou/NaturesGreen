namespace Nature_s_Green
{
    partial class UC_CalendarDays
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
            this.LblDays = new System.Windows.Forms.Label();
            this.LblEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDays.Location = new System.Drawing.Point(3, 11);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(28, 21);
            this.LblDays.TabIndex = 0;
            this.LblDays.Text = "00";
            // 
            // LblEvent
            // 
            this.LblEvent.Location = new System.Drawing.Point(3, 32);
            this.LblEvent.Name = "LblEvent";
            this.LblEvent.Size = new System.Drawing.Size(73, 49);
            this.LblEvent.TabIndex = 1;
            this.LblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_CalendarDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblEvent);
            this.Controls.Add(this.LblDays);
            this.Name = "UC_CalendarDays";
            this.Size = new System.Drawing.Size(80, 81);
            this.Load += new System.EventHandler(this.UC_CalendarDays_Load);
            this.Click += new System.EventHandler(this.UC_CalendarDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.Label LblEvent;
    }
}
