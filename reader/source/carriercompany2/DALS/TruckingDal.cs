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


        public ArrayList GetTrucks(string carId, DateTime DateFrom, DateTime DateTo)
        {
            string query = string.Format(@"SELECT transport.number as [Номер авто], truckings.cargo as [Груз], truckings.date as [Дата]
                                            FROM truckings, transport
                                            WHERE truckings.car_id = transport.id AND transport.number = '{0}'
                                            AND truckings.date BETWEEN '{1}' AND '{2}'", carId, DateFrom.ToShortDateString(), DateTo.ToShortDateString());
            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }
        
    }
}
