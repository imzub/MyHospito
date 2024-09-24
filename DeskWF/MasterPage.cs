using DAL.CRUD;
using iHWinForm.ChildrenPages;

namespace MsfWinForm
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPatient.GetAllPatients();
        }

        //private void mi_viewpatients_Click(object sender, EventArgs e)
        //{
        //    AddPatientForm apf = new AddPatientForm();
        //    apf.Show();
        //}

        private void mi_viewpatients_Click_1(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatientForm apf = new AddPatientForm();
            apf.Show();
        }
    }
}