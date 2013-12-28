using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;

namespace carriercompany2.DALS
{
    class DriversDal
    {
        Dal dal = Dal.GetInstance();

        public ArrayList GetAllDrivers()
        {
            dal.SetQuery("SELECT * FROM drivers");
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetAllDriversByCarId(string carId)
        {
            string query = string.Format("SELECT drivers.name as [Имя] FROM drivers WHERE drivers.car_id = {0}", carId);
            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList DriversDistributionByCar()
        {
            dal.SetQuery("SELECT drivers.name as [Имя], transport.id as [ID транспорта] FROM drivers, transport WHERE drivers.car_id = transport.id");
            return dal.ExecuteQueryArrayList();
        }
    }
}
