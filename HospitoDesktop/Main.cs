using HospitoDesktop.Forms.NewPatientForm;
using HospitoDesktop.Forms.ViewPatient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HBUL.WFHandler;
using HospitoDesktop.Forms.Doctor;
using HospitoDesktop.Forms.Appointment;
using HospitoDesktop.Forms.NewDoctor;
using HospitoDesktop.Forms.Report;

namespace HospitoDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.Show(this);
        }

        private void viewPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormKeys.ViewPatientForm)
            {
                ViewPatients vp = new ViewPatients();               
                vp.Show(this);
            }
        }

        private void mp_btn_ViewPatients_Click(object sender, EventArgs e)
        {
            if (!FormKeys.ViewPatientForm)
            {
                ViewPatients vp = new ViewPatients();
                vp.Show();
            }
        }

        private void viewDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDoctor viewDoctor = new ViewDoctor();
            viewDoctor.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!FormKeys.ViewDoctorForm)
            {
                ViewDoctor vd = new ViewDoctor();
                vd.Show();
            }
        }

        private void btn_NewPatientVisit_Click(object sender, EventArgs e)
        {
            PatientVisitAddUpdate pv = new PatientVisitAddUpdate();
            pv.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPatients vp = new ViewPatients();
            vp.Show(this);
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewDoctor viewDoctor = new ViewDoctor();
            viewDoctor.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewDoctor newDoctor = new NewDoctor();
            newDoctor.Show(this);
        }

        private void viewPatientAppointmentVisit_Click(object sender, EventArgs e)
        {
            ViewPatientVisit viewPatientVisitObj = new ViewPatientVisit();
            viewPatientVisitObj.Show(this);
        }

        private void main_btn_FileStorageMgmt_Click(object sender, EventArgs e)
        {
            SettingFileManagement settingFileManagement = new SettingFileManagement();
            settingFileManagement.Show(this);
        }

        private void btn_GF_Click(object sender, EventArgs e)
        {
            ReportGraphForm reportGraphForm = new ReportGraphForm();
            reportGraphForm.Show(this);
        }
    }
}
