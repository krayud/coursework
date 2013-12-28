using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using carriercompany2.DALS;
using System.Collections;
using System.Windows.Forms;

namespace carriercompany2.BLLS
{
    class DriversBll
    {
        DriversDal driversDal = new DriversDal();
        SelectionsForm form;

        public DriversBll(SelectionsForm formLink) { form = formLink; }

        //Показать общее число водителей
        public void AllShowBtnClick()
        {
            ArrayList allDriversList = new ArrayList();

            if (form.allDrivers.Checked)
            {
                allDriversList = driversDal.GetAllDrivers();
                form.driversDGV1.DataSource = allDriversList;
            }
            else if (form.byCarId1.Checked)
            {
                string carId = form.driversCarId1.Text;

                int carIdInt;
                bool checkInt = int.TryParse(carId, out carIdInt);

                if (checkInt == false || carIdInt <= 0)
                    MessageBox.Show("ID транспорта должен быть больше 0");
                else
                {
                    allDriversList = driversDal.GetAllDriversByCarId(carId);
                    form.driversDGV1.DataSource = allDriversList;
                }
            }
            form.driversCountLabel.Text = Convert.ToString(allDriversList.Count);
        }

        //Смена параметра выборки водителей
        public void SelectionParamChange()
        {
            if (form.byCarId1.Checked)
                form.driversCarId1.Enabled = true;
            else
                form.driversCarId1.Enabled = false;
        }

        //Показать распределение водителей по авто
        public void DistributionShowClick()
        {
            form.distributionDGV.DataSource = driversDal.DriversDistributionByCar();
        }
    }
}
