using HDAL.CRUD;
using HDAL.CRUDManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitoDesktop.Forms.Appointment
{
    public partial class PatientVisitAddUpdate : Form
    {
        public PatientVisitAddUpdate()
        {
            InitializeComponent();
            LoadComponent();
        }

        #region Initialize Components
        private void LoadComponent()
        {
            pv_cb_SelectPatient.DisplayMember = "name";
            pv_cb_SelectPatient.ValueMember = "patientId";
            pv_cb_SelectPatient.DataSource = CPatient.GetPatientNameAndId();
        }

        private void LoadPatientDetails()
        {
            int pid = Convert.ToInt32(pv_cb_SelectPatient.SelectedValue);
            if (pid > 0)
            {
                Patient patient = new Patient();
                patient = CPatient.GetPatientById(pid);
                pv_tb_patientName.Text = patient.name;
                pv_tb_patientAddress.Text = patient.address;
                pv_tb_patientEmail.Text = patient.email;
                pv_tb_patientGender.Text = patient.gender;
                pv_tb_patientContact.Text = patient.contact;
                pv_tb_patientAssignedDoctor.Text = Convert.ToString(patient.doctorId);
                pv_tb_patientId.Text = Convert.ToString(patient.patientId);
                if (patient.image != null)
                {
                    using (MemoryStream ms = new MemoryStream(patient.image))
                    {
                        Image image = Image.FromStream(ms);
                        pv_pb_patientPhoto.Image = image;
                    }
                }
            }
        }
        #endregion

        #region Component Events
        private void pv_cb_SelectPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatientDetails();
        }

        #endregion

        private void np_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveUpdatePatient_Click(object sender, EventArgs e)
        {

        }

        private void pv_tb_clearForm_Click(object sender, EventArgs e)
        {

        }
    }
}
