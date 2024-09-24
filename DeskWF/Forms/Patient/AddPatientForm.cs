using DAL.CRUD;
using DAL.Models;
using HDAL.DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iHWinForm.ChildrenPages
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
            apcb_pgender.DataSource = Enum.GetValues(typeof(HEnum.Gender));
        }

        private void btnSaveNewPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.name = anpt_pname.Text;
            patient.email = anpt_pemail.Text;
            patient.contact = anpt_pcontact.Text;
            patient.doctorId = Convert.ToInt32(anpt_pdoctorid.Text);
            patient.gender = apcb_pgender.Text;
            patient.address = anpt_paddress.Text;

            CPatient.AddNewPatient(patient);
            MessageBox.Show("Patient Added Successfully");
            this.Close();
        }
    }
}
