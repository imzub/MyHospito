namespace HospitoDesktop.Forms.ViewPatient
{
    partial class ViewPatients
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
            this.vp_gv_patientList = new System.Windows.Forms.DataGridView();
            this.btnRefreshPatientList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vp_btn_CloseForm = new System.Windows.Forms.Button();
            this.vp_cb_allDoctors = new System.Windows.Forms.CheckBox();
            this.vp_cb_allGenders = new System.Windows.Forms.CheckBox();
            this.vp_tb_patientEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vp_tb_patientContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vp_tb_patientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vp_cb_patientGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vp_cb_assignedDoctor = new System.Windows.Forms.ComboBox();
            this.vp_btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vp_gv_patientList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vp_gv_patientList
            // 
            this.vp_gv_patientList.AllowUserToAddRows = false;
            this.vp_gv_patientList.AllowUserToDeleteRows = false;
            this.vp_gv_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vp_gv_patientList.Location = new System.Drawing.Point(12, 236);
            this.vp_gv_patientList.Name = "vp_gv_patientList";
            this.vp_gv_patientList.ReadOnly = true;
            this.vp_gv_patientList.RowHeadersWidth = 62;
            this.vp_gv_patientList.RowTemplate.Height = 28;
            this.vp_gv_patientList.Size = new System.Drawing.Size(1414, 712);
            this.vp_gv_patientList.TabIndex = 0;
            this.vp_gv_patientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vp_gv_patientList_CellContentClick);
            this.vp_gv_patientList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.vp_gv_patientList_DataBindingComplete);
            // 
            // btnRefreshPatientList
            // 
            this.btnRefreshPatientList.Location = new System.Drawing.Point(1195, 179);
            this.btnRefreshPatientList.Name = "btnRefreshPatientList";
            this.btnRefreshPatientList.Size = new System.Drawing.Size(143, 33);
            this.btnRefreshPatientList.TabIndex = 1;
            this.btnRefreshPatientList.Text = "All Records";
            this.btnRefreshPatientList.UseVisualStyleBackColor = true;
            this.btnRefreshPatientList.Click += new System.EventHandler(this.btnRefreshPatientList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vp_btn_CloseForm);
            this.groupBox1.Controls.Add(this.vp_cb_allDoctors);
            this.groupBox1.Controls.Add(this.btnRefreshPatientList);
            this.groupBox1.Controls.Add(this.vp_cb_allGenders);
            this.groupBox1.Controls.Add(this.vp_tb_patientEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vp_tb_patientContact);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.vp_tb_patientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vp_cb_patientGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vp_cb_assignedDoctor);
            this.groupBox1.Controls.Add(this.vp_btn_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // vp_btn_CloseForm
            // 
            this.vp_btn_CloseForm.Location = new System.Drawing.Point(995, 179);
            this.vp_btn_CloseForm.Name = "vp_btn_CloseForm";
            this.vp_btn_CloseForm.Size = new System.Drawing.Size(94, 33);
            this.vp_btn_CloseForm.TabIndex = 33;
            this.vp_btn_CloseForm.Text = "Close";
            this.vp_btn_CloseForm.UseVisualStyleBackColor = true;
            this.vp_btn_CloseForm.Click += new System.EventHandler(this.vp_btn_CloseForm_Click);
            // 
            // vp_cb_allDoctors
            // 
            this.vp_cb_allDoctors.AutoSize = true;
            this.vp_cb_allDoctors.Location = new System.Drawing.Point(477, 65);
            this.vp_cb_allDoctors.Name = "vp_cb_allDoctors";
            this.vp_cb_allDoctors.Size = new System.Drawing.Size(52, 24);
            this.vp_cb_allDoctors.TabIndex = 32;
            this.vp_cb_allDoctors.Text = "All";
            this.vp_cb_allDoctors.UseVisualStyleBackColor = true;
            this.vp_cb_allDoctors.CheckedChanged += new System.EventHandler(this.vp_cb_allDoctors_CheckedChanged);
            // 
            // vp_cb_allGenders
            // 
            this.vp_cb_allGenders.AutoSize = true;
            this.vp_cb_allGenders.Location = new System.Drawing.Point(477, 98);
            this.vp_cb_allGenders.Name = "vp_cb_allGenders";
            this.vp_cb_allGenders.Size = new System.Drawing.Size(52, 24);
            this.vp_cb_allGenders.TabIndex = 31;
            this.vp_cb_allGenders.Text = "All";
            this.vp_cb_allGenders.UseVisualStyleBackColor = true;
            this.vp_cb_allGenders.CheckedChanged += new System.EventHandler(this.vp_cb_allGenders_CheckedChanged);
            // 
            // vp_tb_patientEmail
            // 
            this.vp_tb_patientEmail.Location = new System.Drawing.Point(146, 161);
            this.vp_tb_patientEmail.Name = "vp_tb_patientEmail";
            this.vp_tb_patientEmail.Size = new System.Drawing.Size(310, 26);
            this.vp_tb_patientEmail.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // vp_tb_patientContact
            // 
            this.vp_tb_patientContact.Location = new System.Drawing.Point(146, 129);
            this.vp_tb_patientContact.Name = "vp_tb_patientContact";
            this.vp_tb_patientContact.Size = new System.Drawing.Size(310, 26);
            this.vp_tb_patientContact.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contact :";
            // 
            // vp_tb_patientName
            // 
            this.vp_tb_patientName.Location = new System.Drawing.Point(146, 29);
            this.vp_tb_patientName.Name = "vp_tb_patientName";
            this.vp_tb_patientName.Size = new System.Drawing.Size(310, 26);
            this.vp_tb_patientName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name :";
            // 
            // vp_cb_patientGender
            // 
            this.vp_cb_patientGender.FormattingEnabled = true;
            this.vp_cb_patientGender.Location = new System.Drawing.Point(146, 95);
            this.vp_cb_patientGender.Name = "vp_cb_patientGender";
            this.vp_cb_patientGender.Size = new System.Drawing.Size(310, 28);
            this.vp_cb_patientGender.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assigned Doctor :";
            // 
            // vp_cb_assignedDoctor
            // 
            this.vp_cb_assignedDoctor.FormattingEnabled = true;
            this.vp_cb_assignedDoctor.Location = new System.Drawing.Point(146, 61);
            this.vp_cb_assignedDoctor.Name = "vp_cb_assignedDoctor";
            this.vp_cb_assignedDoctor.Size = new System.Drawing.Size(310, 28);
            this.vp_cb_assignedDoctor.TabIndex = 1;
            // 
            // vp_btn_search
            // 
            this.vp_btn_search.Location = new System.Drawing.Point(1095, 179);
            this.vp_btn_search.Name = "vp_btn_search";
            this.vp_btn_search.Size = new System.Drawing.Size(94, 33);
            this.vp_btn_search.TabIndex = 0;
            this.vp_btn_search.Text = "Search";
            this.vp_btn_search.UseVisualStyleBackColor = true;
            this.vp_btn_search.Click += new System.EventHandler(this.vp_btn_search_Click);
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 960);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vp_gv_patientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPatients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ViewPatients";
            ((System.ComponentModel.ISupportInitialize)(this.vp_gv_patientList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vp_gv_patientList;
        private System.Windows.Forms.Button btnRefreshPatientList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox vp_cb_assignedDoctor;
        private System.Windows.Forms.Button vp_btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vp_cb_patientGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vp_tb_patientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vp_tb_patientContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vp_tb_patientEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox vp_cb_allDoctors;
        private System.Windows.Forms.CheckBox vp_cb_allGenders;
        private System.Windows.Forms.Button vp_btn_CloseForm;
    }
}