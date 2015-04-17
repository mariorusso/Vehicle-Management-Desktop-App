namespace VehicleManagement
{
    partial class frmVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicles));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vehicleInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblkms = new System.Windows.Forms.Label();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.vehicleRecords = new System.Windows.Forms.GroupBox();
            this.dgvVehicleRecord = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.vehicleInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.vehicleRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModify,
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
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(65, 22);
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vehicleInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.vehicleRecords, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 572);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // vehicleInfo
            // 
            this.vehicleInfo.Controls.Add(this.tableLayoutPanel2);
            this.vehicleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleInfo.Location = new System.Drawing.Point(3, 3);
            this.vehicleInfo.Name = "vehicleInfo";
            this.vehicleInfo.Size = new System.Drawing.Size(978, 165);
            this.vehicleInfo.TabIndex = 0;
            this.vehicleInfo.TabStop = false;
            this.vehicleInfo.Text = "Vehicle Info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23232F));
            this.tableLayoutPanel2.Controls.Add(this.lblColor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblModel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtModel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtColor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblYear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtYear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLicensePlate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLicensePlate, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblkms, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtKms, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 146);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Location = new System.Drawing.Point(5, 74);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(90, 70);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModel.Location = new System.Drawing.Point(5, 2);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(90, 70);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(103, 49);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(216, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(103, 121);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(216, 20);
            this.txtColor.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblYear.Location = new System.Drawing.Point(327, 59);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(90, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(425, 49);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(216, 20);
            this.txtYear.TabIndex = 5;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLicensePlate.Location = new System.Drawing.Point(649, 59);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(90, 13);
            this.lblLicensePlate.TabIndex = 6;
            this.lblLicensePlate.Text = "License Plate";
            this.lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLicensePlate.Enabled = false;
            this.txtLicensePlate.Location = new System.Drawing.Point(747, 49);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(220, 20);
            this.txtLicensePlate.TabIndex = 7;
            // 
            // lblkms
            // 
            this.lblkms.AutoSize = true;
            this.lblkms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblkms.Location = new System.Drawing.Point(327, 131);
            this.lblkms.Name = "lblkms";
            this.lblkms.Size = new System.Drawing.Size(90, 13);
            this.lblkms.TabIndex = 8;
            this.lblkms.Text = "Kms";
            this.lblkms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtKms
            // 
            this.txtKms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKms.Enabled = false;
            this.txtKms.Location = new System.Drawing.Point(425, 121);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(216, 20);
            this.txtKms.TabIndex = 9;
            // 
            // vehicleRecords
            // 
            this.vehicleRecords.Controls.Add(this.dgvVehicleRecord);
            this.vehicleRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleRecords.Location = new System.Drawing.Point(3, 174);
            this.vehicleRecords.Name = "vehicleRecords";
            this.vehicleRecords.Size = new System.Drawing.Size(978, 395);
            this.vehicleRecords.TabIndex = 1;
            this.vehicleRecords.TabStop = false;
            this.vehicleRecords.Text = "Vehicle Records";
            // 
            // dgvVehicleRecord
            // 
            this.dgvVehicleRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleRecord.Location = new System.Drawing.Point(3, 16);
            this.dgvVehicleRecord.Name = "dgvVehicleRecord";
            this.dgvVehicleRecord.Size = new System.Drawing.Size(972, 376);
            this.dgvVehicleRecord.TabIndex = 0;
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmVehicles";
            this.Text = "frmVehicles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVehicles_FormClosing);
            this.Load += new System.EventHandler(this.frmVehicles_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVehicles_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.vehicleInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.vehicleRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox vehicleInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblkms;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.GroupBox vehicleRecords;
        private System.Windows.Forms.DataGridView dgvVehicleRecord;
    }
}