namespace NEAapp.Forms_Windows
{
    partial class StaffOverview
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.emergencyContact = new System.Windows.Forms.RichTextBox();
            this.MedicalCheckBox = new System.Windows.Forms.CheckBox();
            this.RolesCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.COntactInfo = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.wage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wage)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 29);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(641, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(10);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 29);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save Profile Changes";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(389, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Emergency Contact Information";
            // 
            // emergencyContact
            // 
            this.emergencyContact.Location = new System.Drawing.Point(392, 265);
            this.emergencyContact.Name = "emergencyContact";
            this.emergencyContact.Size = new System.Drawing.Size(389, 157);
            this.emergencyContact.TabIndex = 17;
            this.emergencyContact.Text = "";
            // 
            // MedicalCheckBox
            // 
            this.MedicalCheckBox.AutoSize = true;
            this.MedicalCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MedicalCheckBox.Location = new System.Drawing.Point(17, 325);
            this.MedicalCheckBox.Name = "MedicalCheckBox";
            this.MedicalCheckBox.Size = new System.Drawing.Size(119, 17);
            this.MedicalCheckBox.TabIndex = 2;
            this.MedicalCheckBox.Text = "Is medically Trained";
            this.MedicalCheckBox.UseVisualStyleBackColor = true;
            // 
            // RolesCheckedBox
            // 
            this.RolesCheckedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.RolesCheckedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RolesCheckedBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolesCheckedBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RolesCheckedBox.FormattingEnabled = true;
            this.RolesCheckedBox.Location = new System.Drawing.Point(16, 63);
            this.RolesCheckedBox.Name = "RolesCheckedBox";
            this.RolesCheckedBox.Size = new System.Drawing.Size(120, 256);
            this.RolesCheckedBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 48);
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
            this.NameLabel.Size = new System.Drawing.Size(791, 48);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emergencyContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.COntactInfo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.wage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.DOBPicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.MedicalCheckBox);
            this.panel1.Controls.Add(this.RolesCheckedBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 498);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(389, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contact Information";
            // 
            // COntactInfo
            // 
            this.COntactInfo.Location = new System.Drawing.Point(392, 81);
            this.COntactInfo.Name = "COntactInfo";
            this.COntactInfo.Size = new System.Drawing.Size(389, 157);
            this.COntactInfo.TabIndex = 15;
            this.COntactInfo.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.removeButton);
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 29);
            this.panel3.TabIndex = 14;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(150, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 29);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove Account";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(165, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wage";
            // 
            // wage
            // 
            this.wage.DecimalPlaces = 2;
            this.wage.Location = new System.Drawing.Point(169, 218);
            this.wage.Name = "wage";
            this.wage.Size = new System.Drawing.Size(199, 20);
            this.wage.TabIndex = 12;
            this.wage.Tag = "";
            this.wage.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(165, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(169, 172);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(199, 20);
            this.EmailTextBox.TabIndex = 10;
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(169, 127);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(199, 20);
            this.DOBPicker.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(165, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(166, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(169, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // StaffOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 498);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StaffOverview";
            this.Text = "Staff Overview";
            this.Load += new System.EventHandler(this.StaffOverview_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox emergencyContact;
        private System.Windows.Forms.CheckBox MedicalCheckBox;
        private System.Windows.Forms.CheckedListBox RolesCheckedBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox COntactInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown wage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button removeButton;
    }
}