namespace NEAapp.Forms_Windows
{
    partial class MainMenu
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
            this.NoticeBoardPanel = new System.Windows.Forms.Panel();
            this.TrueNoticePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ProjectPanelButton = new System.Windows.Forms.Button();
            this.ManageNoticeButton = new System.Windows.Forms.Button();
            this.GeneralAdminButton = new System.Windows.Forms.Button();
            this.StaffLogsButton = new System.Windows.Forms.Button();
            this.CustomerAccountsButton = new System.Windows.Forms.Button();
            this.TestEmailButton = new System.Windows.Forms.Button();
            this.StaffAccountsButton = new System.Windows.Forms.Button();
            this.BillingButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProjectPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NoticeBoardPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ProjectPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoticeBoardPanel
            // 
            this.NoticeBoardPanel.AutoSize = true;
            this.NoticeBoardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.NoticeBoardPanel.Controls.Add(this.TrueNoticePanel);
            this.NoticeBoardPanel.Controls.Add(this.panel1);
            this.NoticeBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoticeBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.NoticeBoardPanel.Name = "NoticeBoardPanel";
            this.NoticeBoardPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoticeBoardPanel.Size = new System.Drawing.Size(678, 777);
            this.NoticeBoardPanel.TabIndex = 1;
            this.NoticeBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TrueNoticePanel
            // 
            this.TrueNoticePanel.AutoScroll = true;
            this.TrueNoticePanel.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.TrueNoticePanel.AutoSize = true;
            this.TrueNoticePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TrueNoticePanel.Location = new System.Drawing.Point(678, 62);
            this.TrueNoticePanel.Name = "TrueNoticePanel";
            this.TrueNoticePanel.Size = new System.Drawing.Size(0, 715);
            this.TrueNoticePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notice Board";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.leftPanel.Controls.Add(this.panel8);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.panel2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(331, 777);
            this.leftPanel.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ProjectPanelButton);
            this.panel8.Controls.Add(this.ManageNoticeButton);
            this.panel8.Controls.Add(this.GeneralAdminButton);
            this.panel8.Controls.Add(this.StaffLogsButton);
            this.panel8.Controls.Add(this.CustomerAccountsButton);
            this.panel8.Controls.Add(this.TestEmailButton);
            this.panel8.Controls.Add(this.StaffAccountsButton);
            this.panel8.Controls.Add(this.BillingButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(331, 692);
            this.panel8.TabIndex = 23;
            // 
            // ProjectPanelButton
            // 
            this.ProjectPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ProjectPanelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjectPanelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProjectPanelButton.Location = new System.Drawing.Point(0, 616);
            this.ProjectPanelButton.Name = "ProjectPanelButton";
            this.ProjectPanelButton.Size = new System.Drawing.Size(331, 88);
            this.ProjectPanelButton.TabIndex = 19;
            this.ProjectPanelButton.Text = "Projects Panel";
            this.ProjectPanelButton.UseVisualStyleBackColor = false;
            // 
            // ManageNoticeButton
            // 
            this.ManageNoticeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ManageNoticeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageNoticeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageNoticeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ManageNoticeButton.Location = new System.Drawing.Point(0, 528);
            this.ManageNoticeButton.Name = "ManageNoticeButton";
            this.ManageNoticeButton.Size = new System.Drawing.Size(331, 88);
            this.ManageNoticeButton.TabIndex = 4;
            this.ManageNoticeButton.Text = "Manage Noticeboard";
            this.ManageNoticeButton.UseVisualStyleBackColor = false;
            this.ManageNoticeButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // GeneralAdminButton
            // 
            this.GeneralAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.GeneralAdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneralAdminButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GeneralAdminButton.Location = new System.Drawing.Point(0, 440);
            this.GeneralAdminButton.Name = "GeneralAdminButton";
            this.GeneralAdminButton.Size = new System.Drawing.Size(331, 88);
            this.GeneralAdminButton.TabIndex = 20;
            this.GeneralAdminButton.Text = "General Admin";
            this.GeneralAdminButton.UseVisualStyleBackColor = false;
            // 
            // StaffLogsButton
            // 
            this.StaffLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.StaffLogsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffLogsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffLogsButton.Location = new System.Drawing.Point(0, 352);
            this.StaffLogsButton.Name = "StaffLogsButton";
            this.StaffLogsButton.Size = new System.Drawing.Size(331, 88);
            this.StaffLogsButton.TabIndex = 7;
            this.StaffLogsButton.Text = "Staff Logs";
            this.StaffLogsButton.UseVisualStyleBackColor = false;
            this.StaffLogsButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // CustomerAccountsButton
            // 
            this.CustomerAccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.CustomerAccountsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerAccountsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomerAccountsButton.Location = new System.Drawing.Point(0, 264);
            this.CustomerAccountsButton.Name = "CustomerAccountsButton";
            this.CustomerAccountsButton.Size = new System.Drawing.Size(331, 88);
            this.CustomerAccountsButton.TabIndex = 16;
            this.CustomerAccountsButton.Text = "Customer Accounts";
            this.CustomerAccountsButton.UseVisualStyleBackColor = false;
            // 
            // TestEmailButton
            // 
            this.TestEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.TestEmailButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TestEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestEmailButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TestEmailButton.Location = new System.Drawing.Point(0, 176);
            this.TestEmailButton.Name = "TestEmailButton";
            this.TestEmailButton.Size = new System.Drawing.Size(331, 88);
            this.TestEmailButton.TabIndex = 10;
            this.TestEmailButton.Text = "Test Email Button";
            this.TestEmailButton.UseVisualStyleBackColor = false;
            this.TestEmailButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // StaffAccountsButton
            // 
            this.StaffAccountsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.StaffAccountsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffAccountsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StaffAccountsButton.Location = new System.Drawing.Point(0, 88);
            this.StaffAccountsButton.Name = "StaffAccountsButton";
            this.StaffAccountsButton.Size = new System.Drawing.Size(331, 88);
            this.StaffAccountsButton.TabIndex = 1;
            this.StaffAccountsButton.Text = "Staff Accounts";
            this.StaffAccountsButton.UseVisualStyleBackColor = false;
            this.StaffAccountsButton.Click += new System.EventHandler(this.StaffAccountsButton_Click);
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.BillingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BillingButton.Location = new System.Drawing.Point(0, 0);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(331, 88);
            this.BillingButton.TabIndex = 13;
            this.BillingButton.Text = "Billing";
            this.BillingButton.UseVisualStyleBackColor = false;
            this.BillingButton.Click += new System.EventHandler(this.button16_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(0, 754);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 10);
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "©  Joshua Barrass";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.NameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 62);
            this.panel3.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(0, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.NameLabel.Size = new System.Drawing.Size(330, 62);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label2";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ProjectPanel.Controls.Add(this.panel7);
            this.ProjectPanel.Controls.Add(this.panel5);
            this.ProjectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectPanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Size = new System.Drawing.Size(1062, 777);
            this.ProjectPanel.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(384, 777);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 62);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Projects";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.NoticeBoardPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(384, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(678, 777);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(0, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(678, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add notice board Message";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ProjectPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(331, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1062, 777);
            this.panel6.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 777);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.leftPanel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.NoticeBoardPanel.ResumeLayout(false);
            this.NoticeBoardPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ProjectPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NoticeBoardPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TrueNoticePanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProjectPanelButton;
        private System.Windows.Forms.Button CustomerAccountsButton;
        private System.Windows.Forms.Button BillingButton;
        private System.Windows.Forms.Button TestEmailButton;
        private System.Windows.Forms.Button StaffLogsButton;
        private System.Windows.Forms.Button ManageNoticeButton;
        private System.Windows.Forms.Button StaffAccountsButton;
        private System.Windows.Forms.Button GeneralAdminButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ProjectPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
    }
}