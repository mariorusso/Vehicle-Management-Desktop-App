using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dataAccess;

namespace businessBooking
{
    
    public class BusinessBooking
    {
        public static DataSet dset = new DataSet();

        public void getBookingDtl()
        {
            string strQueryBooking = "Select * from BookingDetail where isnull(is_deleted,0)<>1";
            if (dset.Tables.Contains("Bookings"))
            {
                dset.Tables["Bookings"].Clear();
            }
            dataAccess.DataAccessClass.mySelectQuery(dset, strQueryBooking, "Bookings");
        }

        public void saveBookingDtl()
        {
            string strSaveQuery = "Select * from BookingDetail where isnull(is_deleted,0)<>1";
            dataAccess.DataAccessClass.executeDataSet(dset, strSaveQuery, "Bookings");
        }

        public void deleteBookings(string strID)
        {
            string strDeleteQuery = "UPDATE BookingDetail SET is_deleted=1 where booking_id=" + strID;
            dataAccess.DataAccessClass.executeQuery(strDeleteQuery);
        }
    }
}
