using HDAL.DBManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.CRUDManager
{
    public class CDoctor
    {
        public static List<DoctorModel> GetAllDoctors()
        {
            List<DoctorModel> doctors = new List<DoctorModel>();
            
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetAllDoctors;
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    DoctorModel doctor = new DoctorModel();
                    doctor.doctorId = Convert.ToInt32(sdr["doctorId"]);
                    doctor.name = Convert.ToString(sdr["name"]);
                    doctor.contact = Convert.ToString(sdr["contact"]);
                    doctor.address = Convert.ToString(sdr["address"]);
                    doctor.email = Convert.ToString(sdr["email"]);
                    doctor.gender = Convert.ToString(sdr["gender"]);                    
                    doctors.Add(doctor);
                }
                conn.Close();
            }
            //return the list of doctor
            return doctors;
        }

        public static List<DoctorModel> GetDoctorNameAndID()
        {
            List<DoctorModel> allDoctors = GetAllDoctors();
            List<DoctorModel> docNameIdList = new List<DoctorModel>();
            if (allDoctors.Count > 0)            { 
                
                foreach (DoctorModel doctor in allDoctors)
                {
                    DoctorModel doc = new DoctorModel();
                    doc.doctorId = doctor.doctorId;
                    doc.name = doctor.name;
                    docNameIdList.Add(doc);
                }
            }
            return docNameIdList;            
        }

        //Add new doctor
        public static bool AddUpdateDoctor(DoctorModel doctor)
        {
            bool isUpdate = doctor.doctorId > 0 ? true : false;
            string sqlQuery = isUpdate ? SqlQueries.UpdateDoctor : SqlQueries.AddDoctor;
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlQuery;
                if (isUpdate)
                    cmd.Parameters.AddWithValue("@doctorId", doctor.doctorId);
                cmd.Parameters.AddWithValue("@name", doctor.name);
                cmd.Parameters.AddWithValue("address", doctor.address);
                cmd.Parameters.AddWithValue("@contact", doctor.contact);
                cmd.Parameters.AddWithValue("@email", doctor.email);
                cmd.Parameters.AddWithValue("@gender", doctor.gender);
                //cmd.Parameters.AddWithValue("@photo", doctor.drImage);
                cmd.Connection = conn;
                conn.Open();
                // Executing the SQL query  
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    return true;
                conn.Close();
            }

            return false;
        }

        //public static List<DoctorModel> GetAllDoctors(DoctorModel doctor)
        //{
        //    List<DoctorModel> searchedDoctors = GetAllDoctors();
        //    return searchedDoctors;
        //}

        public static DataTable GetFilteredDoctors(DoctorModel doctor)
        {            
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(HKeys.connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SqlQueries.Sp_GetFilteredDoctors, connection))
                {
                    command.Parameters.AddWithValue("@name", doctor.name);
                    command.Parameters.AddWithValue("@contact", doctor.contact);
                    command.Parameters.AddWithValue("@address", doctor.address);
                    command.Parameters.AddWithValue("@email", doctor.email);
                    command.Parameters.AddWithValue("@gender", doctor.gender);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
