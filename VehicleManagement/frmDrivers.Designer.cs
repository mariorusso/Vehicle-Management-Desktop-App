namespace VehicleManagement
{
    partial class frmDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModifiy = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tblDrivers = new System.Windows.Forms.TableLayoutPanel();
            this.grpDriversInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.lblLicenseNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtExpire = new System.Windows.Forms.TextBox();
            this.grpDriversRecords = new System.Windows.Forms.GroupBox();
            this.dgvDriversRecord = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tblDrivers.SuspendLayout();
            this.grpDriversInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpDriversRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModifiy,
            this.btnDelete,
            this.btnClose,
            this.btnSave,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModifiy
            // 
            this.btnModifiy.Image = ((System.Drawing.Image)(resources.GetObject("btnModifiy.Image")));
            this.btnModifiy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifiy.Name = "btnModifiy";
            this.btnModifiy.Size = new System.Drawing.Size(68, 22);
            this.btnModifiy.Text = "Modifiy";
            this.btnModifiy.Click += new System.EventHandler(this.btnModifiy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblDrivers
            // 
            this.tblDrivers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblDrivers.ColumnCount = 1;
            this.tblDrivers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDrivers.Controls.Add(this.grpDriversInfo, 0, 0);
            this.tblDrivers.Controls.Add(this.grpDriversRecords, 0, 1);
            this.tblDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDrivers.Location = new System.Drawing.Point(0, 25);
            this.tblDrivers.Name = "tblDrivers";
            this.tblDrivers.RowCount = 2;
            this.tblDrivers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblDrivers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblDrivers.Size = new System.Drawing.Size(984, 572);
            this.tblDrivers.TabIndex = 1;
            // 
            // grpDriversInfo
            // 
            this.grpDriversInfo.Controls.Add(this.tableLayoutPanel1);
            this.grpDriversInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDriversInfo.Location = new System.Drawing.Point(5, 5);
            this.grpDriversInfo.Name = "grpDriversInfo";
            this.grpDriversInfo.Size = new System.Drawing.Size(974, 163);
            this.grpDriversInfo.TabIndex = 0;
            this.grpDriversInfo.TabStop = false;
            this.grpDriversInfo.Text = "Drivers Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel1.Controls.Add(this.lblExpireDate, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLicenseNo, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLicenseNo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName);
            this.tableLayoutPanel1.Controls.Add(this.txtExpire, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 144);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpireDate.Location = new System.Drawing.Point(647, 73);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblExpireDate.Size = new System.Drawing.Size(90, 69);
            this.lblExpireDate.TabIndex = 10;
            this.lblExpireDate.Text = "Expire Date";
            this.lblExpireDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLicenseNo.Enabled = false;
            this.txtLicenseNo.Location = new System.Drawing.Point(424, 119);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(215, 20);
            this.txtLicenseNo.TabIndex = 9;
            // 
            // lblLicenseNo
            // 
            this.lblLicenseNo.AutoSize = true;
            this.lblLicenseNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLicenseNo.Location = new System.Drawing.Point(326, 73);
            this.lblLicenseNo.Name = "lblLicenseNo";
            this.lblLicenseNo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLicenseNo.Size = new System.Drawing.Size(90, 69);
            this.lblLicenseNo.TabIndex = 8;
            this.lblLicenseNo.Text = "License #";
            this.lblLicenseNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(103, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(5, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblAddress.Size = new System.Drawing.Size(90, 69);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(745, 48);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(218, 20);
            this.txtPhoneNo.TabIndex = 5;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneNo.Location = new System.Drawing.Point(647, 2);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPhoneNo.Size = new System.Drawing.Size(90, 69);
            this.lblPhoneNo.TabIndex = 4;
            this.lblPhoneNo.Text = "Phone No";
            this.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(424, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(215, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(326, 2);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLastName.Size = new System.Drawing.Size(90, 69);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name ";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblFirstName.Location = new System.Drawing.Point(5, 2);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFirstName.Size = new System.Drawing.Size(90, 69);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name ";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(103, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(215, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtExpire
            // 
            this.txtExpire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtExpire.Enabled = false;
            this.txtExpire.Location = new System.Drawing.Point(745, 119);
            this.txtExpire.Name = "txtExpire";
            this.txtExpire.Size = new System.Drawing.Size(218, 20);
            this.txtExpire.TabIndex = 11;
            // 
            // grpDriversRecords
            // 
            this.grpDriversRecords.Controls.Add(this.dgvDriversRecord);
            this.grpDriversRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDriversRecords.Location = new System.Drawing.Point(5, 176);
            this.grpDriversRecords.Name = "grpDriversRecords";
            this.grpDriversRecords.Size = new System.Drawing.Size(974, 391);
            this.grpDriversRecords.TabIndex = 1;
            this.grpDriversRecords.TabStop = false;
            this.grpDriversRecords.Text = "Drivers Records";
            // 
            // dgvDriversRecord
            // 
            this.dgvDriversRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriversRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDriversRecord.Location = new System.Drawing.Point(3, 16);
            this.dgvDriversRecord.Name = "dgvDriversRecord";
            this.dgvDriversRecord.Size = new System.Drawing.Size(968, 372);
            this.dgvDriversRecord.TabIndex = 0;
            this.dgvDriversRecord.SelectionChanged += new System.EventHandler(this.dgvDriversRecord_SelectionChanged);
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 597);
            this.Controls.Add(this.tblDrivers);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmDrivers";
            this.Text = "DriversForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrivers_FormClosing);
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDrivers_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tblDrivers.ResumeLayout(false);
            this.grpDriversInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpDriversRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnModifiy;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblDrivers;
        private System.Windows.Forms.GroupBox grpDriversInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpDriversRecords;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dgvDriversRecord;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.Label lblLicenseNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtExpire;
    }
}