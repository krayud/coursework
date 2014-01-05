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
            dal.SetQuery(@"SELECT drivers.name as [Имя], transport.number as [Номер авто] 
                            FROM drivers
	                            JOIN transport ON transport.id = drivers.car_id");
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetAllDriversByCarNumber(string carNumber)
        {
            string query = string.Format("SELECT drivers.name as [Имя] FROM drivers, transport WHERE drivers.car_id = transport.id AND transport.number = '{0}'", carNumber);
            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList DriversDistributionByCar()
        {
            dal.SetQuery(@"SELECT drivers.name as [Имя], transport.number as [Номер авто] 
                            FROM drivers
	                            JOIN transport ON transport.id = drivers.car_id");
            return dal.ExecuteQueryArrayList();
        }
    }
}
