namespace HospitoDesktop.Forms.Appointment
{
    partial class ViewPatientVisit
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
            this.vp_btn_CloseForm = new System.Windows.Forms.Button();
            this.vpv_chb_allDoctors = new System.Windows.Forms.CheckBox();
            this.btnRefreshPatientList = new System.Windows.Forms.Button();
            this.vpv_chb_allGenders = new System.Windows.Forms.CheckBox();
            this.vpv_tb_patientConcerns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vpv_tb_patientSymptoms = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vpv_cb_patientGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vpv_cb_assignedDoctor = new System.Windows.Forms.ComboBox();
            this.vpv_btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vpv_tb_paidFees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vpv_chb_AllFees = new System.Windows.Forms.CheckBox();
            this.vpv_cb_selectFees = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vpv_cb_selectPatient = new System.Windows.Forms.ComboBox();
            this.vpv_chb_AllPatient = new System.Windows.Forms.CheckBox();
            this.vpv_gv_patientVisitList = new System.Windows.Forms.DataGridView();
            this.vpv_btn_PDFExport = new System.Windows.Forms.Button();
            this.vpv_btn_ExcelExport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpv_gv_patientVisitList)).BeginInit();
            this.SuspendLayout();
            // 
            // vp_btn_CloseForm
            // 
            this.vp_btn_CloseForm.Location = new System.Drawing.Point(684, 179);
            this.vp_btn_CloseForm.Name = "vp_btn_CloseForm";
            this.vp_btn_CloseForm.Size = new System.Drawing.Size(94, 33);
            this.vp_btn_CloseForm.TabIndex = 33;
            this.vp_btn_CloseForm.Text = "Close";
            this.vp_btn_CloseForm.UseVisualStyleBackColor = true;
            // 
            // vpv_chb_allDoctors
            // 
            this.vpv_chb_allDoctors.AutoSize = true;
            this.vpv_chb_allDoctors.Location = new System.Drawing.Point(477, 65);
            this.vpv_chb_allDoctors.Name = "vpv_chb_allDoctors";
            this.vpv_chb_allDoctors.Size = new System.Drawing.Size(52, 24);
            this.vpv_chb_allDoctors.TabIndex = 32;
            this.vpv_chb_allDoctors.Text = "All";
            this.vpv_chb_allDoctors.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPatientList
            // 
            this.btnRefreshPatientList.Location = new System.Drawing.Point(884, 179);
            this.btnRefreshPatientList.Name = "btnRefreshPatientList";
            this.btnRefreshPatientList.Size = new System.Drawing.Size(143, 33);
            this.btnRefreshPatientList.TabIndex = 1;
            this.btnRefreshPatientList.Text = "All Records";
            this.btnRefreshPatientList.UseVisualStyleBackColor = true;
            // 
            // vpv_chb_allGenders
            // 
            this.vpv_chb_allGenders.AutoSize = true;
            this.vpv_chb_allGenders.Location = new System.Drawing.Point(477, 98);
            this.vpv_chb_allGenders.Name = "vpv_chb_allGenders";
            this.vpv_chb_allGenders.Size = new System.Drawing.Size(52, 24);
            this.vpv_chb_allGenders.TabIndex = 31;
            this.vpv_chb_allGenders.Text = "All";
            this.vpv_chb_allGenders.UseVisualStyleBackColor = true;
            // 
            // vpv_tb_patientConcerns
            // 
            this.vpv_tb_patientConcerns.Location = new System.Drawing.Point(146, 161);
            this.vpv_tb_patientConcerns.Name = "vpv_tb_patientConcerns";
            this.vpv_tb_patientConcerns.Size = new System.Drawing.Size(310, 26);
            this.vpv_tb_patientConcerns.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Concerns :";
            // 
            // vpv_tb_patientSymptoms
            // 
            this.vpv_tb_patientSymptoms.Location = new System.Drawing.Point(146, 129);
            this.vpv_tb_patientSymptoms.Name = "vpv_tb_patientSymptoms";
            this.vpv_tb_patientSymptoms.Size = new System.Drawing.Size(310, 26);
            this.vpv_tb_patientSymptoms.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Symptoms :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patient :";
            // 
            // vpv_cb_patientGender
            // 
            this.vpv_cb_patientGender.FormattingEnabled = true;
            this.vpv_cb_patientGender.Location = new System.Drawing.Point(146, 95);
            this.vpv_cb_patientGender.Name = "vpv_cb_patientGender";
            this.vpv_cb_patientGender.Size = new System.Drawing.Size(310, 28);
            this.vpv_cb_patientGender.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender :";
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
            // vpv_cb_assignedDoctor
            // 
            this.vpv_cb_assignedDoctor.FormattingEnabled = true;
            this.vpv_cb_assignedDoctor.Location = new System.Drawing.Point(146, 61);
            this.vpv_cb_assignedDoctor.Name = "vpv_cb_assignedDoctor";
            this.vpv_cb_assignedDoctor.Size = new System.Drawing.Size(310, 28);
            this.vpv_cb_assignedDoctor.TabIndex = 1;
            // 
            // vpv_btn_search
            // 
            this.vpv_btn_search.Location = new System.Drawing.Point(784, 179);
            this.vpv_btn_search.Name = "vpv_btn_search";
            this.vpv_btn_search.Size = new System.Drawing.Size(94, 33);
            this.vpv_btn_search.TabIndex = 0;
            this.vpv_btn_search.Text = "Search";
            this.vpv_btn_search.UseVisualStyleBackColor = true;
            this.vpv_btn_search.Click += new System.EventHandler(this.vpv_btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.vpv_btn_ExcelExport);
            this.groupBox1.Controls.Add(this.vpv_btn_PDFExport);
            this.groupBox1.Controls.Add(this.vpv_tb_paidFees);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.vpv_chb_AllFees);
            this.groupBox1.Controls.Add(this.vpv_cb_selectFees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.vpv_cb_selectPatient);
            this.groupBox1.Controls.Add(this.vpv_chb_AllPatient);
            this.groupBox1.Controls.Add(this.vp_btn_CloseForm);
            this.groupBox1.Controls.Add(this.vpv_chb_allDoctors);
            this.groupBox1.Controls.Add(this.btnRefreshPatientList);
            this.groupBox1.Controls.Add(this.vpv_chb_allGenders);
            this.groupBox1.Controls.Add(this.vpv_tb_patientConcerns);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vpv_tb_patientSymptoms);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vpv_cb_patientGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vpv_cb_assignedDoctor);
            this.groupBox1.Controls.Add(this.vpv_btn_search);
            this.groupBox1.Location = new System.Drawing.Point(2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1414, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // vpv_tb_paidFees
            // 
            this.vpv_tb_paidFees.Location = new System.Drawing.Point(717, 65);
            this.vpv_tb_paidFees.Name = "vpv_tb_paidFees";
            this.vpv_tb_paidFees.Size = new System.Drawing.Size(310, 26);
            this.vpv_tb_paidFees.TabIndex = 40;
            this.vpv_tb_paidFees.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Paid Fees";
            // 
            // vpv_chb_AllFees
            // 
            this.vpv_chb_AllFees.AutoSize = true;
            this.vpv_chb_AllFees.Location = new System.Drawing.Point(1048, 30);
            this.vpv_chb_AllFees.Name = "vpv_chb_AllFees";
            this.vpv_chb_AllFees.Size = new System.Drawing.Size(52, 24);
            this.vpv_chb_AllFees.TabIndex = 38;
            this.vpv_chb_AllFees.Text = "All";
            this.vpv_chb_AllFees.UseVisualStyleBackColor = true;
            // 
            // vpv_cb_selectFees
            // 
            this.vpv_cb_selectFees.FormattingEnabled = true;
            this.vpv_cb_selectFees.Location = new System.Drawing.Point(717, 27);
            this.vpv_cb_selectFees.Name = "vpv_cb_selectFees";
            this.vpv_cb_selectFees.Size = new System.Drawing.Size(310, 28);
            this.vpv_cb_selectFees.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fees :";
            // 
            // vpv_cb_selectPatient
            // 
            this.vpv_cb_selectPatient.FormattingEnabled = true;
            this.vpv_cb_selectPatient.Location = new System.Drawing.Point(146, 25);
            this.vpv_cb_selectPatient.Name = "vpv_cb_selectPatient";
            this.vpv_cb_selectPatient.Size = new System.Drawing.Size(310, 28);
            this.vpv_cb_selectPatient.TabIndex = 35;
            // 
            // vpv_chb_AllPatient
            // 
            this.vpv_chb_AllPatient.AutoSize = true;
            this.vpv_chb_AllPatient.Location = new System.Drawing.Point(477, 29);
            this.vpv_chb_AllPatient.Name = "vpv_chb_AllPatient";
            this.vpv_chb_AllPatient.Size = new System.Drawing.Size(52, 24);
            this.vpv_chb_AllPatient.TabIndex = 34;
            this.vpv_chb_AllPatient.Text = "All";
            this.vpv_chb_AllPatient.UseVisualStyleBackColor = true;
            // 
            // vpv_gv_patientVisitList
            // 
            this.vpv_gv_patientVisitList.AllowUserToAddRows = false;
            this.vpv_gv_patientVisitList.AllowUserToDeleteRows = false;
            this.vpv_gv_patientVisitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vpv_gv_patientVisitList.Location = new System.Drawing.Point(2, 223);
            this.vpv_gv_patientVisitList.Name = "vpv_gv_patientVisitList";
            this.vpv_gv_patientVisitList.ReadOnly = true;
            this.vpv_gv_patientVisitList.RowHeadersWidth = 62;
            this.vpv_gv_patientVisitList.RowTemplate.Height = 28;
            this.vpv_gv_patientVisitList.Size = new System.Drawing.Size(1414, 712);
            this.vpv_gv_patientVisitList.TabIndex = 3;
            // 
            // vpv_btn_PDFExport
            // 
            this.vpv_btn_PDFExport.Location = new System.Drawing.Point(1329, 152);
            this.vpv_btn_PDFExport.Name = "vpv_btn_PDFExport";
            this.vpv_btn_PDFExport.Size = new System.Drawing.Size(75, 30);
            this.vpv_btn_PDFExport.TabIndex = 41;
            this.vpv_btn_PDFExport.Text = "PDF";
            this.vpv_btn_PDFExport.UseVisualStyleBackColor = true;
            // 
            // vpv_btn_ExcelExport
            // 
            this.vpv_btn_ExcelExport.Location = new System.Drawing.Point(1329, 188);
            this.vpv_btn_ExcelExport.Name = "vpv_btn_ExcelExport";
            this.vpv_btn_ExcelExport.Size = new System.Drawing.Size(75, 30);
            this.vpv_btn_ExcelExport.TabIndex = 42;
            this.vpv_btn_ExcelExport.Text = "Excel";
            this.vpv_btn_ExcelExport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1259, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Export :";
            // 
            // ViewPatientVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 947);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vpv_gv_patientVisitList);
            this.Name = "ViewPatientVisit";
            this.Text = "ViewPatientVisit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpv_gv_patientVisitList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vp_btn_CloseForm;
        private System.Windows.Forms.CheckBox vpv_chb_allDoctors;
        private System.Windows.Forms.Button btnRefreshPatientList;
        private System.Windows.Forms.CheckBox vpv_chb_allGenders;
        private System.Windows.Forms.TextBox vpv_tb_patientConcerns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vpv_tb_patientSymptoms;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vpv_cb_patientGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vpv_btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView vpv_gv_patientVisitList;
        private System.Windows.Forms.ComboBox vpv_cb_selectPatient;
        private System.Windows.Forms.CheckBox vpv_chb_AllPatient;
        private System.Windows.Forms.TextBox vpv_tb_paidFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox vpv_chb_AllFees;
        private System.Windows.Forms.ComboBox vpv_cb_selectFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vpv_cb_assignedDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button vpv_btn_ExcelExport;
        private System.Windows.Forms.Button vpv_btn_PDFExport;
    }
}