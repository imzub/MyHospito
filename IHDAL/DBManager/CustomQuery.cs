using HDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHDAL.DBManager
{
    public class CustomQuery
    {


        public static string PatientVisitQueryBuilder(PatientVisit patientVisit)
        {
            string query = string.Empty;
            string baseQuery, conditionalQuery = string.Empty;
            if (patientVisit != null)
            {
                baseQuery = "select * from PatientVisit";
                //bool isAndAdded = false;
                conditionalQuery += " concerns LIKE '%" + patientVisit.concerns + "%'";
                conditionalQuery += " AND symptoms LIKE '%" + patientVisit.symptoms + "%'";
                if (patientVisit.patientId > 0)
                    conditionalQuery += " AND patientId=" + patientVisit.patientId;
                if (patientVisit.doctorId > 0)
                    conditionalQuery += " AND doctorId=" + patientVisit.doctorId;
                if (patientVisit.feesId > 0)
                    conditionalQuery += " AND feesId=" + patientVisit.feesId;
                if (patientVisit.paidFees > 0)
                    conditionalQuery += " AND paidFees=" + patientVisit.paidFees;

                if (!string.IsNullOrEmpty(conditionalQuery))
                    query = baseQuery + " WHERE " + conditionalQuery;
                else
                    query = baseQuery;
            }
            return query;
        }
    }
}
