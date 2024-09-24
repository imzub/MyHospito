using HDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HDAL.DBManager;
using HDAL.CRUD;
using HDAL.CRUDManager;
using HBUL.WFHandler;
using HospitoDesktop.Forms.NewPatientForm;

namespace HospitoDesktop.Forms.ViewPatient
{
    public partial class ViewPatients : Form
    {
        private bool btnEditDeleteAddedToGrid = false;
        public ViewPatients()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void btnRefreshPatientList_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(HKeys.connString))
            {
                connection.Open();

                // Define your SQL query
                string query = "SELECT * FROM patient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        vp_gv_patientList.DataSource = dataTable;
                    }
                }
            }
        }

        private void vp_btn_search_Click(object sender, EventArgs e)
        {
            //Patient po = new Patient();
            //po.name = vp_tb_patientName.Text.Trim();
            //po.contact = vp_tb_patientContact.Text.Trim();
            //po.email = vp_tb_patientEmail.Text.Trim();
            //if (vp_cb_allGenders.Checked)
            //    po.gender = string.Empty;
            //else
            //    po.gender = vp_cb_patientGender.Text.Trim();
            //if (vp_cb_allDoctors.Checked)
            //    po.doctorId = 0;
            //else
            //    po.doctorId = Convert.ToInt32(vp_cb_assignedDoctor.SelectedValue);

            //vp_gv_patientList.DataSource = null;
            //vp_gv_patientList.DataSource = CPatient.GetFilteredPatients(po);


            //vp_gv_patientList.DataSource = null;
            //vp_gv_patientList.DataSource = CPatient.GetFilteredPatients(GetSearchPatientCriteria());

            PopulateDataGridView();
        }

        private void LoadComponents()
        {
            FormKeys.ViewPatientForm = true;
            vp_cb_patientGender.DataSource = Enum.GetValues(typeof(HEnum.Gender));
            vp_cb_assignedDoctor.DisplayMember = "name";
            vp_cb_assignedDoctor.ValueMember = "doctorId";
            vp_cb_assignedDoctor.DataSource = CDoctor.GetDoctorNameAndID();
            FilterControlsHandler();
            vp_tb_patientName.Text = vp_tb_patientContact.Text = vp_tb_patientEmail.Text = string.Empty;
            this.FormClosing += ViewPatients_FormClosing;
            PopulateDataGridView();
        }

        private void vp_cb_allDoctors_CheckedChanged(object sender, EventArgs e)
        {
            FilterControlsHandler();
        }

        private void FilterControlsHandler()
        {
            if (vp_cb_allDoctors.Checked)
            {
                vp_cb_assignedDoctor.Enabled = false;
            }
            else
            {
                vp_cb_assignedDoctor.Enabled = true;
            }

            if (vp_cb_allGenders.Checked)
            {
                vp_cb_patientGender.Enabled = false;
            }
            else
            {
                vp_cb_patientGender.Enabled = true;
            }
        }

        private void vp_cb_allGenders_CheckedChanged(object sender, EventArgs e)
        {
            FilterControlsHandler();
        }

        private void vp_btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region vp_gv_patientList DataGridView - Patient DataGridView
        bool hasEditLinkColumn = false;
        private void vp_gv_patientList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //// Customize the appearance and behavior of the ID column (assuming it's the first column)
            //if (vp_gv_patientList.Columns.Count > 0 && !hasEditLinkColumn)
            //{
            //    // Hide the ID column
            //    vp_gv_patientList.Columns[0].Visible = false;

            //    // Add an edit link column (you can change the header text)
            //    DataGridViewLinkColumn editLinkColumn = new DataGridViewLinkColumn();
            //    editLinkColumn.Name = "EditLink";
            //    editLinkColumn.HeaderText = "";
            //    editLinkColumn.Text = "Edit";
            //    editLinkColumn.UseColumnTextForLinkValue = true;
            //    vp_gv_patientList.Columns.Insert(8, editLinkColumn); // Insert it as the second column
            //    hasEditLinkColumn = true;
            //}
        }

        //GridView Link Click Event - To edit patient details
        private void vp_gv_patientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex == vp_gv_patientList.Columns["EditLink"].Index)
            //{
            //    // Get the hidden ID value
            //    int rowId = (int)vp_gv_patientList.Rows[e.RowIndex].Cells["patientId"].Value;
            //    if (rowId > 0)
            //    {
            //        Patient patientDetails = new Patient();
            //        patientDetails = CPatient.GetPatientById(rowId);
            //        NewPatient np = new NewPatient(patientDetails);
            //        np.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Patient ID");
            //    }
            //}

            if (e.RowIndex >= 0)
            {
                if (vp_gv_patientList.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int patientId = (int)vp_gv_patientList.Rows[e.RowIndex].Cells["patientId"].Value;
                    if (patientId > 0)
                    {
                        ModifyPatientDetails(patientId);
                    }
                }
                else if (vp_gv_patientList.Columns[e.ColumnIndex].Name == "Delete")
                {                    
                    int patientId = (int)vp_gv_patientList.Rows[e.RowIndex].Cells["patientId"].Value;
                    if (patientId > 0)
                    {
                        DeletePatient(patientId);
                    }
                }
            }
        }

        private void PopulateDataGridView()
        {
            // Fetch data from the database and store it in a DataTable
            DataTable data = CPatient.GetFilteredPatients(GetSearchPatientCriteria());

            // Bind the data to the DataGridView
            vp_gv_patientList.DataSource = data;

            //Hide PatientId Column
            vp_gv_patientList.Columns["patientId"].Visible = false;

            if (!btnEditDeleteAddedToGrid)
            {
                // Create an "Edit" column
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                vp_gv_patientList.Columns.Add(editColumn);

                // Create a "Delete" column
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                vp_gv_patientList.Columns.Add(deleteColumn);
                btnEditDeleteAddedToGrid = true;
            }

            //Set Column HeaderName
            vp_gv_patientList.Columns["name"].HeaderText = "Name";
            vp_gv_patientList.Columns["contact"].HeaderText = "Contact";
            vp_gv_patientList.Columns["address"].HeaderText = "Address";
            vp_gv_patientList.Columns["email"].HeaderText = "Email";
            vp_gv_patientList.Columns["gender"].HeaderText = "Gender";
            vp_gv_patientList.Columns["doctorName"].HeaderText = "Assigned Doctor";

        }
        #endregion

        #region Form Events
        private void ViewPatients_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormKeys.ViewPatientForm = false;
        }

        private void ModifyPatientDetails(int patientId)
        {
            Patient patientDetails = new Patient();
            patientDetails = CPatient.GetPatientById(patientId);
            NewPatient np = new NewPatient(patientDetails);
            np.Show();
        }

        private void DeletePatient(int patientId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool deleteResult = CPatient.DeletePatient(patientId);
                if (deleteResult)
                {
                    // Deletion was successful
                    MessageBox.Show("Patient deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the DataGridView (refresh the data)
                    PopulateDataGridView();
                }
                else
                {
                    // Deletion failed
                    MessageBox.Show("Failed to delete the patient.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Common Operations
        //To get all data or selected values from View patient search section.
        private Patient GetSearchPatientCriteria()
        {
            Patient po = new Patient();
            po.name = vp_tb_patientName.Text.Trim();
            po.contact = vp_tb_patientContact.Text.Trim();
            po.email = vp_tb_patientEmail.Text.Trim();
            if (vp_cb_allGenders.Checked)
                po.gender = string.Empty;
            else
                po.gender = vp_cb_patientGender.Text.Trim();
            if (vp_cb_allDoctors.Checked)
                po.doctorId = 0;
            else
                po.doctorId = Convert.ToInt32(vp_cb_assignedDoctor.SelectedValue);

            return po;
        }
        #endregion
    }
}
