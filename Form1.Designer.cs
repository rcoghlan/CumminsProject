namespace Cummins_Final_Project
{
    partial class ee
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
            this.userAuthLabel = new System.Windows.Forms.Label();
            this.loginBttn = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passEntry = new System.Windows.Forms.TextBox();
            this.userEntry = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginPage = new System.Windows.Forms.Panel();
            this.faultPanel = new System.Windows.Forms.Panel();
            this.errorlabel1 = new System.Windows.Forms.Label();
            this.viewBttn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ocurrence_label = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.serialNum = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.runTime = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tvw_display = new System.Windows.Forms.TreeView();
            this.timeSumListBox = new System.Windows.Forms.ListBox();
            this.descriptListBox = new System.Windows.Forms.ListBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateListBox = new System.Windows.Forms.ListBox();
            this.faultCodeListBox = new System.Windows.Forms.ListBox();
            this.faultCodeLabel = new System.Windows.Forms.Label();
            this.procedureLabel = new System.Windows.Forms.Label();
            this.beginDiag = new System.Windows.Forms.Button();
            this.faultLabel3 = new System.Windows.Forms.Label();
            this.detectedListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.viewFaults = new System.Windows.Forms.Button();
            this.loginPage.SuspendLayout();
            this.faultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAuthLabel
            // 
            this.userAuthLabel.AutoSize = true;
            this.userAuthLabel.Location = new System.Drawing.Point(417, 211);
            this.userAuthLabel.Name = "userAuthLabel";
            this.userAuthLabel.Size = new System.Drawing.Size(85, 13);
            this.userAuthLabel.TabIndex = 6;
            this.userAuthLabel.Text = "Employee Login ";
            // 
            // loginBttn
            // 
            this.loginBttn.Location = new System.Drawing.Point(420, 344);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(77, 23);
            this.loginBttn.TabIndex = 5;
            this.loginBttn.Text = "Authenticate";
            this.loginBttn.UseVisualStyleBackColor = true;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(301, 304);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Password";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(301, 255);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(70, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Employee ID:";
            // 
            // passEntry
            // 
            this.passEntry.Location = new System.Drawing.Point(371, 301);
            this.passEntry.Name = "passEntry";
            this.passEntry.Size = new System.Drawing.Size(191, 20);
            this.passEntry.TabIndex = 1;
            this.passEntry.TextChanged += new System.EventHandler(this.passEntry_TextChanged);
            // 
            // userEntry
            // 
            this.userEntry.Location = new System.Drawing.Point(371, 251);
            this.userEntry.Name = "userEntry";
            this.userEntry.Size = new System.Drawing.Size(191, 20);
            this.userEntry.TabIndex = 0;
            this.userEntry.TextChanged += new System.EventHandler(this.userEntry_TextChanged);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(255, 90);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(139, 13);
            this.welcomeLabel.TabIndex = 4;
            this.welcomeLabel.Text = "Cummins Diagnostic System";
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.userAuthLabel);
            this.loginPage.Controls.Add(this.loginBttn);
            this.loginPage.Controls.Add(this.passLabel);
            this.loginPage.Controls.Add(this.userLabel);
            this.loginPage.Controls.Add(this.passEntry);
            this.loginPage.Controls.Add(this.userEntry);
            this.loginPage.Controls.Add(this.welcomeLabel);
            this.loginPage.Location = new System.Drawing.Point(-7, 1);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1040, 648);
            this.loginPage.TabIndex = 20;
            // 
            // faultPanel
            // 
            this.faultPanel.Controls.Add(this.errorlabel1);
            this.faultPanel.Controls.Add(this.viewBttn);
            this.faultPanel.Location = new System.Drawing.Point(-3, 1);
            this.faultPanel.Name = "faultPanel";
            this.faultPanel.Size = new System.Drawing.Size(1035, 651);
            this.faultPanel.TabIndex = 29;
            // 
            // errorlabel1
            // 
            this.errorlabel1.AutoSize = true;
            this.errorlabel1.Location = new System.Drawing.Point(250, 90);
            this.errorlabel1.Name = "errorlabel1";
            this.errorlabel1.Size = new System.Drawing.Size(140, 13);
            this.errorlabel1.TabIndex = 0;
            this.errorlabel1.Text = "Machines in need of service";
            // 
            // viewBttn
            // 
            this.viewBttn.Location = new System.Drawing.Point(366, 266);
            this.viewBttn.Name = "viewBttn";
            this.viewBttn.Size = new System.Drawing.Size(118, 23);
            this.viewBttn.TabIndex = 2;
            this.viewBttn.Text = "View";
            this.viewBttn.UseVisualStyleBackColor = true;
            this.viewBttn.Click += new System.EventHandler(this.viewBttn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Run Time";
            // 
            // ocurrence_label
            // 
            this.ocurrence_label.AutoSize = true;
            this.ocurrence_label.Location = new System.Drawing.Point(2, 193);
            this.ocurrence_label.Name = "ocurrence_label";
            this.ocurrence_label.Size = new System.Drawing.Size(86, 13);
            this.ocurrence_label.TabIndex = 40;
            this.ocurrence_label.Text = "Occurence Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(29, 404);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(30, 13);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Date";
            // 
            // serialNum
            // 
            this.serialNum.FormattingEnabled = true;
            this.serialNum.Location = new System.Drawing.Point(95, 303);
            this.serialNum.Name = "serialNum";
            this.serialNum.Size = new System.Drawing.Size(134, 69);
            this.serialNum.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "ESN";
            // 
            // runTime
            // 
            this.runTime.FormattingEnabled = true;
            this.runTime.Location = new System.Drawing.Point(94, 232);
            this.runTime.Name = "runTime";
            this.runTime.Size = new System.Drawing.Size(135, 69);
            this.runTime.TabIndex = 47;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tvw_display
            // 
            this.tvw_display.Location = new System.Drawing.Point(228, 45);
            this.tvw_display.Name = "tvw_display";
            this.tvw_display.Size = new System.Drawing.Size(791, 483);
            this.tvw_display.TabIndex = 30;
            // 
            // timeSumListBox
            // 
            this.timeSumListBox.FormattingEnabled = true;
            this.timeSumListBox.Location = new System.Drawing.Point(95, 162);
            this.timeSumListBox.Name = "timeSumListBox";
            this.timeSumListBox.Size = new System.Drawing.Size(134, 69);
            this.timeSumListBox.TabIndex = 37;
            // 
            // descriptListBox
            // 
            this.descriptListBox.FormattingEnabled = true;
            this.descriptListBox.Location = new System.Drawing.Point(94, 446);
            this.descriptListBox.Name = "descriptListBox";
            this.descriptListBox.Size = new System.Drawing.Size(135, 82);
            this.descriptListBox.TabIndex = 36;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 474);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Description";
            // 
            // dateListBox
            // 
            this.dateListBox.FormattingEnabled = true;
            this.dateListBox.Location = new System.Drawing.Point(95, 376);
            this.dateListBox.Name = "dateListBox";
            this.dateListBox.Size = new System.Drawing.Size(134, 69);
            this.dateListBox.TabIndex = 32;
            // 
            // faultCodeListBox
            // 
            this.faultCodeListBox.FormattingEnabled = true;
            this.faultCodeListBox.Location = new System.Drawing.Point(94, 91);
            this.faultCodeListBox.Name = "faultCodeListBox";
            this.faultCodeListBox.Size = new System.Drawing.Size(136, 69);
            this.faultCodeListBox.TabIndex = 40;
            // 
            // faultCodeLabel
            // 
            this.faultCodeLabel.AutoSize = true;
            this.faultCodeLabel.Location = new System.Drawing.Point(12, 118);
            this.faultCodeLabel.Name = "faultCodeLabel";
            this.faultCodeLabel.Size = new System.Drawing.Size(58, 13);
            this.faultCodeLabel.TabIndex = 39;
            this.faultCodeLabel.Text = "Fault Code";
            // 
            // procedureLabel
            // 
            this.procedureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.procedureLabel.AutoSize = true;
            this.procedureLabel.Location = new System.Drawing.Point(539, 23);
            this.procedureLabel.Name = "procedureLabel";
            this.procedureLabel.Size = new System.Drawing.Size(85, 13);
            this.procedureLabel.TabIndex = 41;
            this.procedureLabel.Text = "View Procedure ";
            // 
            // beginDiag
            // 
            this.beginDiag.AllowDrop = true;
            this.beginDiag.Location = new System.Drawing.Point(508, 534);
            this.beginDiag.Name = "beginDiag";
            this.beginDiag.Size = new System.Drawing.Size(130, 23);
            this.beginDiag.TabIndex = 42;
            this.beginDiag.Text = "Begin Diagnositcs";
            this.beginDiag.UseVisualStyleBackColor = true;
            this.beginDiag.Click += new System.EventHandler(this.beginDiag_Click);
            // 
            // faultLabel3
            // 
            this.faultLabel3.AutoSize = true;
            this.faultLabel3.Location = new System.Drawing.Point(103, 9);
            this.faultLabel3.Name = "faultLabel3";
            this.faultLabel3.Size = new System.Drawing.Size(110, 13);
            this.faultLabel3.TabIndex = 43;
            this.faultLabel3.Text = "Fault Codes Detected";
            // 
            // detectedListbox
            // 
            this.detectedListbox.FormattingEnabled = true;
            this.detectedListbox.Location = new System.Drawing.Point(94, 45);
            this.detectedListbox.Name = "detectedListbox";
            this.detectedListbox.Size = new System.Drawing.Size(135, 43);
            this.detectedListbox.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewFaults
            // 
            this.viewFaults.Location = new System.Drawing.Point(228, 13);
            this.viewFaults.Name = "viewFaults";
            this.viewFaults.Size = new System.Drawing.Size(136, 23);
            this.viewFaults.TabIndex = 49;
            this.viewFaults.Text = "View Faults";
            this.viewFaults.UseVisualStyleBackColor = true;
            this.viewFaults.Click += new System.EventHandler(this.viewFaults_Click);
            // 
            // ee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 645);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.faultPanel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptListBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateListBox);
            this.Controls.Add(this.procedureLabel);
            this.Controls.Add(this.ocurrence_label);
            this.Controls.Add(this.tvw_display);
            this.Controls.Add(this.faultCodeLabel);
            this.Controls.Add(this.faultCodeListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialNum);
            this.Controls.Add(this.timeSumListBox);
            this.Controls.Add(this.faultLabel3);
            this.Controls.Add(this.detectedListbox);
            this.Controls.Add(this.runTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.beginDiag);
            this.Controls.Add(this.viewFaults);
            this.Name = "ee";
            this.Text = "Cummins Diagnostic System";
            this.Load += new System.EventHandler(this.ee_Load);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.faultPanel.ResumeLayout(false);
            this.faultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userAuthLabel;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passEntry;
        private System.Windows.Forms.TextBox userEntry;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel loginPage;
        private System.Windows.Forms.Panel faultPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label errorlabel1;
        private System.Windows.Forms.TreeView tvw_display;
        private System.Windows.Forms.ListBox timeSumListBox;
        private System.Windows.Forms.ListBox descriptListBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ListBox dateListBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ListBox faultCodeListBox;
        private System.Windows.Forms.Label faultCodeLabel;
        private System.Windows.Forms.Button viewBttn;
        private System.Windows.Forms.Label procedureLabel;
        private System.Windows.Forms.Button beginDiag;
        private System.Windows.Forms.Label faultLabel3;
        private System.Windows.Forms.ListBox serialNum;
        private System.Windows.Forms.ListBox detectedListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox runTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ocurrence_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewFaults;
    }
}

