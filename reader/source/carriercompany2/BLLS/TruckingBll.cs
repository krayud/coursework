using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using carriercompany2.DALS;
using System.Windows.Forms;
using System.Collections;

namespace carriercompany2.BLLS
{
    class TruckingBll
    {
        TruckingDal truckingDal = new TruckingDal();
        SelectionsForm form;

        public TruckingBll(SelectionsForm formLink) { form = formLink; }

        public void ShowTrucking()
        {
            DateTime DateFrom = form.truckingDateFrom.Value;
            DateTime DateTo = form.truckingDateTo.Value;
            string carId = form.truckingCarId.Text;

            if (carId != "")
            {
                ArrayList truckings = truckingDal.GetTrucks(carId, DateFrom, DateTo);

                if (truckings.Count <= 0)
                    MessageBox.Show("Записей не найдено");
                else
                    form.truckingDGV.DataSource = truckings; 
            }
            else
                MessageBox.Show("Некорректный номер транспорта");
        }

    }
}
