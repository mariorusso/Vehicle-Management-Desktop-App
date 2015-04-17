using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dataAccess;

namespace businessDrivers
{
    public class BusinessDrivers
    {
        public static DataSet dset = new DataSet();

        public void getDriverDtl()
        {
            string strQueryDrivers = "Select * from DriverDetail where isnull(is_deleted,0)<>1";
            if (dset.Tables.Contains("Drivers"))
            {
                dset.Tables["Drivers"].Clear();
            }
            dataAccess.DataAccessClass.mySelectQuery(dset, strQueryDrivers, "Drivers");
        }   

        public void saveDriverDtl()
        {
            string strSaveQuery = "Select * from DriverDetail where isnull(is_deleted,0)<>1";
            dataAccess.DataAccessClass.executeDataSet(dset, strSaveQuery, "Drivers");
        }

        public void deleteDrivers(string strID)
        {
            string strDeleteQuery = "UPDATE DriverDetail SET is_deleted=1 where drivers_id=" + strID;
            dataAccess.DataAccessClass.executeQuery(strDeleteQuery);
        }
    }
}
