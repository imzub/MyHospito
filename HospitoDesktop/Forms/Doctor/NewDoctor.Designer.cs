namespace HospitoDesktop.Forms.NewDoctor
{
    partial class NewDoctor
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
            this.nd_lbl_DoctorId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nd_cb_doctorGender = new System.Windows.Forms.ComboBox();
            this.nd_btn_cancel = new System.Windows.Forms.Button();
            this.nd_btn_SaveUpdateDoctor = new System.Windows.Forms.Button();
            this.nd_btn_browseDoctorPhoto = new System.Windows.Forms.Button();
            this.nd_btn_clearPhoto = new System.Windows.Forms.Button();
            this.nd_pb_doctorPhoto = new System.Windows.Forms.PictureBox();
            this.nd_tb_doctorContact = new System.Windows.Forms.TextBox();
            this.nd_tb_doctorAddress = new System.Windows.Forms.TextBox();
            this.nd_tb_doctorEmail = new System.Windows.Forms.TextBox();
            this.nd_tb_doctorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nd_pb_doctorPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // nd_lbl_DoctorId
            // 
            this.nd_lbl_DoctorId.AutoSize = true;
            this.nd_lbl_DoctorId.Location = new System.Drawing.Point(144, 235);
            this.nd_lbl_DoctorId.Name = "nd_lbl_DoctorId";
            this.nd_lbl_DoctorId.Size = new System.Drawing.Size(0, 20);
            this.nd_lbl_DoctorId.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "ID :";
            // 
            // nd_cb_doctorGender
            // 
            this.nd_cb_doctorGender.FormattingEnabled = true;
            this.nd_cb_doctorGender.Location = new System.Drawing.Point(148, 190);
            this.nd_cb_doctorGender.Name = "nd_cb_doctorGender";
            this.nd_cb_doctorGender.Size = new System.Drawing.Size(252, 28);
            this.nd_cb_doctorGender.TabIndex = 60;
            // 
            // nd_btn_cancel
            // 
            this.nd_btn_cancel.Location = new System.Drawing.Point(581, 235);
            this.nd_btn_cancel.Name = "nd_btn_cancel";
            this.nd_btn_cancel.Size = new System.Drawing.Size(89, 36);
            this.nd_btn_cancel.TabIndex = 59;
            this.nd_btn_cancel.Text = "Cancel";
            this.nd_btn_cancel.UseVisualStyleBackColor = true;
            this.nd_btn_cancel.Click += new System.EventHandler(this.nd_btn_cancel_Click);
            // 
            // nd_btn_SaveUpdateDoctor
            // 
            this.nd_btn_SaveUpdateDoctor.Location = new System.Drawing.Point(676, 235);
            this.nd_btn_SaveUpdateDoctor.Name = "nd_btn_SaveUpdateDoctor";
            this.nd_btn_SaveUpdateDoctor.Size = new System.Drawing.Size(89, 36);
            this.nd_btn_SaveUpdateDoctor.TabIndex = 58;
            this.nd_btn_SaveUpdateDoctor.Text = "Save";
            this.nd_btn_SaveUpdateDoctor.UseVisualStyleBackColor = true;
            this.nd_btn_SaveUpdateDoctor.Click += new System.EventHandler(this.nd_btn_SaveUpdateDoctor_Click);
            // 
            // nd_btn_browseDoctorPhoto
            // 
            this.nd_btn_browseDoctorPhoto.Location = new System.Drawing.Point(674, 193);
            this.nd_btn_browseDoctorPhoto.Name = "nd_btn_browseDoctorPhoto";
            this.nd_btn_browseDoctorPhoto.Size = new System.Drawing.Size(89, 36);
            this.nd_btn_browseDoctorPhoto.TabIndex = 57;
            this.nd_btn_browseDoctorPhoto.Text = "Browse";
            this.nd_btn_browseDoctorPhoto.UseVisualStyleBackColor = true;
            this.nd_btn_browseDoctorPhoto.Click += new System.EventHandler(this.nd_btn_browseDoctorPhoto_Click);
            // 
            // nd_btn_clearPhoto
            // 
            this.nd_btn_clearPhoto.Location = new System.Drawing.Point(579, 193);
            this.nd_btn_clearPhoto.Name = "nd_btn_clearPhoto";
            this.nd_btn_clearPhoto.Size = new System.Drawing.Size(89, 36);
            this.nd_btn_clearPhoto.TabIndex = 56;
            this.nd_btn_clearPhoto.Text = "Clear";
            this.nd_btn_clearPhoto.UseVisualStyleBackColor = true;
            this.nd_btn_clearPhoto.Click += new System.EventHandler(this.nd_btn_clearPhoto_Click);
            // 
            // nd_pb_doctorPhoto
            // 
            this.nd_pb_doctorPhoto.Location = new System.Drawing.Point(579, 13);
            this.nd_pb_doctorPhoto.Name = "nd_pb_doctorPhoto";
            this.nd_pb_doctorPhoto.Size = new System.Drawing.Size(183, 161);
            this.nd_pb_doctorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nd_pb_doctorPhoto.TabIndex = 55;
            this.nd_pb_doctorPhoto.TabStop = false;
            // 
            // nd_tb_doctorContact
            // 
            this.nd_tb_doctorContact.Location = new System.Drawing.Point(148, 58);
            this.nd_tb_doctorContact.Name = "nd_tb_doctorContact";
            this.nd_tb_doctorContact.Size = new System.Drawing.Size(391, 26);
            this.nd_tb_doctorContact.TabIndex = 54;
            // 
            // nd_tb_doctorAddress
            // 
            this.nd_tb_doctorAddress.Location = new System.Drawing.Point(148, 103);
            this.nd_tb_doctorAddress.Name = "nd_tb_doctorAddress";
            this.nd_tb_doctorAddress.Size = new System.Drawing.Size(391, 26);
            this.nd_tb_doctorAddress.TabIndex = 53;
            // 
            // nd_tb_doctorEmail
            // 
            this.nd_tb_doctorEmail.Location = new System.Drawing.Point(148, 148);
            this.nd_tb_doctorEmail.Name = "nd_tb_doctorEmail";
            this.nd_tb_doctorEmail.Size = new System.Drawing.Size(391, 26);
            this.nd_tb_doctorEmail.TabIndex = 52;
            // 
            // nd_tb_doctorName
            // 
            this.nd_tb_doctorName.Location = new System.Drawing.Point(148, 13);
            this.nd_tb_doctorName.Name = "nd_tb_doctorName";
            this.nd_tb_doctorName.Size = new System.Drawing.Size(391, 26);
            this.nd_tb_doctorName.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Contact :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gender :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name :";
            // 
            // NewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 284);
            this.Controls.Add(this.nd_lbl_DoctorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nd_cb_doctorGender);
            this.Controls.Add(this.nd_btn_cancel);
            this.Controls.Add(this.nd_btn_SaveUpdateDoctor);
            this.Controls.Add(this.nd_btn_browseDoctorPhoto);
            this.Controls.Add(this.nd_btn_clearPhoto);
            this.Controls.Add(this.nd_pb_doctorPhoto);
            this.Controls.Add(this.nd_tb_doctorContact);
            this.Controls.Add(this.nd_tb_doctorAddress);
            this.Controls.Add(this.nd_tb_doctorEmail);
            this.Controls.Add(this.nd_tb_doctorName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "NewDoctor";
            this.Text = "NewDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.nd_pb_doctorPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nd_lbl_DoctorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox nd_cb_doctorGender;
        private System.Windows.Forms.Button nd_btn_cancel;
        private System.Windows.Forms.Button nd_btn_SaveUpdateDoctor;
        private System.Windows.Forms.Button nd_btn_browseDoctorPhoto;
        private System.Windows.Forms.Button nd_btn_clearPhoto;
        private System.Windows.Forms.PictureBox nd_pb_doctorPhoto;
        private System.Windows.Forms.TextBox nd_tb_doctorContact;
        private System.Windows.Forms.TextBox nd_tb_doctorAddress;
        private System.Windows.Forms.TextBox nd_tb_doctorEmail;
        private System.Windows.Forms.TextBox nd_tb_doctorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}