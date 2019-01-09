namespace WindowsFormsApp1
{
    partial class downloadFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(downloadFrm));
            this.dowloadBtn = new System.Windows.Forms.Button();
            this.dowloadlinkTbx = new System.Windows.Forms.TextBox();
            this.downloadlinkLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dowloadBtn
            // 
            this.dowloadBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dowloadBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images;
            this.dowloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dowloadBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dowloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dowloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dowloadBtn.ForeColor = System.Drawing.Color.White;
            this.dowloadBtn.Location = new System.Drawing.Point(339, 221);
            this.dowloadBtn.Name = "dowloadBtn";
            this.dowloadBtn.Size = new System.Drawing.Size(150, 40);
            this.dowloadBtn.TabIndex = 0;
            this.dowloadBtn.UseVisualStyleBackColor = true;
            this.dowloadBtn.Click += new System.EventHandler(this.button1_Click);
            this.dowloadBtn.MouseHover += new System.EventHandler(this.dowloadBtn_MouseHover);
            // 
            // dowloadlinkTbx
            // 
            this.dowloadlinkTbx.BackColor = System.Drawing.SystemColors.Info;
            this.dowloadlinkTbx.ForeColor = System.Drawing.Color.SlateGray;
            this.dowloadlinkTbx.Location = new System.Drawing.Point(591, 371);
            this.dowloadlinkTbx.Multiline = true;
            this.dowloadlinkTbx.Name = "dowloadlinkTbx";
            this.dowloadlinkTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dowloadlinkTbx.Size = new System.Drawing.Size(268, 31);
            this.dowloadlinkTbx.TabIndex = 1;
            this.dowloadlinkTbx.Text = "https://download.az";
            // 
            // downloadlinkLbl
            // 
            this.downloadlinkLbl.AutoSize = true;
            this.downloadlinkLbl.BackColor = System.Drawing.Color.Tomato;
            this.downloadlinkLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadlinkLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.downloadlinkLbl.Location = new System.Drawing.Point(592, 355);
            this.downloadlinkLbl.Name = "downloadlinkLbl";
            this.downloadlinkLbl.Size = new System.Drawing.Size(134, 13);
            this.downloadlinkLbl.TabIndex = 2;
            this.downloadlinkLbl.Text = "Enter file link for download ";
            // 
            // downloadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pushbullet_update;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.downloadlinkLbl);
            this.Controls.Add(this.dowloadlinkTbx);
            this.Controls.Add(this.dowloadBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "downloadFrm";
            this.Text = "Download";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dowloadBtn;
        private System.Windows.Forms.TextBox dowloadlinkTbx;
        private System.Windows.Forms.Label downloadlinkLbl;
    }
}

