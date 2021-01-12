namespace NEAapp.UserControls
{
    partial class StaffItem
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.moreinfobutton = new System.Windows.Forms.Button();
            this.MedicalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactinfo = new System.Windows.Forms.RichTextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.doblable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MedicalLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contactinfo);
            this.panel1.Controls.Add(this.emaillabel);
            this.panel1.Controls.Add(this.doblable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 350);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.moreinfobutton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 40);
            this.panel3.TabIndex = 18;
            // 
            // moreinfobutton
            // 
            this.moreinfobutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreinfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreinfobutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreinfobutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.moreinfobutton.Location = new System.Drawing.Point(0, 0);
            this.moreinfobutton.Name = "moreinfobutton";
            this.moreinfobutton.Size = new System.Drawing.Size(335, 40);
            this.moreinfobutton.TabIndex = 0;
            this.moreinfobutton.Text = "More Info";
            this.moreinfobutton.UseVisualStyleBackColor = true;
            this.moreinfobutton.Click += new System.EventHandler(this.moreinfobutton_Click);
            // 
            // MedicalLabel
            // 
            this.MedicalLabel.AutoSize = true;
            this.MedicalLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MedicalLabel.Location = new System.Drawing.Point(187, 61);
            this.MedicalLabel.Name = "MedicalLabel";
            this.MedicalLabel.Size = new System.Drawing.Size(130, 17);
            this.MedicalLabel.TabIndex = 17;
            this.MedicalLabel.Text = "Is Medically Trained";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact Information";
            // 
            // contactinfo
            // 
            this.contactinfo.Location = new System.Drawing.Point(17, 158);
            this.contactinfo.Name = "contactinfo";
            this.contactinfo.Size = new System.Drawing.Size(300, 134);
            this.contactinfo.TabIndex = 15;
            this.contactinfo.Text = "";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emaillabel.Location = new System.Drawing.Point(14, 101);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(43, 17);
            this.emaillabel.TabIndex = 11;
            this.emaillabel.Text = "Email";
            // 
            // doblable
            // 
            this.doblable.AutoSize = true;
            this.doblable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.doblable.Location = new System.Drawing.Point(14, 61);
            this.doblable.Name = "doblable";
            this.doblable.Size = new System.Drawing.Size(90, 17);
            this.doblable.TabIndex = 8;
            this.doblable.Text = "Date Of Birth";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 43);
            this.panel2.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.NameLabel.Size = new System.Drawing.Size(335, 43);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaffItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StaffItem";
            this.Size = new System.Drawing.Size(335, 350);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox contactinfo;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label doblable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button moreinfobutton;
        private System.Windows.Forms.Label MedicalLabel;
    }
}
