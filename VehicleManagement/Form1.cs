using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace VehicleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ConfigurationManager.AppSettings["sysName"].ToString();
            toolStripStatusLabel1.Text = "Today's date is: " + DateTime.Now.ToString(); ;
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            frmDrivers driversObj = new frmDrivers();
            driversObj.MdiParent = this;

            driversObj.Show();
            
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            frmVehicles vehiclesObj = new frmVehicles();
            vehiclesObj.MdiParent = this;
            vehiclesObj.Show(); 
            
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookingObj = new frmBooking();
            bookingObj.MdiParent = this;
            bookingObj.Show();
        }
    }
}
