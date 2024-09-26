namespace iHWinForm.ChildrenPages
{
    partial class AddPatientForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            anpt_pname = new TextBox();
            anpt_pcontact = new TextBox();
            anpt_paddress = new TextBox();
            anpt_pemail = new TextBox();
            textBox5 = new TextBox();
            btnSaveNewPatient = new Button();
            label6 = new Label();
            anpt_pdoctorid = new TextBox();
            apcb_pgender = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Patient Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Contract";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 89);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 119);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // anpt_pname
            // 
            anpt_pname.Location = new Point(197, 30);
            anpt_pname.Margin = new Padding(2);
            anpt_pname.Name = "anpt_pname";
            anpt_pname.Size = new Size(106, 23);
            anpt_pname.TabIndex = 5;
            // 
            // anpt_pcontact
            // 
            anpt_pcontact.Location = new Point(197, 62);
            anpt_pcontact.Margin = new Padding(2);
            anpt_pcontact.Name = "anpt_pcontact";
            anpt_pcontact.Size = new Size(106, 23);
            anpt_pcontact.TabIndex = 6;
            // 
            // anpt_paddress
            // 
            anpt_paddress.Location = new Point(197, 89);
            anpt_paddress.Margin = new Padding(2);
            anpt_paddress.Name = "anpt_paddress";
            anpt_paddress.Size = new Size(106, 23);
            anpt_paddress.TabIndex = 7;
            // 
            // anpt_pemail
            // 
            anpt_pemail.Location = new Point(197, 117);
            anpt_pemail.Margin = new Padding(2);
            anpt_pemail.Name = "anpt_pemail";
            anpt_pemail.Size = new Size(106, 23);
            anpt_pemail.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 154);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(106, 23);
            textBox5.TabIndex = 9;
            // 
            // btnSaveNewPatient
            // 
            btnSaveNewPatient.Location = new Point(161, 217);
            btnSaveNewPatient.Margin = new Padding(2);
            btnSaveNewPatient.Name = "btnSaveNewPatient";
            btnSaveNewPatient.Size = new Size(78, 20);
            btnSaveNewPatient.TabIndex = 10;
            btnSaveNewPatient.Text = "Save";
            btnSaveNewPatient.UseVisualStyleBackColor = true;
            btnSaveNewPatient.Click += btnSaveNewPatient_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 184);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 11;
            label6.Text = "Doctor";
            // 
            // anpt_pdoctorid
            // 
            anpt_pdoctorid.Location = new Point(197, 184);
            anpt_pdoctorid.Margin = new Padding(2);
            anpt_pdoctorid.Name = "anpt_pdoctorid";
            anpt_pdoctorid.Size = new Size(106, 23);
            anpt_pdoctorid.TabIndex = 12;
            // 
            // apcb_pgender
            // 
            apcb_pgender.FormattingEnabled = true;
            apcb_pgender.Location = new Point(308, 156);
            apcb_pgender.Name = "apcb_pgender";
            apcb_pgender.Size = new Size(121, 23);
            apcb_pgender.TabIndex = 13;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 460);
            Controls.Add(apcb_pgender);
            Controls.Add(anpt_pdoctorid);
            Controls.Add(label6);
            Controls.Add(btnSaveNewPatient);
            Controls.Add(textBox5);
            Controls.Add(anpt_pemail);
            Controls.Add(anpt_paddress);
            Controls.Add(anpt_pcontact);
            Controls.Add(anpt_pname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AddPatientForm";
            Text = "AddPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox anpt_pname;
        private TextBox anpt_pcontact;
        private TextBox anpt_paddress;
        private TextBox anpt_pemail;
        private TextBox textBox5;
        private Button btnSaveNewPatient;
        private Label label6;
        private TextBox anpt_pdoctorid;
        private ComboBox apcb_pgender;
    }
}