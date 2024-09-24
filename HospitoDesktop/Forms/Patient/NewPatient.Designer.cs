namespace HospitoDesktop.Forms.NewPatientForm
{
    partial class NewPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.np_tb_patientName = new System.Windows.Forms.TextBox();
            this.np_tb_patientEmail = new System.Windows.Forms.TextBox();
            this.np_tb_patientAddress = new System.Windows.Forms.TextBox();
            this.np_tb_patientContact = new System.Windows.Forms.TextBox();
            this.np_pb_patientPhoto = new System.Windows.Forms.PictureBox();
            this.np_btn_clearPhoto = new System.Windows.Forms.Button();
            this.np_btn_browsePatientPhoto = new System.Windows.Forms.Button();
            this.btn_SavePatient = new System.Windows.Forms.Button();
            this.np_btn_cancel = new System.Windows.Forms.Button();
            this.np_cb_patientGender = new System.Windows.Forms.ComboBox();
            this.np_cb_patientAssignedDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.np_lbl_PatientId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.np_pb_patientPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned Doctor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Contact :";
            // 
            // np_tb_patientName
            // 
            this.np_tb_patientName.Location = new System.Drawing.Point(149, 23);
            this.np_tb_patientName.Name = "np_tb_patientName";
            this.np_tb_patientName.Size = new System.Drawing.Size(391, 26);
            this.np_tb_patientName.TabIndex = 8;
            // 
            // np_tb_patientEmail
            // 
            this.np_tb_patientEmail.Location = new System.Drawing.Point(149, 158);
            this.np_tb_patientEmail.Name = "np_tb_patientEmail";
            this.np_tb_patientEmail.Size = new System.Drawing.Size(391, 26);
            this.np_tb_patientEmail.TabIndex = 9;
            // 
            // np_tb_patientAddress
            // 
            this.np_tb_patientAddress.Location = new System.Drawing.Point(149, 113);
            this.np_tb_patientAddress.Name = "np_tb_patientAddress";
            this.np_tb_patientAddress.Size = new System.Drawing.Size(391, 26);
            this.np_tb_patientAddress.TabIndex = 15;
            // 
            // np_tb_patientContact
            // 
            this.np_tb_patientContact.Location = new System.Drawing.Point(149, 68);
            this.np_tb_patientContact.Name = "np_tb_patientContact";
            this.np_tb_patientContact.Size = new System.Drawing.Size(391, 26);
            this.np_tb_patientContact.TabIndex = 16;
            // 
            // np_pb_patientPhoto
            // 
            this.np_pb_patientPhoto.Location = new System.Drawing.Point(580, 23);
            this.np_pb_patientPhoto.Name = "np_pb_patientPhoto";
            this.np_pb_patientPhoto.Size = new System.Drawing.Size(183, 161);
            this.np_pb_patientPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.np_pb_patientPhoto.TabIndex = 17;
            this.np_pb_patientPhoto.TabStop = false;
            // 
            // np_btn_clearPhoto
            // 
            this.np_btn_clearPhoto.Location = new System.Drawing.Point(580, 203);
            this.np_btn_clearPhoto.Name = "np_btn_clearPhoto";
            this.np_btn_clearPhoto.Size = new System.Drawing.Size(89, 36);
            this.np_btn_clearPhoto.TabIndex = 18;
            this.np_btn_clearPhoto.Text = "Clear";
            this.np_btn_clearPhoto.UseVisualStyleBackColor = true;
            this.np_btn_clearPhoto.Click += new System.EventHandler(this.np_btn_clearPhoto_Click);
            // 
            // np_btn_browsePatientPhoto
            // 
            this.np_btn_browsePatientPhoto.Location = new System.Drawing.Point(675, 203);
            this.np_btn_browsePatientPhoto.Name = "np_btn_browsePatientPhoto";
            this.np_btn_browsePatientPhoto.Size = new System.Drawing.Size(89, 36);
            this.np_btn_browsePatientPhoto.TabIndex = 19;
            this.np_btn_browsePatientPhoto.Text = "Browse";
            this.np_btn_browsePatientPhoto.UseVisualStyleBackColor = true;
            this.np_btn_browsePatientPhoto.Click += new System.EventHandler(this.np_btn_browsePatientPhoto_Click);
            // 
            // btn_SavePatient
            // 
            this.btn_SavePatient.Location = new System.Drawing.Point(677, 245);
            this.btn_SavePatient.Name = "btn_SavePatient";
            this.btn_SavePatient.Size = new System.Drawing.Size(89, 36);
            this.btn_SavePatient.TabIndex = 20;
            this.btn_SavePatient.Text = "Save";
            this.btn_SavePatient.UseVisualStyleBackColor = true;
            this.btn_SavePatient.Click += new System.EventHandler(this.btn_SavePatient_Click);
            // 
            // np_btn_cancel
            // 
            this.np_btn_cancel.Location = new System.Drawing.Point(582, 245);
            this.np_btn_cancel.Name = "np_btn_cancel";
            this.np_btn_cancel.Size = new System.Drawing.Size(89, 36);
            this.np_btn_cancel.TabIndex = 21;
            this.np_btn_cancel.Text = "Cancel";
            this.np_btn_cancel.UseVisualStyleBackColor = true;
            this.np_btn_cancel.Click += new System.EventHandler(this.np_btn_cancel_Click);
            // 
            // np_cb_patientGender
            // 
            this.np_cb_patientGender.FormattingEnabled = true;
            this.np_cb_patientGender.Location = new System.Drawing.Point(149, 200);
            this.np_cb_patientGender.Name = "np_cb_patientGender";
            this.np_cb_patientGender.Size = new System.Drawing.Size(252, 28);
            this.np_cb_patientGender.TabIndex = 22;
            // 
            // np_cb_patientAssignedDoctor
            // 
            this.np_cb_patientAssignedDoctor.FormattingEnabled = true;
            this.np_cb_patientAssignedDoctor.Location = new System.Drawing.Point(149, 245);
            this.np_cb_patientAssignedDoctor.Name = "np_cb_patientAssignedDoctor";
            this.np_cb_patientAssignedDoctor.Size = new System.Drawing.Size(252, 28);
            this.np_cb_patientAssignedDoctor.TabIndex = 23;
            this.np_cb_patientAssignedDoctor.SelectedIndexChanged += new System.EventHandler(this.np_cb_patientAssignedDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID :";
            // 
            // np_lbl_PatientId
            // 
            this.np_lbl_PatientId.AutoSize = true;
            this.np_lbl_PatientId.Location = new System.Drawing.Point(145, 291);
            this.np_lbl_PatientId.Name = "np_lbl_PatientId";
            this.np_lbl_PatientId.Size = new System.Drawing.Size(0, 20);
            this.np_lbl_PatientId.TabIndex = 25;
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 340);
            this.Controls.Add(this.np_lbl_PatientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.np_cb_patientAssignedDoctor);
            this.Controls.Add(this.np_cb_patientGender);
            this.Controls.Add(this.np_btn_cancel);
            this.Controls.Add(this.btn_SavePatient);
            this.Controls.Add(this.np_btn_browsePatientPhoto);
            this.Controls.Add(this.np_btn_clearPhoto);
            this.Controls.Add(this.np_pb_patientPhoto);
            this.Controls.Add(this.np_tb_patientContact);
            this.Controls.Add(this.np_tb_patientAddress);
            this.Controls.Add(this.np_tb_patientEmail);
            this.Controls.Add(this.np_tb_patientName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPatient";
            this.Text = "NewPatient";
            ((System.ComponentModel.ISupportInitialize)(this.np_pb_patientPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox np_tb_patientName;
        private System.Windows.Forms.TextBox np_tb_patientEmail;
        private System.Windows.Forms.TextBox np_tb_patientAddress;
        private System.Windows.Forms.TextBox np_tb_patientContact;
        private System.Windows.Forms.PictureBox np_pb_patientPhoto;
        private System.Windows.Forms.Button np_btn_clearPhoto;
        private System.Windows.Forms.Button np_btn_browsePatientPhoto;
        private System.Windows.Forms.Button btn_SavePatient;
        private System.Windows.Forms.Button np_btn_cancel;
        private System.Windows.Forms.ComboBox np_cb_patientGender;
        private System.Windows.Forms.ComboBox np_cb_patientAssignedDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label np_lbl_PatientId;
    }
}