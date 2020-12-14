namespace NEAapp.Forms_Windows
{
    partial class Create_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Account));
            this.ShwoPassword = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameAvaliable = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactDetailsBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.MedicalCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShwoPassword
            // 
            this.ShwoPassword.AutoSize = true;
            this.ShwoPassword.Location = new System.Drawing.Point(223, 73);
            this.ShwoPassword.Name = "ShwoPassword";
            this.ShwoPassword.Size = new System.Drawing.Size(102, 17);
            this.ShwoPassword.TabIndex = 14;
            this.ShwoPassword.Text = "Show Password";
            this.ShwoPassword.UseVisualStyleBackColor = true;
            this.ShwoPassword.CheckedChanged += new System.EventHandler(this.ShwoPassword_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 415);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(92, 23);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Create Account";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(205, 20);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(12, 47);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(206, 20);
            this.UsernameTextBox.TabIndex = 10;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("ITC Avant Garde Std Bk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "NEA Business Software";
            // 
            // UsernameAvaliable
            // 
            this.UsernameAvaliable.AutoSize = true;
            this.UsernameAvaliable.Location = new System.Drawing.Point(221, 50);
            this.UsernameAvaliable.Name = "UsernameAvaliable";
            this.UsernameAvaliable.Size = new System.Drawing.Size(92, 13);
            this.UsernameAvaliable.TabIndex = 15;
            this.UsernameAvaliable.Text = "Username is Free!";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Location = new System.Drawing.Point(11, 108);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(206, 20);
            this.DOBPicker.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Date Of Birth";
            // 
            // ContactDetailsBox
            // 
            this.ContactDetailsBox.Location = new System.Drawing.Point(11, 172);
            this.ContactDetailsBox.Name = "ContactDetailsBox";
            this.ContactDetailsBox.Size = new System.Drawing.Size(206, 96);
            this.ContactDetailsBox.TabIndex = 18;
            this.ContactDetailsBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contact Details";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(11, 133);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(206, 20);
            this.EmailBox.TabIndex = 20;
            this.EmailBox.Text = "Email";
            // 
            // MedicalCheckBox
            // 
            this.MedicalCheckBox.AutoSize = true;
            this.MedicalCheckBox.Location = new System.Drawing.Point(12, 395);
            this.MedicalCheckBox.Name = "MedicalCheckBox";
            this.MedicalCheckBox.Size = new System.Drawing.Size(120, 17);
            this.MedicalCheckBox.TabIndex = 21;
            this.MedicalCheckBox.Text = "Is Medically Trained";
            this.MedicalCheckBox.UseVisualStyleBackColor = true;
            this.MedicalCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimerLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(335, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 418);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Box";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(6, 395);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(30, 13);
            this.TimerLabel.TabIndex = 7;
            this.TimerLabel.Text = "Time";
            this.TimerLabel.Click += new System.EventHandler(this.TimerLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 182);
            this.label5.TabIndex = 3;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Emergency Contact";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 288);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 96);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MedicalCheckBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactDetailsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.UsernameAvaliable);
            this.Controls.Add(this.ShwoPassword);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Create_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ShwoPassword;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameAvaliable;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ContactDetailsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.CheckBox MedicalCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}