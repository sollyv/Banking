namespace Banking
{
    partial class frmHome
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
            this.btnAdminFull = new System.Windows.Forms.Button();
            this.btnAdminReport = new System.Windows.Forms.Button();
            this.btnGenerateAudit = new System.Windows.Forms.Button();
            this.btnViewAudit = new System.Windows.Forms.Button();
            this.btnInputAcc = new System.Windows.Forms.Button();
            this.btnAuthAcc = new System.Windows.Forms.Button();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.btnAccInfo = new System.Windows.Forms.Button();
            this.btnViewAccBal = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackToLogin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminFull
            // 
            this.btnAdminFull.Location = new System.Drawing.Point(70, 179);
            this.btnAdminFull.Name = "btnAdminFull";
            this.btnAdminFull.Size = new System.Drawing.Size(214, 23);
            this.btnAdminFull.TabIndex = 2;
            this.btnAdminFull.Text = "Administration Full Access\r\n";
            this.btnAdminFull.UseVisualStyleBackColor = true;
            this.btnAdminFull.Click += new System.EventHandler(this.btnAdminFull_Click);
            // 
            // btnAdminReport
            // 
            this.btnAdminReport.Location = new System.Drawing.Point(70, 458);
            this.btnAdminReport.Name = "btnAdminReport";
            this.btnAdminReport.Size = new System.Drawing.Size(214, 23);
            this.btnAdminReport.TabIndex = 9;
            this.btnAdminReport.Text = "Administration Report Privileges";
            this.btnAdminReport.UseVisualStyleBackColor = true;
            this.btnAdminReport.Click += new System.EventHandler(this.btnAdminReport_Click);
            // 
            // btnGenerateAudit
            // 
            this.btnGenerateAudit.Location = new System.Drawing.Point(70, 340);
            this.btnGenerateAudit.Name = "btnGenerateAudit";
            this.btnGenerateAudit.Size = new System.Drawing.Size(214, 23);
            this.btnGenerateAudit.TabIndex = 6;
            this.btnGenerateAudit.Text = "Generate Audit Records";
            this.btnGenerateAudit.UseVisualStyleBackColor = true;
            this.btnGenerateAudit.Click += new System.EventHandler(this.btnGenerateAudit_Click);
            // 
            // btnViewAudit
            // 
            this.btnViewAudit.Location = new System.Drawing.Point(70, 219);
            this.btnViewAudit.Name = "btnViewAudit";
            this.btnViewAudit.Size = new System.Drawing.Size(214, 23);
            this.btnViewAudit.TabIndex = 3;
            this.btnViewAudit.Text = "View Audit Records";
            this.btnViewAudit.UseVisualStyleBackColor = true;
            this.btnViewAudit.Click += new System.EventHandler(this.btnViewAudit_Click);
            // 
            // btnInputAcc
            // 
            this.btnInputAcc.Location = new System.Drawing.Point(70, 300);
            this.btnInputAcc.Name = "btnInputAcc";
            this.btnInputAcc.Size = new System.Drawing.Size(214, 23);
            this.btnInputAcc.TabIndex = 5;
            this.btnInputAcc.Text = "Input Account Payments";
            this.btnInputAcc.UseVisualStyleBackColor = true;
            this.btnInputAcc.Click += new System.EventHandler(this.btnInputAcc_Click);
            // 
            // btnAuthAcc
            // 
            this.btnAuthAcc.Location = new System.Drawing.Point(70, 418);
            this.btnAuthAcc.Name = "btnAuthAcc";
            this.btnAuthAcc.Size = new System.Drawing.Size(214, 23);
            this.btnAuthAcc.TabIndex = 8;
            this.btnAuthAcc.Text = "Authorise Account Payments";
            this.btnAuthAcc.UseVisualStyleBackColor = true;
            this.btnAuthAcc.Click += new System.EventHandler(this.btnAuthAcc_Click);
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Location = new System.Drawing.Point(70, 259);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(214, 23);
            this.btnManageAcc.TabIndex = 4;
            this.btnManageAcc.Text = "Manage Account";
            this.btnManageAcc.UseVisualStyleBackColor = true;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // btnAccInfo
            // 
            this.btnAccInfo.Location = new System.Drawing.Point(70, 379);
            this.btnAccInfo.Name = "btnAccInfo";
            this.btnAccInfo.Size = new System.Drawing.Size(214, 23);
            this.btnAccInfo.TabIndex = 7;
            this.btnAccInfo.Text = "View Account Information";
            this.btnAccInfo.UseVisualStyleBackColor = true;
            this.btnAccInfo.Click += new System.EventHandler(this.btnAccInfo_Click);
            // 
            // btnViewAccBal
            // 
            this.btnViewAccBal.Location = new System.Drawing.Point(70, 133);
            this.btnViewAccBal.Name = "btnViewAccBal";
            this.btnViewAccBal.Size = new System.Drawing.Size(214, 23);
            this.btnViewAccBal.TabIndex = 1;
            this.btnViewAccBal.Text = "View Account Balances";
            this.btnViewAccBal.UseVisualStyleBackColor = true;
            this.btnViewAccBal.Click += new System.EventHandler(this.btnViewAccBal_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(87, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 21);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Welcome Isabelle Stewart";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(326, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack;
            this.btnBackToLogin.IconColor = System.Drawing.Color.White;
            this.btnBackToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackToLogin.IconSize = 30;
            this.btnBackToLogin.Location = new System.Drawing.Point(12, 27);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(31, 34);
            this.btnBackToLogin.TabIndex = 10;
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Back to Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(297, 27);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(22, 23);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(348, 493);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnViewAccBal);
            this.Controls.Add(this.btnAccInfo);
            this.Controls.Add(this.btnManageAcc);
            this.Controls.Add(this.btnAuthAcc);
            this.Controls.Add(this.btnInputAcc);
            this.Controls.Add(this.btnViewAudit);
            this.Controls.Add(this.btnGenerateAudit);
            this.Controls.Add(this.btnAdminReport);
            this.Controls.Add(this.btnAdminFull);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdminFull;
        private Button btnAdminReport;
        private Button btnGenerateAudit;
        private Button btnViewAudit;
        private Button btnInputAcc;
        private Button btnAuthAcc;
        private Button btnManageAcc;
        private Button btnAccInfo;
        private Button btnViewAccBal;
        private Label lblName;
        private Button btnClose;
        private FontAwesome.Sharp.IconButton btnBackToLogin;
        private Label label1;
        private MenuStrip menuStrip1;
        private Button btnHelp;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}