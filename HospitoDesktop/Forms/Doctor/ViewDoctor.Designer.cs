namespace HospitoDesktop.Forms.Doctor
{
    partial class ViewDoctor
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
            this.vd_cb_allGenders = new System.Windows.Forms.CheckBox();
            this.vd_tb_doctorEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.vd_tb_doctorContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vd_tb_doctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vd_cb_doctorGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vd_btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vd_gv_doctorList = new System.Windows.Forms.DataGridView();
            this.vd_tb_doctorAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vd_gv_doctorList)).BeginInit();
            this.SuspendLayout();
            // 
            // vd_cb_allGenders
            // 
            this.vd_cb_allGenders.AutoSize = true;
            this.vd_cb_allGenders.Location = new System.Drawing.Point(404, 63);
            this.vd_cb_allGenders.Name = "vd_cb_allGenders";
            this.vd_cb_allGenders.Size = new System.Drawing.Size(52, 24);
            this.vd_cb_allGenders.TabIndex = 31;
            this.vd_cb_allGenders.Text = "All";
            this.vd_cb_allGenders.UseVisualStyleBackColor = true;
            // 
            // vd_tb_doctorEmail
            // 
            this.vd_tb_doctorEmail.Location = new System.Drawing.Point(608, 64);
            this.vd_tb_doctorEmail.Name = "vd_tb_doctorEmail";
            this.vd_tb_doctorEmail.Size = new System.Drawing.Size(310, 26);
            this.vd_tb_doctorEmail.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // vd_tb_doctorContact
            // 
            this.vd_tb_doctorContact.Location = new System.Drawing.Point(146, 95);
            this.vd_tb_doctorContact.Name = "vd_tb_doctorContact";
            this.vd_tb_doctorContact.Size = new System.Drawing.Size(310, 26);
            this.vd_tb_doctorContact.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contact :";
            // 
            // vd_tb_doctorName
            // 
            this.vd_tb_doctorName.Location = new System.Drawing.Point(146, 29);
            this.vd_tb_doctorName.Name = "vd_tb_doctorName";
            this.vd_tb_doctorName.Size = new System.Drawing.Size(310, 26);
            this.vd_tb_doctorName.TabIndex = 26;
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
            // vd_cb_doctorGender
            // 
            this.vd_cb_doctorGender.FormattingEnabled = true;
            this.vd_cb_doctorGender.Location = new System.Drawing.Point(146, 61);
            this.vd_cb_doctorGender.Name = "vd_cb_doctorGender";
            this.vd_cb_doctorGender.Size = new System.Drawing.Size(242, 28);
            this.vd_cb_doctorGender.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender";
            // 
            // vd_btn_search
            // 
            this.vd_btn_search.Location = new System.Drawing.Point(936, 29);
            this.vd_btn_search.Name = "vd_btn_search";
            this.vd_btn_search.Size = new System.Drawing.Size(94, 33);
            this.vd_btn_search.TabIndex = 0;
            this.vd_btn_search.Text = "Search";
            this.vd_btn_search.UseVisualStyleBackColor = true;
            this.vd_btn_search.Click += new System.EventHandler(this.vd_btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vd_tb_doctorAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vd_cb_allGenders);
            this.groupBox1.Controls.Add(this.vd_tb_doctorEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.vd_tb_doctorContact);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.vd_tb_doctorName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vd_cb_doctorGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.vd_btn_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // vd_gv_doctorList
            // 
            this.vd_gv_doctorList.AllowUserToAddRows = false;
            this.vd_gv_doctorList.AllowUserToDeleteRows = false;
            this.vd_gv_doctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vd_gv_doctorList.Location = new System.Drawing.Point(12, 146);
            this.vd_gv_doctorList.Name = "vd_gv_doctorList";
            this.vd_gv_doctorList.ReadOnly = true;
            this.vd_gv_doctorList.RowHeadersWidth = 62;
            this.vd_gv_doctorList.RowTemplate.Height = 28;
            this.vd_gv_doctorList.Size = new System.Drawing.Size(1037, 472);
            this.vd_gv_doctorList.TabIndex = 3;
            // 
            // vd_tb_doctorAddress
            // 
            this.vd_tb_doctorAddress.Location = new System.Drawing.Point(608, 29);
            this.vd_tb_doctorAddress.Name = "vd_tb_doctorAddress";
            this.vd_tb_doctorAddress.Size = new System.Drawing.Size(310, 26);
            this.vd_tb_doctorAddress.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Address :";
            // 
            // ViewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vd_gv_doctorList);
            this.Name = "ViewDoctor";
            this.Text = "ViewDoctor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vd_gv_doctorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox vd_cb_allGenders;
        private System.Windows.Forms.TextBox vd_tb_doctorEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vd_tb_doctorContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vd_tb_doctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vd_cb_doctorGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button vd_btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView vd_gv_doctorList;
        private System.Windows.Forms.TextBox vd_tb_doctorAddress;
        private System.Windows.Forms.Label label2;
    }
}