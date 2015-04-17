using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagement
{
    public partial class frmVehicles : Form
    {
        string stringOperation = "";

        businessVehicles.BusinessVehicles bVehicleObj = new businessVehicles.BusinessVehicles();
        public frmVehicles()
        {
            InitializeComponent();
        }

        private void bGrid()
        {
            try
            {
                bVehicleObj.getVehicleDtl();
                dgvVehicleRecord.DataSource = null;
                dgvVehicleRecord.DataSource = businessVehicles.BusinessVehicles.dset;
                dgvVehicleRecord.DataMember = "Vehicles";
                fGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fGrid()
        {
            dgvVehicleRecord.Columns["vehicle_id"].Visible = false;
            dgvVehicleRecord.Columns["create_at"].Visible = false;
            dgvVehicleRecord.Columns["modified_at"].Visible = false;
            dgvVehicleRecord.Columns["is_deleted"].Visible = false;

            dgvVehicleRecord.Columns["model"].HeaderText = "Model";
            dgvVehicleRecord.Columns["car_year"].HeaderText = "Year";
            dgvVehicleRecord.Columns["license_plate"].HeaderText = "License Plate";
            dgvVehicleRecord.Columns["color"].HeaderText = "Color";
            dgvVehicleRecord.Columns["kilometers"].HeaderText = "Kilometers";
            
            dgvVehicleRecord.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvVehicleRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVehicleRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void frmVehicles_Load(object sender, EventArgs e)
        {
            bGrid();
            dgvVehicleRecord.AllowUserToAddRows = false;
            dgvVehicleRecord.ReadOnly = true;
           
        }

        private void clearFields()
        {
            txtModel.Clear();
            txtYear.Clear();
            txtLicensePlate.Clear();
            txtColor.Clear();
            txtKms.Clear();
        }

        private void enableDisable()
        {
            btnNew.Enabled = !(btnNew.Enabled);
            btnModify.Enabled = !(btnModify.Enabled);
            btnDelete.Enabled = !(btnDelete.Enabled);
            btnClose.Enabled = !(btnClose.Enabled);
            btnSave.Visible = !(btnSave.Visible);
            btnCancel.Visible = !(btnCancel.Visible);

            txtModel.Enabled = !(txtModel.Enabled);
            txtYear.Enabled = !(txtYear.Enabled);
            txtLicensePlate.Enabled = !(txtLicensePlate.Enabled);
            txtColor.Enabled = !(txtColor.Enabled);
            txtKms.Enabled = !(txtKms.Enabled);
           
            dgvVehicleRecord.Enabled = !(dgvVehicleRecord.Enabled);
        }

        private bool valFields()
        {
            if (txtModel.Text == "")
            {
                MessageBox.Show("Please provide a Vehicle Model", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtModel.Focus();
                return false;
            }

            if (txtYear.Text == "")
            {
                MessageBox.Show("Please provide the Vehicle Year", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtYear.Focus();
                return false;
            }

            if (txtLicensePlate.Text == "")
            {
                MessageBox.Show("Please provide the License Plate Number", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtLicensePlate.Focus();
                return false;
            }

            if (txtColor.Text == "")
            {
                MessageBox.Show("Please provide the Vehicle Color", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtColor.Focus();
                return false;
            }

            if (txtKms.Text == "")
            {
                MessageBox.Show("Please provide the Vehicle Kilometers", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtKms.Focus();
                return false;
            }

            return true;
        }

        private void dgvVehicleRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicleRecord.RowCount > 0 && stringOperation != "New")
            {
                txtModel.Text = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["model"].ToString();
                txtYear.Text = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["car_year"].ToString();
                txtLicensePlate.Text = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["license_plate"].ToString();
                txtColor.Text = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["color"].ToString();
                txtKms.Text = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["kilometers"].ToString();
            }
        }

        private void frmVehicles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to close this form?", "Vehicle Management Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            stringOperation = "New";
            dgvVehicleRecord.Rows.GetLastRow(DataGridViewElementStates.Selected);
            dgvVehicleRecord.AllowUserToAddRows = true;
            dgvVehicleRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
            enableDisable();
            clearFields();
            txtModel.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            stringOperation = "Modify";

            try
            {
                if (dgvVehicleRecord.Rows.Count < 1)
                {
                    MessageBox.Show("No Record to Modify", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvVehicleRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
                enableDisable();
                txtModel.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (valFields())
                {
                    if (stringOperation == "New" || stringOperation == "Modify")
                    {

                        if (stringOperation == "New")
                        {
                            DataRow dRow = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].NewRow();
                            dRow["model"] = txtModel.Text;
                            dRow["car_year"] = txtYear.Text;
                            dRow["license_plate"] = txtLicensePlate.Text;
                            dRow["color"] = txtColor.Text;
                            dRow["kilometers"] = txtKms.Text;
                            dRow["create_at"] = DateTime.Now.Date;
                            dRow["modified_at"] = DateTime.Now.Date;
                            businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows.Add(dRow);
                            bVehicleObj.saveVehicleDtl();
                            businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].AcceptChanges();
                        }
                        else if (stringOperation == "Modify")
                        {
                            DataRow[] dRow = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Select("vehicle_id=" + businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["vehicle_id"].ToString());

                            dRow[0]["model"] = txtModel.Text;
                            dRow[0]["car_year"] = txtYear.Text;
                            dRow[0]["license_plate"] = txtLicensePlate.Text;
                            dRow[0]["color"] = txtColor.Text;
                            dRow[0]["kilometers"] = txtKms.Text;
                            dRow[0]["create_at"] = DateTime.Now.Date;
                            dRow[0]["modified_at"] = DateTime.Now.Date;
                            bVehicleObj.saveVehicleDtl();
                            businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].AcceptChanges();
                        }
                    }

                    dgvVehicleRecord.AllowUserToAddRows = false;
                    dgvVehicleRecord.ReadOnly = true;

                    enableDisable();
                    dgvVehicleRecord.Focus();
                    stringOperation = "";
                    bGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].RejectChanges();
                enableDisable();
                dgvVehicleRecord.AllowUserToAddRows = false;
                dgvVehicleRecord.ReadOnly = true;
                clearFields();
                stringOperation = "";
                dgvVehicleRecord.CurrentCell = dgvVehicleRecord.Rows[0].Cells[1];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehicleRecord.Rows.Count > 0)
                {
                    string vehicleId = businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].Rows[dgvVehicleRecord.CurrentCell.RowIndex]["vehicle_id"].ToString();
                    bVehicleObj.deleteVehicles(vehicleId);
                    businessVehicles.BusinessVehicles.dset.Tables["Vehicles"].AcceptChanges();
                    stringOperation = "";
                    dgvVehicleRecord.Focus();
                    bGrid();
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVehicles_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.N)
                {
                    if (btnNew.Enabled)
                    {
                        btnNew_Click(null, null);
                    }

                }


                if (e.KeyCode == Keys.M)
                {
                    if (btnModify.Enabled)
                    {
                        btnModify_Click(null, null);
                    }

                }

                if (e.KeyCode == Keys.D)
                {
                    if (btnDelete.Enabled)
                    {
                        btnDelete_Click(null, null);
                    }

                }

                if (e.KeyCode == Keys.S)
                {
                    if (btnSave.Enabled)
                    {
                        btnSave_Click(null, null);
                    }

                }

                if (e.KeyCode == Keys.E)
                {
                    if (btnCancel.Enabled)
                    {
                        btnCancel_Click(null, null);
                    }

                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (btnClose.Enabled)
                {
                    btnClose_Click(null, null);
                }

            }
        }

      
    }
}
