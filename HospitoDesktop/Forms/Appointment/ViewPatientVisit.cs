using HDAL.CRUD;
using HDAL.CRUDManager;
using HDAL.DBManager;
using HDAL.Models;
using IHDAL.CRUDManager;
using IHDAL.DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using OfficeOpenXml;

namespace HospitoDesktop.Forms.Appointment
{
    public partial class ViewPatientVisit : Form
    {
        public ViewPatientVisit()
        {
            InitializeComponent();
            LoadComponents();            
        }

        private void vpv_btn_search_Click(object sender, EventArgs e)
        {
            LoadComponents();
            //ExportPdfPatientVisit();
            //ExportXlsPatientVisit();
        }

        private PatientVisit GetFilterControlData()
        {
            PatientVisit pv = new PatientVisit();
            pv.patientId = vpv_chb_AllPatient.Checked ? -1 : Convert.ToInt32(vpv_cb_selectPatient.SelectedValue);
            pv.concerns = vpv_tb_patientConcerns.Text.Trim();
            pv.symptoms = vpv_tb_patientSymptoms.Text.Trim();
            pv.paidFees = Convert.ToInt32(vpv_tb_paidFees.Text.Trim());
            pv.feesId = vpv_chb_AllFees.Checked ? -1 : Convert.ToInt32(vpv_cb_selectFees.SelectedValue);
            pv.doctorId = vpv_chb_allDoctors.Checked ? -1 : Convert.ToInt32(vpv_cb_assignedDoctor.SelectedValue);
            pv.gender = vpv_chb_allGenders.Checked ? "None" : vpv_cb_patientGender.SelectedText;

            return pv;
        }

        private void LoadComponents()
        {
            //Bind Fees Control
            if (string.IsNullOrEmpty(vpv_tb_paidFees.Text.Trim()))
                vpv_tb_paidFees.Text = "0";

            //Bind Patient List
            vpv_cb_selectPatient.DisplayMember = "name";
            vpv_cb_selectPatient.ValueMember = "patientId";
            vpv_cb_selectPatient.DataSource = CPatient.GetPatientNameAndId();

            //Bind Gender List
            vpv_cb_patientGender.DataSource = Enum.GetValues(typeof(HEnum.Gender));

            //Bind Doctor List
            vpv_cb_assignedDoctor.DisplayMember = "name";
            vpv_cb_assignedDoctor.ValueMember = "doctorId";
            vpv_cb_assignedDoctor.DataSource = CDoctor.GetDoctorNameAndID();

            //Bind Fees List
            vpv_cb_selectFees.DisplayMember = "feesName";
            vpv_cb_selectFees.ValueMember = "feesId";
            vpv_cb_selectFees.DataSource = CFees.GetFees();

            //Bind GridView Data
            vpv_gv_patientVisitList.DataSource = null;
            DataTable data = CVisitAppointment.GetFilteredPatientVisitList(GetFilterControlData());
            vpv_gv_patientVisitList.DataSource = data;
        }

        public void ExportPdfPatientVisit()
        {
            // Create a document
            Document doc = new Document();

            // Set the file path for the PDF
            string filePath = "PatientVisit.pdf";

            // Create a PdfWriter to write the document to the file
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Open the document for writing
            doc.Open();
            DataTable data = CVisitAppointment.GetFilteredPatientVisitList(GetFilterControlData());
            // Create a table with as many columns as your DataTable
            PdfPTable table = new PdfPTable(data.Columns.Count);

            // Add column headers to the table
            foreach (DataColumn column in data.Columns)
            {
                table.AddCell(new Phrase(column.ColumnName));
            }

            // Add data rows to the table
            foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    table.AddCell(item.ToString());
                }
            }

            // Add the table to the document
            doc.Add(table);

            // Close the document
            doc.Close();
        }

        public void ExportXlsPatientVisit()
        {
            // Set the license context to NonCommercial to avoid the licensing exception
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Add a new worksheet to the Excel package
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Replace this with your DataTable
                DataTable dataTable = CVisitAppointment.GetFilteredPatientVisitList(GetFilterControlData());

                // Fill the Excel worksheet with data from the DataTable
                int numRows = dataTable.Rows.Count;
                int numCols = dataTable.Columns.Count;

                for (int row = 1; row <= numRows; row++)
                {
                    for (int col = 1; col <= numCols; col++)
                    {
                        worksheet.Cells[row, col].Value = dataTable.Rows[row - 1][col - 1];
                    }
                }

                // Save the Excel package to a file
                string filePath = "datatable_data.xlsx";
                var fileInfo = new System.IO.FileInfo(filePath);
                package.SaveAs(fileInfo);

               MessageBox.Show($"Excel file created at: {fileInfo.FullName}");
            }
        }
    }
}
