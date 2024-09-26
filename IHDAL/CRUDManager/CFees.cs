using HDAL.DBManager;
using HDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHDAL.CRUDManager
{
    public class CFees
    {
        public static List<FeesModel> GetFees()
        {
            List<FeesModel> feesList= new List<FeesModel>();

            using (SqlConnection conn = new SqlConnection(HKeys.connString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlQueries.GetFees;
                cmd.Connection = conn;
                conn.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    FeesModel fees = new FeesModel();
                    fees.feesId = Convert.ToInt32(sdr["feesId"]);
                    fees.fees = Convert.ToInt32(sdr["fees"]);
                    fees.feesName = Convert.ToString(sdr["feesName"]);
                    feesList.Add(fees);
                }
                conn.Close();
            }
            
            return feesList;
        }
    }
}
