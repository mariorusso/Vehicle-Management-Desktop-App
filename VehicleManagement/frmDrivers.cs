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
    public partial class frmDrivers : Form
    {
        string stringOperation = "";
        businessDrivers.BusinessDrivers bDriversObj = new businessDrivers.BusinessDrivers();
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void bGrid()
        {
            try
            {
                bDriversObj.getDriverDtl();
                dgvDriversRecord.DataSource = null;
                dgvDriversRecord.DataSource = businessDrivers.BusinessDrivers.dset;
                dgvDriversRecord.DataMember = "Drivers";
                fGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void fGrid()
        {
            dgvDriversRecord.Columns["drivers_id"].Visible = false;
            dgvDriversRecord.Columns["create_at"].Visible = false;
            dgvDriversRecord.Columns["modified_at"].Visible = false;
            dgvDriversRecord.Columns["is_deleted"].Visible = false;

            dgvDriversRecord.Columns["first_name"].HeaderText = "First Name";
            dgvDriversRecord.Columns["last_name"].HeaderText = "Last Name";
            dgvDriversRecord.Columns["phone_no"].HeaderText = "Phone No";
            dgvDriversRecord.Columns["address"].HeaderText = "Address";
            dgvDriversRecord.Columns["license_no"].HeaderText = "License No";
            dgvDriversRecord.Columns["expire_date"].HeaderText = "Expire Date";

            dgvDriversRecord.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDriversRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDriversRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void clearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtAddress.Clear();
            txtLicenseNo.Clear();
            txtExpire.Clear();            
        }

        private void enableDisable()
        {
            btnNew.Enabled = !(btnNew.Enabled);
            btnModifiy.Enabled = !(btnModifiy.Enabled);
            btnDelete.Enabled = !(btnDelete.Enabled);
            btnClose.Enabled = !(btnClose.Enabled);
            btnSave.Visible = !(btnSave.Visible);
            btnCancel.Visible = !(btnCancel.Visible);

            txtFirstName.Enabled = !(txtFirstName.Enabled);
            txtLastName.Enabled = !(txtLastName.Enabled);
            txtPhoneNo.Enabled = !(txtPhoneNo.Enabled);
            txtAddress.Enabled = !(txtAddress.Enabled);
            txtLicenseNo.Enabled = !(txtLicenseNo.Enabled);
            txtExpire.Enabled = !(txtExpire.Enabled);

            dgvDriversRecord.Enabled = !(dgvDriversRecord.Enabled);
        }
        private bool valFields()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please provide First Name", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtFirstName.Focus();
                return false;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please provide Last Name", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtLastName.Focus();
                return false;
            }

            if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please provide Phone Number", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtPhoneNo.Focus();
                return false;
            }

            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please provide an Address", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtAddress.Focus();
                return false;
            }

            if (txtLicenseNo.Text == "")
            {
                MessageBox.Show("Please provide the License Number", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtLicenseNo.Focus();
                return false;
            }

            if (txtExpire.Text == "")
            {
                MessageBox.Show("Please provide the Expire Date", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtExpire.Focus();
                return false;
            }

            return true;
        }
        
        private void frmDrivers_Load(object sender, EventArgs e)
        {
            bGrid();
            dgvDriversRecord.AllowUserToAddRows = false;
            dgvDriversRecord.ReadOnly = true; 
        }

        private void dgvDriversRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDriversRecord.RowCount > 0 && stringOperation != "New")
            {
                txtFirstName.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["first_name"].ToString();
                txtLastName.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["last_name"].ToString();
                txtPhoneNo.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["phone_no"].ToString();
                txtAddress.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["address"].ToString();
                txtLicenseNo.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["license_no"].ToString();
                txtExpire.Text = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["expire_date"].ToString();
                
            }
        }

        private void frmDrivers_FormClosing(object sender, FormClosingEventArgs e)
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
            dgvDriversRecord.Rows.GetLastRow(DataGridViewElementStates.Selected);
            dgvDriversRecord.AllowUserToAddRows = true;
            dgvDriversRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
            enableDisable();
            clearFields();
            txtFirstName.Focus();
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
                            DataRow dRow = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].NewRow();
                            dRow["first_name"] = txtFirstName.Text;
                            dRow["last_name"] = txtLastName.Text;
                            dRow["phone_no"] = txtPhoneNo.Text;
                            dRow["address"] = txtAddress.Text;
                            dRow["license_no"] = txtLicenseNo.Text;
                            dRow["expire_date"] = txtExpire.Text;
                            dRow["create_at"] = DateTime.Now.Date;
                            dRow["modified_at"] = DateTime.Now.Date;
                            businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows.Add(dRow);
                            bDriversObj.saveDriverDtl();
                            businessDrivers.BusinessDrivers.dset.Tables["Drivers"].AcceptChanges();
                        }
                        else if (stringOperation == "Modify")
                        {
                            DataRow[] dRow = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Select("drivers_id=" + businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["drivers_id"].ToString());
                            
                            dRow[0]["first_name"] = txtFirstName.Text;
                            dRow[0]["last_name"] = txtLastName.Text;
                            dRow[0]["phone_no"] = txtPhoneNo.Text;
                            dRow[0]["address"] = txtAddress.Text;
                            dRow[0]["license_no"] = txtLicenseNo.Text;
                            dRow[0]["expire_date"] = txtExpire.Text; 
                            dRow[0]["create_at"] = DateTime.Now.Date;
                            dRow[0]["modified_at"] = DateTime.Now.Date;
                            bDriversObj.saveDriverDtl();
                            businessDrivers.BusinessDrivers.dset.Tables["Drivers"].AcceptChanges();
                        }
                    }

                    dgvDriversRecord.AllowUserToAddRows = false;
                    dgvDriversRecord.ReadOnly = true;

                    enableDisable();
                    dgvDriversRecord.Focus();
                    stringOperation = "";
                    bGrid();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifiy_Click(object sender, EventArgs e)
        {
            stringOperation = "Modify";

            try
            {
                if (dgvDriversRecord.Rows.Count<1)
                {
                    MessageBox.Show("No Record to Modify", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvDriversRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
                enableDisable();
                txtFirstName.Focus();
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
                businessDrivers.BusinessDrivers.dset.Tables["Drivers"].RejectChanges();
                enableDisable();
                dgvDriversRecord.AllowUserToAddRows = false;
                dgvDriversRecord.ReadOnly = true;
                clearFields();
                stringOperation = "";
                dgvDriversRecord.CurrentCell = dgvDriversRecord.Rows[0].Cells[1];
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
                if (dgvDriversRecord.Rows.Count > 0)
                {
                    string driverId = businessDrivers.BusinessDrivers.dset.Tables["Drivers"].Rows[dgvDriversRecord.CurrentCell.RowIndex]["drivers_id"].ToString();
                    bDriversObj.deleteDrivers(driverId);
                    businessDrivers.BusinessDrivers.dset.Tables["Drivers"].AcceptChanges();
                    stringOperation = "";
                    dgvDriversRecord.Focus();
                    bGrid();
                }
                else
                {
                    MessageBox.Show("There are no records to be deleted", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmDrivers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode==Keys.N)
                {
                    if (btnNew.Enabled)
                    {
                        btnNew_Click(null, null);
                    }
                    
                }
                

                if (e.KeyCode == Keys.M)
                {
                    if (btnModifiy.Enabled)
                    {
                        btnModifiy_Click(null, null);
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
