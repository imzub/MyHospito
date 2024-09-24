namespace MsfWinForm
{
    partial class PatientForm
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
            btnPatientRefresh = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnPatientRefresh
            // 
            btnPatientRefresh.Location = new Point(1298, 47);
            btnPatientRefresh.Name = "btnPatientRefresh";
            btnPatientRefresh.Size = new Size(112, 34);
            btnPatientRefresh.TabIndex = 1;
            btnPatientRefresh.Text = "Refresh";
            btnPatientRefresh.UseVisualStyleBackColor = true;
            btnPatientRefresh.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 87);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(1398, 644);
            dataGridView2.TabIndex = 2;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 743);
            Controls.Add(dataGridView2);
            Controls.Add(btnPatientRefresh);
            Name = "PatientForm";
            Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        
        private Button btnPatientRefresh;
        private DataGridView dataGridView2;
    }
}