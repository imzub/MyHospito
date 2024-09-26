namespace HospitoDesktop
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddNewDoctor = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab2_Logs = new System.Windows.Forms.TabPage();
            this.tab1_MyShortcuts = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.viewPatientAppointmentVisit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NewPatientVisit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_GF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_MainPage = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.main_btn_FileStorageMgmt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tab1_MyShortcuts.SuspendLayout();
            this.tabControl_MainPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gotoToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1556, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gotoToolStripMenuItem
            // 
            this.gotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.appointmentToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.gotoToolStripMenuItem.Name = "gotoToolStripMenuItem";
            this.gotoToolStripMenuItem.Size = new System.Drawing.Size(68, 30);
            this.gotoToolStripMenuItem.Text = "Goto";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.viewPatientsToolStripMenuItem,
            this.modifyEditToolStripMenuItem,
            this.deleteRecordsToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.patientsToolStripMenuItem.Text = "Patient";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.newEntryToolStripMenuItem.Text = "New Entry";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // viewPatientsToolStripMenuItem
            // 
            this.viewPatientsToolStripMenuItem.Name = "viewPatientsToolStripMenuItem";
            this.viewPatientsToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.viewPatientsToolStripMenuItem.Text = "View Patient(s)";
            this.viewPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsToolStripMenuItem_Click);
            // 
            // modifyEditToolStripMenuItem
            // 
            this.modifyEditToolStripMenuItem.Name = "modifyEditToolStripMenuItem";
            this.modifyEditToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.modifyEditToolStripMenuItem.Text = "Modify/Edit";
            // 
            // deleteRecordsToolStripMenuItem
            // 
            this.deleteRecordsToolStripMenuItem.Name = "deleteRecordsToolStripMenuItem";
            this.deleteRecordsToolStripMenuItem.Size = new System.Drawing.Size(242, 34);
            this.deleteRecordsToolStripMenuItem.Text = "Delete Record(s)";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddNewDoctor,
            this.viewDoctorsToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // MenuAddNewDoctor
            // 
            this.MenuAddNewDoctor.Name = "MenuAddNewDoctor";
            this.MenuAddNewDoctor.Size = new System.Drawing.Size(229, 34);
            this.MenuAddNewDoctor.Text = "Add New";
            this.MenuAddNewDoctor.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // viewDoctorsToolStripMenuItem
            // 
            this.viewDoctorsToolStripMenuItem.Name = "viewDoctorsToolStripMenuItem";
            this.viewDoctorsToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.viewDoctorsToolStripMenuItem.Text = "View Doctor(s)";
            this.viewDoctorsToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorsToolStripMenuItem_Click);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.viewAppointmentsToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.addNewToolStripMenuItem1.Text = "Add New";
            this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewAppointmentsToolStripMenuItem.Text = "View Appointments";
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tab2_Logs
            // 
            this.tab2_Logs.Location = new System.Drawing.Point(4, 29);
            this.tab2_Logs.Name = "tab2_Logs";
            this.tab2_Logs.Padding = new System.Windows.Forms.Padding(3);
            this.tab2_Logs.Size = new System.Drawing.Size(550, 345);
            this.tab2_Logs.TabIndex = 1;
            this.tab2_Logs.Text = "Other";
            this.tab2_Logs.UseVisualStyleBackColor = true;
            // 
            // tab1_MyShortcuts
            // 
            this.tab1_MyShortcuts.Controls.Add(this.button7);
            this.tab1_MyShortcuts.Controls.Add(this.viewPatientAppointmentVisit);
            this.tab1_MyShortcuts.Controls.Add(this.label3);
            this.tab1_MyShortcuts.Controls.Add(this.btn_NewPatientVisit);
            this.tab1_MyShortcuts.Controls.Add(this.button4);
            this.tab1_MyShortcuts.Controls.Add(this.button5);
            this.tab1_MyShortcuts.Controls.Add(this.label2);
            this.tab1_MyShortcuts.Controls.Add(this.button6);
            this.tab1_MyShortcuts.Controls.Add(this.button2);
            this.tab1_MyShortcuts.Controls.Add(this.label1);
            this.tab1_MyShortcuts.Controls.Add(this.button1);
            this.tab1_MyShortcuts.Location = new System.Drawing.Point(4, 29);
            this.tab1_MyShortcuts.Name = "tab1_MyShortcuts";
            this.tab1_MyShortcuts.Padding = new System.Windows.Forms.Padding(3);
            this.tab1_MyShortcuts.Size = new System.Drawing.Size(550, 345);
            this.tab1_MyShortcuts.TabIndex = 0;
            this.tab1_MyShortcuts.Text = "My Shortcuts";
            this.tab1_MyShortcuts.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(355, 270);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 64);
            this.button7.TabIndex = 13;
            this.button7.Text = "Modify";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // viewPatientAppointmentVisit
            // 
            this.viewPatientAppointmentVisit.Location = new System.Drawing.Point(183, 270);
            this.viewPatientAppointmentVisit.Name = "viewPatientAppointmentVisit";
            this.viewPatientAppointmentVisit.Size = new System.Drawing.Size(166, 64);
            this.viewPatientAppointmentVisit.TabIndex = 12;
            this.viewPatientAppointmentVisit.Text = "View All";
            this.viewPatientAppointmentVisit.UseVisualStyleBackColor = true;
            this.viewPatientAppointmentVisit.Click += new System.EventHandler(this.viewPatientAppointmentVisit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Appointment";
            // 
            // btn_NewPatientVisit
            // 
            this.btn_NewPatientVisit.Location = new System.Drawing.Point(11, 270);
            this.btn_NewPatientVisit.Name = "btn_NewPatientVisit";
            this.btn_NewPatientVisit.Size = new System.Drawing.Size(166, 64);
            this.btn_NewPatientVisit.TabIndex = 10;
            this.btn_NewPatientVisit.Text = "New";
            this.btn_NewPatientVisit.UseVisualStyleBackColor = true;
            this.btn_NewPatientVisit.Click += new System.EventHandler(this.btn_NewPatientVisit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 64);
            this.button4.TabIndex = 9;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 64);
            this.button5.TabIndex = 8;
            this.button5.Text = "View All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Doctor";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 64);
            this.button6.TabIndex = 6;
            this.button6.Text = "New";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_GF
            // 
            this.btn_GF.Location = new System.Drawing.Point(151, 163);
            this.btn_GF.Name = "btn_GF";
            this.btn_GF.Size = new System.Drawing.Size(166, 64);
            this.btn_GF.TabIndex = 5;
            this.btn_GF.Text = "GraphForm";
            this.btn_GF.UseVisualStyleBackColor = true;
            this.btn_GF.Click += new System.EventHandler(this.btn_GF_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "View All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl_MainPage
            // 
            this.tabControl_MainPage.Controls.Add(this.tab1_MyShortcuts);
            this.tabControl_MainPage.Controls.Add(this.tab2_Logs);
            this.tabControl_MainPage.Location = new System.Drawing.Point(0, 36);
            this.tabControl_MainPage.Name = "tabControl_MainPage";
            this.tabControl_MainPage.SelectedIndex = 0;
            this.tabControl_MainPage.Size = new System.Drawing.Size(558, 378);
            this.tabControl_MainPage.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.main_btn_FileStorageMgmt);
            this.groupBox1.Controls.Add(this.btn_GF);
            this.groupBox1.Location = new System.Drawing.Point(907, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 448);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // main_btn_FileStorageMgmt
            // 
            this.main_btn_FileStorageMgmt.Location = new System.Drawing.Point(48, 45);
            this.main_btn_FileStorageMgmt.Name = "main_btn_FileStorageMgmt";
            this.main_btn_FileStorageMgmt.Size = new System.Drawing.Size(473, 64);
            this.main_btn_FileStorageMgmt.TabIndex = 14;
            this.main_btn_FileStorageMgmt.Text = "File Storage Management";
            this.main_btn_FileStorageMgmt.UseVisualStyleBackColor = true;
            this.main_btn_FileStorageMgmt.Click += new System.EventHandler(this.main_btn_FileStorageMgmt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1556, 927);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl_MainPage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Hospito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab1_MyShortcuts.ResumeLayout(false);
            this.tab1_MyShortcuts.PerformLayout();
            this.tabControl_MainPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAddNewDoctor;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.TabPage tab2_Logs;
        private System.Windows.Forms.TabPage tab1_MyShortcuts;
        private System.Windows.Forms.TabControl tabControl_MainPage;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button viewPatientAppointmentVisit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NewPatientVisit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_GF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button main_btn_FileStorageMgmt;
    }
}

