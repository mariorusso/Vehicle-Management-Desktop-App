using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dataAccess;

namespace businessVehicles
{
    public class BusinessVehicles
    {
        public static DataSet dset = new DataSet();

        public void getVehicleDtl()
        {
            string strQueryVehicle = "Select * from VehicleDetail where isnull(is_deleted,0)<>1";
            if (dset.Tables.Contains("Vehicles"))
            {
                dset.Tables["Vehicles"].Clear();
            }
            dataAccess.DataAccessClass.mySelectQuery(dset, strQueryVehicle, "Vehicles");
        }

        public void saveVehicleDtl()
        {
            string strSaveQuery = "Select * from VehicleDetail where isnull(is_deleted,0)<>1";
            dataAccess.DataAccessClass.executeDataSet(dset, strSaveQuery, "Vehicles");
        }

        public void deleteVehicles(string strID)
        {
            string strDeleteQuery = "UPDATE VehicleDetail SET is_deleted=1 where vehicle_id=" + strID;
            dataAccess.DataAccessClass.executeQuery(strDeleteQuery);
        }
    }
}
