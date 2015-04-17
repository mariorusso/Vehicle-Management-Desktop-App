namespace VehicleManagement
{
    partial class frmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDropLocation = new System.Windows.Forms.TextBox();
            this.lblDropLocation = new System.Windows.Forms.Label();
            this.txtPickUpLocation = new System.Windows.Forms.TextBox();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBookingRecord = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bookInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRecord)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.bookInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 572);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bookInfo
            // 
            this.bookInfo.Controls.Add(this.tableLayoutPanel2);
            this.bookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookInfo.Location = new System.Drawing.Point(3, 3);
            this.bookInfo.Name = "bookInfo";
            this.bookInfo.Size = new System.Drawing.Size(978, 108);
            this.bookInfo.TabIndex = 0;
            this.bookInfo.TabStop = false;
            this.bookInfo.Text = "Booking Info";
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
            this.tableLayoutPanel2.Controls.Add(this.txtPhoneNo, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTime, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTime, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDropLocation, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDropLocation, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPickUpLocation, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPickUp, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblClientName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtClientName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPhoneNo, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 89);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(747, 64);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(220, 20);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(425, 64);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(216, 20);
            this.txtTime.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTime.Location = new System.Drawing.Point(327, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 42);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txDate
            // 
            this.txDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txDate.Enabled = false;
            this.txDate.Location = new System.Drawing.Point(103, 64);
            this.txDate.Name = "txDate";
            this.txDate.Size = new System.Drawing.Size(216, 20);
            this.txDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(5, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 42);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtDropLocation
            // 
            this.txtDropLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDropLocation.Enabled = false;
            this.txtDropLocation.Location = new System.Drawing.Point(747, 20);
            this.txtDropLocation.Name = "txtDropLocation";
            this.txtDropLocation.Size = new System.Drawing.Size(220, 20);
            this.txtDropLocation.TabIndex = 5;
            // 
            // lblDropLocation
            // 
            this.lblDropLocation.AutoSize = true;
            this.lblDropLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDropLocation.Location = new System.Drawing.Point(649, 2);
            this.lblDropLocation.Name = "lblDropLocation";
            this.lblDropLocation.Size = new System.Drawing.Size(90, 41);
            this.lblDropLocation.TabIndex = 4;
            this.lblDropLocation.Text = "Drop Location";
            this.lblDropLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtPickUpLocation
            // 
            this.txtPickUpLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPickUpLocation.Enabled = false;
            this.txtPickUpLocation.Location = new System.Drawing.Point(425, 20);
            this.txtPickUpLocation.Name = "txtPickUpLocation";
            this.txtPickUpLocation.Size = new System.Drawing.Size(216, 20);
            this.txtPickUpLocation.TabIndex = 3;
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPickUp.Location = new System.Drawing.Point(327, 2);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(90, 41);
            this.lblPickUp.TabIndex = 2;
            this.lblPickUp.Text = "Pick Up Location";
            this.lblPickUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientName.Location = new System.Drawing.Point(5, 2);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(90, 41);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Client Name";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtClientName
            // 
            this.txtClientName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtClientName.Enabled = false;
            this.txtClientName.Location = new System.Drawing.Point(103, 20);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(216, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPhoneNo.Location = new System.Drawing.Point(649, 74);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(90, 13);
            this.lblPhoneNo.TabIndex = 10;
            this.lblPhoneNo.Text = "Phone #";
            this.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBookingRecord);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 452);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Records";
            // 
            // dgvBookingRecord
            // 
            this.dgvBookingRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingRecord.Location = new System.Drawing.Point(3, 16);
            this.dgvBookingRecord.Name = "dgvBookingRecord";
            this.dgvBookingRecord.Size = new System.Drawing.Size(972, 433);
            this.dgvBookingRecord.TabIndex = 0;
            this.dgvBookingRecord.SelectionChanged += new System.EventHandler(this.dgvBookingRecord_SelectionChanged);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBooking_FormClosing);
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBooking_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bookInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRecord)).EndInit();
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
        private System.Windows.Forms.GroupBox bookInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDropLocation;
        private System.Windows.Forms.Label lblDropLocation;
        private System.Windows.Forms.TextBox txtPickUpLocation;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvBookingRecord;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
    }
}