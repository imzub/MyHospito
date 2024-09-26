namespace MsfWinForm
{
    partial class MasterPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            patientsToolStripMenuItem1 = new ToolStripMenuItem();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            mi_viewpatients = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            doctorToolStripMenuItem = new ToolStripMenuItem();
            addNewDoctorToolStripMenuItem = new ToolStripMenuItem();
            viewDoctorsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(0, 865);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1497, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, optionsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1497, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patientsToolStripMenuItem1, doctorToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(68, 29);
            viewToolStripMenuItem.Text = "Goto";
            // 
            // patientsToolStripMenuItem1
            // 
            patientsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, mi_viewpatients });
            patientsToolStripMenuItem1.Name = "patientsToolStripMenuItem1";
            patientsToolStripMenuItem1.Size = new Size(270, 34);
            patientsToolStripMenuItem1.Text = "Patient";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(270, 34);
            addNewToolStripMenuItem.Text = "Add New";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // mi_viewpatients
            // 
            mi_viewpatients.Name = "mi_viewpatients";
            mi_viewpatients.Size = new Size(270, 34);
            mi_viewpatients.Text = "View Patients";
            mi_viewpatients.Click += mi_viewpatients_Click_1;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(92, 29);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // button1
            // 
            button1.Location = new Point(133, 105);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doctorToolStripMenuItem
            // 
            doctorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDoctorToolStripMenuItem, viewDoctorsToolStripMenuItem });
            doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            doctorToolStripMenuItem.Size = new Size(270, 34);
            doctorToolStripMenuItem.Text = "Doctor";
            // 
            // addNewDoctorToolStripMenuItem
            // 
            addNewDoctorToolStripMenuItem.Name = "addNewDoctorToolStripMenuItem";
            addNewDoctorToolStripMenuItem.Size = new Size(270, 34);
            addNewDoctorToolStripMenuItem.Text = "Add New Doctor";
            // 
            // viewDoctorsToolStripMenuItem
            // 
            viewDoctorsToolStripMenuItem.Name = "viewDoctorsToolStripMenuItem";
            viewDoctorsToolStripMenuItem.Size = new Size(270, 34);
            viewDoctorsToolStripMenuItem.Text = "View Doctors";
            // 
            // MasterPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 887);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MasterPage";
            Text = "Mishifa Clinic";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem patientsToolStripMenuItem1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem mi_viewpatients;
        private ToolStripMenuItem doctorToolStripMenuItem;
        private ToolStripMenuItem addNewDoctorToolStripMenuItem;
        private ToolStripMenuItem viewDoctorsToolStripMenuItem;
    }
}