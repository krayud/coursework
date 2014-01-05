using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace carriercompany2.DALS
{
    class StaffDal
    {
        Dal dal = Dal.GetInstance();

        public ArrayList GetAllBrigadesStaff()
        {
            dal.SetQuery(@"SELECT drivers.name as [Водитель], brigades.id as [Бригада], brigadiers.name as [Бригадир] FROM brigadiers, drivers, brigades
                            WHERE brigades.brigadier_id = brigadiers.id AND drivers.brigade_id = brigades.id");
            return dal.ExecuteQueryArrayList();
        }

        public ArrayList GetAllWorkshopStaff()
        {
            dal.SetQuery(@"SELECT  workers.name as [Рабочий], workshops.id as [Цех], workshops.name as [Название цеха], masters.name as [Мастер]
                            FROM masters, workshops, workers
                            WHERE masters.id = workshops.master_id AND workers.workshop_id = workshops.id
                            ORDER BY workshops.id");
            return dal.ExecuteQueryArrayList();
        }
        
      
    }
}
