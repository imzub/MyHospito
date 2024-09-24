namespace HospitoDesktop.Forms.Report
{
    partial class SettingFileManagement
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
            this.sfm_cb_SelectForm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sfm_tb_FileLocation = new System.Windows.Forms.TextBox();
            this.sfm_tb_FileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfm_btn_LocationBrowse = new System.Windows.Forms.Button();
            this.sfm_btn_SaveUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sfm_lbl__LastUpdated = new System.Windows.Forms.Label();
            this.sfm_tb_Description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sfm_btn_Delete = new System.Windows.Forms.Button();
            this.sfm_btn_New = new System.Windows.Forms.Button();
            this.sfm_btn_close = new System.Windows.Forms.Button();
            this.sfm_lbl_FLID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Form :";
            // 
            // sfm_cb_SelectForm
            // 
            this.sfm_cb_SelectForm.FormattingEnabled = true;
            this.sfm_cb_SelectForm.Location = new System.Drawing.Point(155, 30);
            this.sfm_cb_SelectForm.Name = "sfm_cb_SelectForm";
            this.sfm_cb_SelectForm.Size = new System.Drawing.Size(677, 28);
            this.sfm_cb_SelectForm.TabIndex = 1;
            this.sfm_cb_SelectForm.SelectedIndexChanged += new System.EventHandler(this.sfm_cb_SelectForm_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Location :";
            // 
            // sfm_tb_FileLocation
            // 
            this.sfm_tb_FileLocation.Location = new System.Drawing.Point(155, 100);
            this.sfm_tb_FileLocation.Name = "sfm_tb_FileLocation";
            this.sfm_tb_FileLocation.Size = new System.Drawing.Size(677, 26);
            this.sfm_tb_FileLocation.TabIndex = 3;
            // 
            // sfm_tb_FileName
            // 
            this.sfm_tb_FileName.Location = new System.Drawing.Point(155, 64);
            this.sfm_tb_FileName.Name = "sfm_tb_FileName";
            this.sfm_tb_FileName.Size = new System.Drawing.Size(677, 26);
            this.sfm_tb_FileName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Name :";
            // 
            // sfm_btn_LocationBrowse
            // 
            this.sfm_btn_LocationBrowse.Location = new System.Drawing.Point(838, 100);
            this.sfm_btn_LocationBrowse.Name = "sfm_btn_LocationBrowse";
            this.sfm_btn_LocationBrowse.Size = new System.Drawing.Size(75, 32);
            this.sfm_btn_LocationBrowse.TabIndex = 6;
            this.sfm_btn_LocationBrowse.Text = "Browse";
            this.sfm_btn_LocationBrowse.UseVisualStyleBackColor = true;
            this.sfm_btn_LocationBrowse.Click += new System.EventHandler(this.sfm_btn_LocationBrowse_Click);
            // 
            // sfm_btn_SaveUpdate
            // 
            this.sfm_btn_SaveUpdate.Location = new System.Drawing.Point(838, 308);
            this.sfm_btn_SaveUpdate.Name = "sfm_btn_SaveUpdate";
            this.sfm_btn_SaveUpdate.Size = new System.Drawing.Size(75, 37);
            this.sfm_btn_SaveUpdate.TabIndex = 7;
            this.sfm_btn_SaveUpdate.Text = "Save";
            this.sfm_btn_SaveUpdate.UseVisualStyleBackColor = true;
            this.sfm_btn_SaveUpdate.Click += new System.EventHandler(this.sfm_btn_SaveUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Updated :";
            // 
            // sfm_lbl__LastUpdated
            // 
            this.sfm_lbl__LastUpdated.AutoSize = true;
            this.sfm_lbl__LastUpdated.Location = new System.Drawing.Point(151, 230);
            this.sfm_lbl__LastUpdated.Name = "sfm_lbl__LastUpdated";
            this.sfm_lbl__LastUpdated.Size = new System.Drawing.Size(0, 20);
            this.sfm_lbl__LastUpdated.TabIndex = 9;
            // 
            // sfm_tb_Description
            // 
            this.sfm_tb_Description.Location = new System.Drawing.Point(155, 135);
            this.sfm_tb_Description.Multiline = true;
            this.sfm_tb_Description.Name = "sfm_tb_Description";
            this.sfm_tb_Description.Size = new System.Drawing.Size(677, 86);
            this.sfm_tb_Description.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description :";
            // 
            // sfm_btn_Delete
            // 
            this.sfm_btn_Delete.Location = new System.Drawing.Point(838, 30);
            this.sfm_btn_Delete.Name = "sfm_btn_Delete";
            this.sfm_btn_Delete.Size = new System.Drawing.Size(75, 32);
            this.sfm_btn_Delete.TabIndex = 12;
            this.sfm_btn_Delete.Text = "Delete";
            this.sfm_btn_Delete.UseVisualStyleBackColor = true;
            this.sfm_btn_Delete.Click += new System.EventHandler(this.sfm_btn_Delete_Click);
            // 
            // sfm_btn_New
            // 
            this.sfm_btn_New.Location = new System.Drawing.Point(757, 308);
            this.sfm_btn_New.Name = "sfm_btn_New";
            this.sfm_btn_New.Size = new System.Drawing.Size(75, 37);
            this.sfm_btn_New.TabIndex = 13;
            this.sfm_btn_New.Text = "New";
            this.sfm_btn_New.UseVisualStyleBackColor = true;
            this.sfm_btn_New.Click += new System.EventHandler(this.sfm_btn_New_Click);
            // 
            // sfm_btn_close
            // 
            this.sfm_btn_close.Location = new System.Drawing.Point(676, 308);
            this.sfm_btn_close.Name = "sfm_btn_close";
            this.sfm_btn_close.Size = new System.Drawing.Size(75, 37);
            this.sfm_btn_close.TabIndex = 14;
            this.sfm_btn_close.Text = "Close";
            this.sfm_btn_close.UseVisualStyleBackColor = true;
            this.sfm_btn_close.Click += new System.EventHandler(this.sfm_btn_close_Click);
            // 
            // sfm_lbl_FLID
            // 
            this.sfm_lbl_FLID.AutoSize = true;
            this.sfm_lbl_FLID.Location = new System.Drawing.Point(151, 259);
            this.sfm_lbl_FLID.Name = "sfm_lbl_FLID";
            this.sfm_lbl_FLID.Size = new System.Drawing.Size(0, 20);
            this.sfm_lbl_FLID.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "FLID :";
            // 
            // SettingFileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 357);
            this.Controls.Add(this.sfm_lbl_FLID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sfm_btn_close);
            this.Controls.Add(this.sfm_btn_New);
            this.Controls.Add(this.sfm_btn_Delete);
            this.Controls.Add(this.sfm_tb_Description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sfm_lbl__LastUpdated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sfm_btn_SaveUpdate);
            this.Controls.Add(this.sfm_btn_LocationBrowse);
            this.Controls.Add(this.sfm_tb_FileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sfm_tb_FileLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sfm_cb_SelectForm);
            this.Controls.Add(this.label1);
            this.Name = "SettingFileManagement";
            this.Text = "SettingFileManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sfm_cb_SelectForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sfm_tb_FileLocation;
        private System.Windows.Forms.TextBox sfm_tb_FileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sfm_btn_SaveUpdate;
        private System.Windows.Forms.Button sfm_btn_LocationBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sfm_lbl__LastUpdated;
        private System.Windows.Forms.TextBox sfm_tb_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sfm_btn_Delete;
        private System.Windows.Forms.Button sfm_btn_New;
        private System.Windows.Forms.Button sfm_btn_close;
        private System.Windows.Forms.Label sfm_lbl_FLID;
        private System.Windows.Forms.Label label7;
    }
}