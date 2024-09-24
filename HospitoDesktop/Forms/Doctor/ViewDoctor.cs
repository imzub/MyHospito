using HDAL.CRUD;
using HDAL.CRUDManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitoDesktop.Forms.Doctor
{
    public partial class ViewDoctor : Form
    {
        public ViewDoctor()
        {
            InitializeComponent();
        }

        private void vd_btn_search_Click(object sender, EventArgs e)
        {
            DoctorModel doctorObj = new DoctorModel();
            doctorObj.name = vd_tb_doctorName.Text.Trim();
            doctorObj.contact = vd_tb_doctorContact.Text.Trim();
            doctorObj.address = vd_tb_doctorAddress.Text.Trim();
            doctorObj.email = vd_tb_doctorEmail.Text.Trim();
            if (vd_cb_allGenders.Checked)
                doctorObj.gender = string.Empty;
            else
                doctorObj.gender = vd_cb_doctorGender.Text.Trim();

            vd_gv_doctorList.DataSource = null;
            vd_gv_doctorList.DataSource = CDoctor.GetFilteredDoctors(doctorObj);
        }

        
    }
}
