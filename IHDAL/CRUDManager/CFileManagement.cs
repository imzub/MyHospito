using HDAL.DBManager;
using HDAL.Models;
using IHDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHDAL.CRUDManager
{
    public class CFileManagement
    {
        public static List<FileLocationModel> GetAllFileLocationData()
        {
            List<FileLocationModel> fileLocs = new List<FileLocationModel>();
            FileLocationModel flNew = new FileLocationModel() { flId = -1, FileName = "New" };
            FileLocationModel flNone = new FileLocationModel() { flId = 0, FileName = "None" };
            fileLocs.Add(flNew);
            fileLocs.Add(flNone);
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetAllFileLocation;
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    FileLocationModel fileLocation = new FileLocationModel();
                    fileLocation.flId = Convert.ToInt32(sdr["flId"]);
                    fileLocation.FileName = Convert.ToString(sdr["FileName"]);
                    fileLocation.PhysicalPath = Convert.ToString(sdr["PhysicalPath"]);
                    fileLocation.LastUpdated = Convert.ToDateTime(sdr["LastUpdated"]);
                    fileLocation.Description = Convert.ToString(sdr["Description"]);
                    fileLocs.Add(fileLocation);
                }
                conn.Close();
            }

            return fileLocs;
        }

        public static FileLocationModel GetFileLocationById(int flId)
        {
            FileLocationModel flDetails = new FileLocationModel();
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetFileLocationById;
                cmd.Parameters.AddWithValue("@flId", flId);
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    flDetails.flId = Convert.ToInt32(sdr["flId"]);
                    flDetails.FileName = Convert.ToString(sdr["FileName"]);
                    flDetails.PhysicalPath = Convert.ToString(sdr["PhysicalPath"]);
                    flDetails.LastUpdated = Convert.ToDateTime(sdr["LastUpdated"]);
                    flDetails.Description = Convert.ToString(sdr["Description"]);
                }
                conn.Close();
            }

            return flDetails;
        }

        public static bool DeleteFileLocation(int flId)
        {
            using (SqlConnection connection = new SqlConnection(HKeys.connString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(SqlQueries.DeleteFileLocation, connection))
                {
                    command.Parameters.AddWithValue("@flId", flId);
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

        public static bool AddUpdateFileLoaction(FileLocationModel fileLoc)
        {
            bool isUpdate = fileLoc.flId > 0 ? true : false;
            string sqlQuery = isUpdate ? SqlQueries.QueryUpdateFileLocation : SqlQueries.QueryAddNewFileLocation;
            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlQuery;
                if (isUpdate)
                    cmd.Parameters.AddWithValue("@flId", fileLoc.flId);
                cmd.Parameters.AddWithValue("@FileName", fileLoc.FileName);
                cmd.Parameters.AddWithValue("@PhysicalPath", fileLoc.PhysicalPath);
                cmd.Parameters.AddWithValue("@LastUpdated", fileLoc.LastUpdated);
                cmd.Parameters.AddWithValue("@Description", fileLoc.Description);                
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
    }
}
