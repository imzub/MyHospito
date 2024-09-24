using HDAL.CRUD;
using HDAL.DBManager;
using HDAL.Models;
using IHDAL.DBManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHDAL.CRUDManager
{
    public class CVisitAppointment
    {
        public static DataTable GetFilteredPatientVisitList(PatientVisit patientVisit)
        {
            DataTable dataTable = new DataTable();
            if (patientVisit != null)
            {
                string patientVisitQuery = CustomQuery.PatientVisitQueryBuilder(patientVisit);
                if (!string.IsNullOrEmpty(patientVisitQuery))
                {
                    using (SqlConnection connection = new SqlConnection(HKeys.connString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(patientVisitQuery, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                            }
                        }
                    }
                }
            }
            return dataTable;
        }

        public static bool AddUpdatePatientVisit(Patient patient)
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
    }
}
