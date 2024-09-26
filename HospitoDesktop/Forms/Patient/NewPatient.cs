using HDAL.CRUDManager;
using HDAL.DBManager;
using System;
using System.Windows.Forms;
using HDAL.Models;
using HDAL.CRUD;
using System.IO;
using HDAL.Conn;
using System.Data.SqlClient;
using System.Data;
using static HDAL.DBManager.HEnum;

namespace HospitoDesktop.Forms.NewPatientForm
{
    public partial class NewPatient : Form
    {
        public static string currentImagePath = null;
        public NewPatient()
        {
            InitializeComponent();
            LoadComponents();
        }

        public NewPatient(Patient patient)
        {
            InitializeComponent();
            LoadComponents();

            np_tb_patientName.Text = patient.name;
            np_tb_patientEmail.Text = patient.email;
            np_tb_patientContact.Text = patient.contact;
            np_cb_patientAssignedDoctor.SelectedValue = patient.doctorId;
            //np_cb_patientGender.SelectedItem = patient.gender;
            np_tb_patientAddress.Text = patient.address;
            if (patient.image != null)
            {
                np_pb_patientPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(patient.image));
            }
            np_lbl_PatientId.Text = patient.patientId.ToString();
            foreach (var item in np_cb_patientGender.Items)
            {
                if (item is Gender && (Gender)item == (Gender)Enum.Parse(typeof(Gender), patient.gender))
                {
                    np_cb_patientGender.SelectedItem = item;
                    break; // Stop the loop once a match is found
                }
            }
        }

        private void btn_SavePatient_Click(object sender, EventArgs e)
        {
            bool isPatientUpdateRequest = false;
            if (np_lbl_PatientId.Text != string.Empty)
                isPatientUpdateRequest = true;

            Patient patient = new Patient();
            patient.name = np_tb_patientName.Text;
            patient.email = np_tb_patientEmail.Text;
            patient.contact = np_tb_patientContact.Text;
            patient.doctorId = Convert.ToInt32(np_cb_patientAssignedDoctor.SelectedValue);
            patient.gender = np_cb_patientGender.Text;
            patient.address = np_tb_patientAddress.Text;
            if (np_pb_patientPhoto.Image != null && currentImagePath != null)
            {
                patient.image = File.ReadAllBytes(currentImagePath);
                patient.imagePath = currentImagePath;
            }
            if (isPatientUpdateRequest)
                patient.patientId = Convert.ToInt32(np_lbl_PatientId.Text.Trim());
            bool result = CPatient.AddUpdatePatient(patient);
            string operation = isPatientUpdateRequest ? " Updated " : " Added ";
            if (result)
            {                
                MessageBox.Show("Patient" + operation + "Successfully.");
            }
            else
            {
                MessageBox.Show("Patient" + operation + "Failed!");
            }

            this.Close();
        }

        private void LoadComponents()
        {
            np_cb_patientGender.DataSource = Enum.GetValues(typeof(HEnum.Gender));
            np_cb_patientAssignedDoctor.DisplayMember = "name";
            np_cb_patientAssignedDoctor.ValueMember = "doctorId";
            np_cb_patientAssignedDoctor.DataSource = CDoctor.GetDoctorNameAndID();
            np_pb_patientPhoto.Image = System.Drawing.Image.FromFile(GetImagePath());
            currentImagePath = GetImagePath();
        }

        private void np_btn_browsePatientPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string imagePath = openFileDialog.FileName;

                    // Load and display the image in the PictureBox
                    np_pb_patientPhoto.Image = System.Drawing.Image.FromFile(imagePath);

                    // Store the image path in a global variable
                    currentImagePath = imagePath;
                }
            }
        }

        private void np_btn_clearPhoto_Click(object sender, EventArgs e)
        {
            np_pb_patientPhoto.Image = null;

            // CODE 1:
            //Patient p = new Patient();
            //p = HDAL.CRUD.CPatient.GetPatientById(12);
            //np_pb_patientPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(p.image));

            // CODE 2:
            //using (SqlConnection connection = new SqlConnection(HDAL.DBManager.Keys.connString))
            //{
            //    connection.Open();
            //    // Retrieve an image from the database
            //    string retrieveQuery = "select photo from patient where patientId = 12"; // Replace ImageID with the actual primary key column name
            //    using (SqlCommand cmd = new SqlCommand(retrieveQuery, connection))
            //    {
            //        //cmd.Parameters.Add("@ImageID", SqlDbType.Int).Value = 1; // Replace 1 with the actual ID of the image you want to retrieve
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                byte[] retrievedImageBytes = (byte[])reader["photo"];
            //                np_pb_patientPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(retrievedImageBytes));
            //                //File.WriteAllBytes("retrieved_image.jpg", retrievedImageBytes); // Save the retrieved image to a file
            //                Console.WriteLine("Image retrieved and saved to 'retrieved_image.jpg'.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Image not found.");
            //            }
            //        }
            //    }
            //}
        }

        private void np_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetImagePath()
        {
            string solutionFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(solutionFolderPath, "Assets", "ProfileIcon.jpg");
        }

        private void np_cb_patientAssignedDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
