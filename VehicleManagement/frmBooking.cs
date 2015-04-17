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
    public partial class frmBooking : Form
    {
        string stringOperation = "";
        businessBooking.BusinessBooking bBookingObj = new businessBooking.BusinessBooking();        
        public frmBooking()
        {
            InitializeComponent();
        }

        private void bGrid()
        {
            try
            {
                bBookingObj.getBookingDtl();
                dgvBookingRecord.DataSource = null;
                dgvBookingRecord.DataSource = businessBooking.BusinessBooking.dset;
                dgvBookingRecord.DataMember = "Bookings";
                fGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fGrid()
        {
            dgvBookingRecord.Columns["booking_id"].Visible = false;
            dgvBookingRecord.Columns["create_at"].Visible = false;
            dgvBookingRecord.Columns["modified_at"].Visible = false;
            dgvBookingRecord.Columns["is_deleted"].Visible = false;

            dgvBookingRecord.Columns["client_name"].HeaderText = "Client Name";
            dgvBookingRecord.Columns["pick_up_loc"].HeaderText = "Pick up Location";
            dgvBookingRecord.Columns["drop_of_loc"].HeaderText = "Drop of Location";
            dgvBookingRecord.Columns["phone_no"].HeaderText = "Phone No";
            dgvBookingRecord.Columns["booking_time"].HeaderText = "Time";
            dgvBookingRecord.Columns["booking_date"].HeaderText = "Date";

            dgvBookingRecord.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBookingRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBookingRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void clearFields()
        {
            txtClientName.Clear();
            txtDropLocation.Clear();
            txtPhoneNo.Clear();
            txtPickUpLocation.Clear();
            txtDropLocation.Clear();
            txtTime.Clear();
            txDate.Clear();
        }

        private void enableDisable()
        {
            btnNew.Enabled = !(btnNew.Enabled);
            btnModify.Enabled = !(btnModify.Enabled);
            btnDelete.Enabled = !(btnDelete.Enabled);
            btnClose.Enabled = !(btnClose.Enabled);
            btnSave.Visible = !(btnSave.Visible);
            btnCancel.Visible = !(btnCancel.Visible);

            txtClientName.Enabled = !(txtClientName.Enabled);
            txtDropLocation.Enabled = !(txtDropLocation.Enabled);
            txtPickUpLocation.Enabled = !(txtPickUpLocation.Enabled);
            txtPhoneNo.Enabled = !(txtPhoneNo.Enabled);
            txDate.Enabled = !(txDate.Enabled);
            txtTime.Enabled = !(txtTime.Enabled);
        }

        private bool valFields()
        {
            if (txtClientName.Text == "")
            {
                MessageBox.Show("Please provide Client Name", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtClientName.Focus();
                return false;
            }
            if (txtDropLocation.Text == "")
            {
                MessageBox.Show("Please provide the Drop of Location", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtDropLocation.Focus();
                return false;
            }
            if (txtPickUpLocation.Text == "")
            {
                MessageBox.Show("Please provide the Pick Up of Location", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtPickUpLocation.Focus();
                return false;
            }
            if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please provide the Client's Phone Number", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtPhoneNo.Focus();
                return false;
            }
            if (txDate.Text == "")
            {
                MessageBox.Show("Please provide the Date", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txDate.Focus();
                return false;
            }
            if (txtTime.Text == "")
            {
                MessageBox.Show("Please provide the Time", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtTime.Focus();
                return false;
            }

            return true;
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            bGrid();
            dgvBookingRecord.AllowUserToAddRows = false;
            dgvBookingRecord.ReadOnly = true;
        }

        private void dgvBookingRecord_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookingRecord.RowCount > 0 && stringOperation != "New")
            {
                txtClientName.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["client_name"].ToString();
                txtPickUpLocation.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["pick_up_loc"].ToString();
                txtDropLocation.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["drop_of_loc"].ToString();
                txDate.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["booking_date"].ToString();
                txtTime.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["booking_time"].ToString();
                txtPhoneNo.Text = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["phone_no"].ToString();
            }
        }

        private void frmBooking_FormClosing(object sender, FormClosingEventArgs e)
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
            dgvBookingRecord.Rows.GetLastRow(DataGridViewElementStates.Selected);
            dgvBookingRecord.AllowUserToAddRows = true;
            dgvBookingRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
            enableDisable();
            clearFields();
            txtClientName.Focus();
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
                            DataRow dRow = businessBooking.BusinessBooking.dset.Tables["Bookings"].NewRow();
                            dRow["client_name"] = txtClientName.Text;
                            dRow["pick_up_loc"] = txtPickUpLocation.Text;
                            dRow["phone_no"] = txtPhoneNo.Text;
                            dRow["drop_of_loc"] = txtDropLocation.Text;
                            dRow["booking_time"] = txtTime.Text;
                            dRow["booking_date"] = txDate.Text;
                            dRow["create_at"] = DateTime.Now.Date;
                            dRow["modified_at"] = DateTime.Now.Date;
                            businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows.Add(dRow);
                            bBookingObj.saveBookingDtl();
                            businessBooking.BusinessBooking.dset.Tables["Bookings"].AcceptChanges();
                        }
                        else if (stringOperation == "Modify")
                        {
                            DataRow[] dRow = businessBooking.BusinessBooking.dset.Tables["Bookings"].Select("booking_id=" + businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["booking_id"].ToString());

                            dRow[0]["client_name"] = txtClientName.Text;
                            dRow[0]["pick_up_loc"] = txtPickUpLocation.Text;
                            dRow[0]["phone_no"] = txtPhoneNo.Text;
                            dRow[0]["drop_of_loc"] = txtDropLocation.Text;
                            dRow[0]["booking_time"] = txtTime.Text;
                            dRow[0]["booking_date"] = txDate.Text;
                            dRow[0]["create_at"] = DateTime.Now.Date;
                            dRow[0]["modified_at"] = DateTime.Now.Date;
                            bBookingObj.saveBookingDtl();
                            businessBooking.BusinessBooking.dset.Tables["Bookings"].AcceptChanges();
                        }
                    }

                    dgvBookingRecord.AllowUserToAddRows = false;
                    dgvBookingRecord.ReadOnly = true;

                    enableDisable();
                    dgvBookingRecord.Focus();
                    stringOperation = "";
                    bGrid();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvBookingRecord.EditMode = DataGridViewEditMode.EditProgrammatically;
            enableDisable();
            txtClientName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            stringOperation = "Modify";

            try
            {
                if (dgvBookingRecord.Rows.Count<1)
                {
                    MessageBox.Show("No Record to Modify", "Vehicle Management Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                businessBooking.BusinessBooking.dset.Tables["Bookings"].RejectChanges();
                enableDisable();
                dgvBookingRecord.AllowUserToAddRows = false;
                dgvBookingRecord.ReadOnly = true;
                clearFields();
                stringOperation = "";
                dgvBookingRecord.CurrentCell = dgvBookingRecord.Rows[0].Cells[1];
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
                if (dgvBookingRecord.Rows.Count > 0)
                {
                    string bookingID = businessBooking.BusinessBooking.dset.Tables["Bookings"].Rows[dgvBookingRecord.CurrentCell.RowIndex]["booking_id"].ToString();
                    bBookingObj.deleteBookings(bookingID);
                    businessBooking.BusinessBooking.dset.Tables["Bookings"].AcceptChanges();
                    stringOperation = "";
                    dgvBookingRecord.Focus();
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

        private void frmBooking_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
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
