using DAL.CRUD;
using DAL.Models;
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


namespace MsfWinForm
{
    public partial class PatientForm : Form
    {
        public string connString = @"Data Source=(local)\SQLEXPRESS; Initial Catalog=Mishifadb; Integrated Security=True;";
        public PatientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //conn.Open();
                //SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Patient", conn);
                //DataTable dt = new DataTable();
                //sqlDa.Fill(dt);
                //dataGridView2.DataSource = sqlDa;

                //SqlDataAdapter da = new SqlDataAdapter("Select * from Patient", conn);
                //DataSet ds = new DataSet();
                //da.Fill(ds, "Patient");
                //dataGridView2.DataSource = ds.Tables["Patient"].DefaultView;


                List<Patient> patients = new List<Patient>();
                patients = CPatient.GetAllPatients();
                dataGridView2.DataSource = patients;
                conn.Close();   

            }

        }


    }
}
