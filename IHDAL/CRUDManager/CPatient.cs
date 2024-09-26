using HDAL.Conn;
using HDAL.DBManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HDAL.CRUD
{
    public class CPatient
    {
        public static List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetAllPatients;
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    patient.patientId = Convert.ToInt32(sdr["patientId"]);
                    patient.name = Convert.ToString(sdr["name"]);
                    patient.contact = Convert.ToString(sdr["contact"]);
                    patient.address = Convert.ToString(sdr["address"]);
                    patient.email = Convert.ToString(sdr["email"]);
                    patient.gender = Convert.ToString(sdr["gender"]);
                    patient.doctorId = Convert.ToInt32(sdr["doctorId"]);
                    //patient.image = (byte[])sdr["photo"];
                    patients.Add(patient);
                }
                conn.Close();
            }
            //return the list of patients
            return patients;
        }

        //Add new patient
        public static bool AddUpdatePatient(Patient patient)
        {
            bool isUpdate = patient.patientId > 0 ? true : false;
            string sqlQuery = isUpdate ? SqlQueries.UpdatePatient : SqlQueries.AddPatient;
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlQuery;
                if (isUpdate)
                    cmd.Parameters.AddWithValue("@patientId", patient.patientId);
                cmd.Parameters.AddWithValue("@name", patient.name);
                cmd.Parameters.AddWithValue("address", patient.address);
                cmd.Parameters.AddWithValue("@contact", patient.contact);
                cmd.Parameters.AddWithValue("@email", patient.email);
                cmd.Parameters.AddWithValue("@gender", patient.gender);
                cmd.Parameters.AddWithValue("@doctorId", patient.doctorId);
                cmd.Parameters.AddWithValue("@photo", patient.image);
                cmd.Connection = conn;
                conn.Open();
                // Executing the SQL query  
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result == 1)
                    return true;
                else
                    return false;
            }

            return false;
        }

        //create a method to get a patient by id
        public static Patient GetPatientById(int patientId)
        {
            Patient patientDetails = new Patient();
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetPatientById;
                cmd.Parameters.AddWithValue("@patientId", patientId);
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    patientDetails.patientId = Convert.ToInt32(sdr["patientId"]);
                    patientDetails.name = Convert.ToString(sdr["name"]);
                    patientDetails.contact = Convert.ToString(sdr["contact"]);
                    patientDetails.address = Convert.ToString(sdr["address"]);
                    patientDetails.email = Convert.ToString(sdr["email"]);
                    patientDetails.gender = Convert.ToString(sdr["gender"]);
                    patientDetails.doctorId = Convert.ToInt32(sdr["doctorId"]);
                    if (sdr["photo"] != DBNull.Value)
                        patientDetails.image = (byte[])sdr["photo"];
                }
                conn.Close();
            }
            //return patient details
            return patientDetails;
        }
        
        public static DataTable GetFilteredPatients(Patient patient)
        {
            //bool isAllDoctors = patient.doctorId == 0 ? true : false;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(HKeys.connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SqlQueries.GetFilteredPatients, connection))
                {
                    command.Parameters.AddWithValue("@name", patient.name);
                    command.Parameters.AddWithValue("@doctorId", patient.doctorId);
                    command.Parameters.AddWithValue("@gender", patient.gender);
                    command.Parameters.AddWithValue("@email", patient.email);
                    command.Parameters.AddWithValue("@contact", patient.contact);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        //public static DataTable GetPatientNameAndId()
        //{            
        //    DataTable dataTable = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(HKeys.connString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(SqlQueries.GetPatientNameAndId, connection))
        //        {
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(dataTable);
        //            }
        //        }
        //    }
        //    return dataTable;
        //}

        public static List<Patient> GetPatientNameAndId()
        {
            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetPatientNameAndId;
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Patient patient = new Patient();
                    patient.patientId = Convert.ToInt32(sdr["patientId"]);
                    patient.name = Convert.ToString(sdr["name"]);
                    patients.Add(patient);
                }
                conn.Close();
            }
            //return the list of patients
            return patients;
        }

        public static bool DeletePatient(int patientId)
        {
            using (SqlConnection connection = new SqlConnection(HKeys.connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SqlQueries.DeletePatient, connection))
                {
                    command.Parameters.AddWithValue("@patientId", patientId);
                    int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                        return true;
                        
                        }
                        else
                        {
                        return false;
                        }
                }
            }            
        }
    }
}
