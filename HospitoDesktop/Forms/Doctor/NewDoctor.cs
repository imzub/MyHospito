using HDAL.CRUD;
using HDAL.CRUDManager;
using HDAL.DBManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitoDesktop.Forms.NewDoctor
{
    public partial class NewDoctor : Form
    {
        public static string currentDoctorImagePath = null;
        public NewDoctor()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void nd_btn_clearPhoto_Click(object sender, EventArgs e)
        {
            nd_pb_doctorPhoto.Image = null;
        }

        private void nd_btn_browseDoctorPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                nd_pb_doctorPhoto.Image = new Bitmap(open.FileName);
            }
        }

        private void nd_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nd_btn_SaveUpdateDoctor_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nd_tb_doctorName.Text.Trim()))
            {
                DoctorModel doctor = new DoctorModel();
               
                doctor.name = nd_tb_doctorName.Text;
                doctor.email = nd_tb_doctorEmail.Text;
                doctor.contact = nd_tb_doctorContact.Text;
                doctor.gender = nd_cb_doctorGender.Text;
                doctor.address = nd_tb_doctorAddress.Text;
                if (nd_btn_browseDoctorPhoto.Image != null && currentDoctorImagePath != null)
                {
                    doctor.drImage = File.ReadAllBytes(currentDoctorImagePath);
                    doctor.drImagePath = currentDoctorImagePath;
                }
                if (!String.IsNullOrEmpty(nd_lbl_DoctorId.Text))
                    doctor.doctorId = Convert.ToInt32(nd_lbl_DoctorId.Text);
                CDoctor.AddUpdateDoctor(doctor);
                MessageBox.Show("Doctor Added Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter doctor name");
            }
        }

        private void LoadComponents()
        {
            nd_cb_doctorGender.DataSource = Enum.GetValues(typeof(HEnum.Gender));
        }
    }
}
