using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace carriercompany2.DALS
{
    class TruckingDal
    {
        Dal dal = Dal.GetInstance();


        public ArrayList GetTrucks(int carId, DateTime DateFrom, DateTime DateTo)
        {
            string query = string.Format(@"SELECT * FROM truckings WHERE truckings.car_id = {0} AND truckings.date BETWEEN '{1}' AND '{2}'",carId, DateFrom.ToShortDateString(), DateTo.ToShortDateString());
            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }
        
    }
}
