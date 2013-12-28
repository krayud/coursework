using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using carriercompany2.DALS;

namespace carriercompany2.BLLS
{
    class StaffBll
    {
        StaffDal staffDal = new StaffDal();
        SelectionsForm form;

        public StaffBll(SelectionsForm formLink) { form = formLink; }

        public void ShowBrigades() 
        {
          form.staffBrigadesDGV.DataSource = staffDal.GetAllBrigadesStaff();
        }

        public void ShowWorkshopStaff()
        {
            form.workshopStaffDGV.DataSource = staffDal.GetAllWorkshopStaff();
        }
    }
}
