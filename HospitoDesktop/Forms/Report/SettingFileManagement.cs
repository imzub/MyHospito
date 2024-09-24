using HDAL.CRUD;
using HDAL.CRUDManager;
using IHDAL.CRUDManager;
using IHDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
//using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitoDesktop.Forms.Report
{
    public partial class SettingFileManagement : Form
    {
        //public int flId = 0;
        public SettingFileManagement()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void sfm_btn_LocationBrowse_Click(object sender, EventArgs e)
        {
            // Create and configure the FolderBrowserDialog component
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select Location",
                ShowNewFolderButton = true,
            };

            // Show the FolderBrowserDialog and check if the user selected a folder
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Do something with the selected folder path (e.g., display it in a TextBox)
                sfm_tb_FileLocation.Text = selectedFolderPath;
            }
        }

        private void LoadComponents()
        {
            ClearComponents();

            //Bind Select File Combobox            
            sfm_cb_SelectForm.DisplayMember = "FileName";
            sfm_cb_SelectForm.ValueMember = "flId";
            sfm_cb_SelectForm.DataSource = CFileManagement.GetAllFileLocationData();
            sfm_cb_SelectForm.SelectedIndex = 1;

            ControlsPropertyChanger();
        }

        private void ClearComponents()
        {
            sfm_cb_SelectForm.DataSource = null;
            sfm_tb_FileName.Text = sfm_tb_FileLocation.Text = sfm_lbl__LastUpdated.Text = sfm_tb_Description.Text = sfm_lbl_FLID.Text = string.Empty;
        }

        private void sfm_btn_SaveUpdate_Click(object sender, EventArgs e)
        {
            bool isFLUpdateRequest = (Convert.ToInt32(sfm_lbl_FLID.Text.Trim()) > 0) ? true : false;
            string operation = isFLUpdateRequest ? " Updated " : " Added ";

            bool result = CFileManagement.AddUpdateFileLoaction(LoadFileLocationDetails());
            if (result)
            {
                MessageBox.Show("File Location" + operation + "Successfully.");
            }
            else
            {
                MessageBox.Show("File Location" + operation + "Failed!");
            }
            LoadComponents();
        }

        private void sfm_cb_SelectForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            int formId = Convert.ToInt32(sfm_cb_SelectForm.SelectedValue);
            if (formId > 0)
            {
                FileLocationModel flm = new FileLocationModel();
                flm = CFileManagement.GetFileLocationById(formId);
                sfm_lbl_FLID.Text = Convert.ToString(flm.flId);
                sfm_lbl__LastUpdated.Text = Convert.ToString(flm.LastUpdated);
                sfm_tb_FileName.Text = Convert.ToString(flm.FileName);
                sfm_tb_FileLocation.Text = Convert.ToString(flm.PhysicalPath);
                sfm_tb_Description.Text = Convert.ToString(flm.Description);
            }
            else
            {
                sfm_tb_FileName.Text = sfm_tb_FileLocation.Text = sfm_lbl__LastUpdated.Text = sfm_tb_Description.Text = sfm_lbl_FLID.Text = string.Empty;
                sfm_lbl_FLID.Text = Convert.ToString(formId);
            }
            ControlsPropertyChanger();
        }

        private void sfm_btn_Delete_Click(object sender, EventArgs e)
        {
            int flId = Convert.ToInt32(sfm_lbl_FLID.Text.Trim());
            if (flId > 0)
                DeleteFileLocation(flId, Convert.ToString(sfm_cb_SelectForm.Text));
        }

        private void DeleteFileLocation(int flId, string fileName)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete this File Location '{fileName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool deleteResult = CFileManagement.DeleteFileLocation(flId);
                if (deleteResult)
                {
                    // Deletion was successful
                    MessageBox.Show($"File Location '{fileName}' deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the DataGridView (refresh the data)
                    LoadComponents();
                }
                else
                {
                    // Deletion failed
                    MessageBox.Show("Failed to delete the file location.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sfm_btn_New_Click(object sender, EventArgs e)
        {
            sfm_tb_FileName.Text = sfm_tb_FileLocation.Text = sfm_lbl__LastUpdated.Text = sfm_tb_Description.Text = string.Empty;
            sfm_lbl_FLID.Text = Convert.ToString(-1);
            sfm_cb_SelectForm.SelectedIndex = 0;
        }

        private void ControlsPropertyChanger()
        {
            if (Convert.ToInt32(sfm_lbl_FLID.Text.Trim()) == -1) //Case : New
            {
                sfm_btn_New.Enabled = sfm_btn_Delete.Enabled = false;
                sfm_btn_SaveUpdate.Enabled = true;
                sfm_btn_SaveUpdate.Text = "Save";
            }
            else if (Convert.ToInt32(sfm_lbl_FLID.Text.Trim()) == 0) //Case : None
            {
                sfm_btn_Delete.Enabled = sfm_btn_SaveUpdate.Enabled = false;
                sfm_btn_New.Enabled = true;
                sfm_btn_SaveUpdate.Text = "Save";
            }
            else if (Convert.ToInt32(sfm_lbl_FLID.Text.Trim()) > 0) //Case : Selected File Location
            {
                sfm_btn_New.Enabled = sfm_btn_Delete.Enabled = sfm_btn_SaveUpdate.Enabled = true;
                sfm_btn_SaveUpdate.Text = "Update";
            }
        }

        private void sfm_btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private FileLocationModel LoadFileLocationDetails()
        {
            FileLocationModel flModel = new FileLocationModel();
            flModel.flId = Convert.ToInt32(sfm_lbl_FLID.Text.Trim());
            flModel.FileName = sfm_tb_FileName.Text.Trim();
            flModel.PhysicalPath = sfm_tb_FileLocation.Text.Trim();
            flModel.Description = sfm_tb_Description.Text.Trim();
            flModel.LastUpdated = DateTime.Now;
            return flModel;
        }
    }
}
