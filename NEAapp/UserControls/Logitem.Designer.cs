namespace NEAapp.UserControls
{
    partial class Logitem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameTag = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.InfoTag = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.NameTag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.InfoTag);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(243, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 58);
            this.panel2.TabIndex = 1;
            // 
            // NameTag
            // 
            this.NameTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTag.ForeColor = System.Drawing.SystemColors.Control;
            this.NameTag.Location = new System.Drawing.Point(0, 0);
            this.NameTag.Name = "NameTag";
            this.NameTag.Size = new System.Drawing.Size(243, 58);
            this.NameTag.TabIndex = 0;
            this.NameTag.Text = "Name";
            this.NameTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.Date);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(790, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 58);
            this.panel3.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.Control;
            this.Date.Location = new System.Drawing.Point(0, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(238, 58);
            this.Date.TabIndex = 1;
            this.Date.Text = "When";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoTag
            // 
            this.InfoTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTag.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoTag.Location = new System.Drawing.Point(0, 0);
            this.InfoTag.Name = "InfoTag";
            this.InfoTag.Size = new System.Drawing.Size(551, 58);
            this.InfoTag.TabIndex = 2;
            this.InfoTag.Text = "Info";
            this.InfoTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTag.Click += new System.EventHandler(this.InfoTag_Click);
            // 
            // Logitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Logitem";
            this.Size = new System.Drawing.Size(1028, 58);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameTag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InfoTag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Date;
    }
}
