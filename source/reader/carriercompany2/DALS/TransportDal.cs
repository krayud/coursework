using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;

namespace carriercompany2.DALS
{
    class TransportDal
    {
        Dal dal = Dal.GetInstance();

        public ArrayList GetAllTypes()
        {
            dal.SetQuery("SELECT * FROM transport_types");
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetAllMarks()
        {
            dal.SetQuery("SELECT * FROM marks");
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList CountCarsByParams(int type, int mark)
        {
            string query = "";

            if (type > 0 && mark > 0)
                query = string.Format("SELECT COUNT(*), SUM(transport.price) FROM transport WHERE transport.type = {0} AND transport.mark = {1}", type, mark);
            else
            if (type > 0)
                query = string.Format("SELECT COUNT(*), SUM(transport.price) FROM transport WHERE transport.type = {0}", type);
            else
            if (mark > 0)
                query = string.Format("SELECT COUNT(*), SUM(transport.price) FROM transport WHERE transport.mark ={0}", mark);

            dal.SetQuery(query);

            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetAllTypesCount()
        {
            string query = @"SELECT transport_types.name as [Тип], COUNT(transport.id) as [Количество] FROM transport, transport_types 
                             WHERE transport.type = transport_types.id
                             GROUP BY transport_types.name";

            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetCarsByTypeOrMark(int type, int mark)
        {
            string query = @"SELECT transport.number as [Номер авто], transport_types.name as [Тип], marks.name as [Марка], transport.price as [Цена] 
                             FROM transport, transport_types, marks WHERE";

            if (type > 0 && mark > 0)
                query += string.Format(" transport.type = {0} AND transport.mark = {1}", type, mark);
            else
            if (type > 0)
                query += string.Format(" transport.type = {0}", type);
            else
            if (mark > 0)
                query += string.Format(" transport.mark = {0}", mark);

            query += @" AND transport.type = transport_types.id AND transport.mark = marks.id";

            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetTraffic(int type, string carId, int year, int month, int day)
        {
            string query = @"SELECT transport.number as [Номер авто], traffic.distance_km as [Пробег км.], traffic.date as [Дата] 
                             FROM  transport, traffic 
                             WHERE traffic.transport_id = transport.id";

            if(type > 0)
                query += string.Format(" AND transport.type = {0}", type); 
            else
                query += string.Format(" AND transport.number = '{0}'", carId);

            if (year != 0)
                query += string.Format(" AND YEAR(traffic.date) = {0}", year);

            if (month != 0)
                query += string.Format(" AND MONTH(traffic.date) = {0}", month);

            if (day != 0)
                query += string.Format(" AND DAY(traffic.date) = {0}", day);


            dal.SetQuery(query);
            return dal.ExecuteQueryArrayList();
        }
    }
}
