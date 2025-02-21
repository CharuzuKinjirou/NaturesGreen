namespace Nature_s_Green
{
    partial class CalendarEventFrm
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
            this.txtdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtevent = new Guna.UI2.WinForms.Guna2TextBox();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Eventlbl = new System.Windows.Forms.Label();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtdate
            // 
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.DefaultText = "";
            this.txtdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.DisabledState.Parent = this.txtdate;
            this.txtdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.Enabled = false;
            this.txtdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.FocusedState.Parent = this.txtdate;
            this.txtdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.Location = new System.Drawing.Point(36, 44);
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.PlaceholderText = "";
            this.txtdate.SelectedText = "";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(258, 42);
            this.txtdate.TabIndex = 1;
            // 
            // txtevent
            // 
            this.txtevent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtevent.DefaultText = "";
            this.txtevent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtevent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtevent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtevent.DisabledState.Parent = this.txtevent;
            this.txtevent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtevent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtevent.FocusedState.Parent = this.txtevent;
            this.txtevent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtevent.HoverState.Parent = this.txtevent;
            this.txtevent.Location = new System.Drawing.Point(36, 122);
            this.txtevent.Name = "txtevent";
            this.txtevent.PasswordChar = '\0';
            this.txtevent.PlaceholderText = "";
            this.txtevent.SelectedText = "";
            this.txtevent.ShadowDecoration.Parent = this.txtevent;
            this.txtevent.Size = new System.Drawing.Size(258, 42);
            this.txtevent.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Datelbl.Location = new System.Drawing.Point(33, 25);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(40, 16);
            this.Datelbl.TabIndex = 3;
            this.Datelbl.Text = "Date";
            // 
            // Eventlbl
            // 
            this.Eventlbl.AutoSize = true;
            this.Eventlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Eventlbl.Location = new System.Drawing.Point(33, 103);
            this.Eventlbl.Name = "Eventlbl";
            this.Eventlbl.Size = new System.Drawing.Size(46, 16);
            this.Eventlbl.TabIndex = 4;
            this.Eventlbl.Text = "Event";
            // 
            // SaveBtn
            // 
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Location = new System.Drawing.Point(218, 197);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(76, 30);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CalendarEventFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 239);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Eventlbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.txtevent);
            this.Controls.Add(this.txtdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalendarEventFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.CalendarEventFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtdate;
        private Guna.UI2.WinForms.Guna2TextBox txtevent;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Eventlbl;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
    }
}