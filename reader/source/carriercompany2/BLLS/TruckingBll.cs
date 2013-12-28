using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using carriercompany2.DALS;
using System.Windows.Forms;

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
            int carId = 0;

            if (int.TryParse(form.truckingCarId.Text, out carId) && carId > 0)
                form.truckingDGV.DataSource = truckingDal.GetTrucks(carId, DateFrom, DateTo);
            else
                MessageBox.Show("Некорректный ID транспорта");
        }

    }
}
