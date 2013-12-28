using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using carriercompany2.DALS;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;

namespace carriercompany2.BLLS
{
    class TransportBll
    {
        TransportDal transDal = new TransportDal();
        SelectionsForm form;

        private bool firstCheckType = true;
        private bool firstCheckMark = true;
        private bool TrafficRadioTypeFirstCheck = true;

        public TransportBll(SelectionsForm formLink) { form = formLink; }

        public void LoadTransportTypes()
        {
            form.transportTypeBox1.DataSource = transDal.GetAllTypes();
        }

        public void LoadTransportMarks()
        {
            form.transportMarkBox1.DataSource = transDal.GetAllMarks();
        }

        public void ChangeSelectParam() 
        {
            if (form.transportCountBytype1.Checked)
            {
                if (firstCheckType)
                {
                    LoadTransportTypes();
                    firstCheckType = false;
                }
                
                form.transportTypeBox1.Enabled = true;
            }
            else
                form.transportTypeBox1.Enabled = false;

            if (form.transportCountBymark1.Checked)
            {
                if (firstCheckMark)
                {
                    LoadTransportMarks();
                    firstCheckMark = false;
                }
          
                form.transportMarkBox1.Enabled = true;
            }
            else
                form.transportMarkBox1.Enabled = false;
        }

        public void ShowCountPrice()
        {
            int type = 0;
            int mark = 0;

            if (form.transportCountBytype1.Checked)
                type = Convert.ToInt32(form.transportTypeBox1.SelectedValue);

            if (form.transportCountBymark1.Checked)
                mark = Convert.ToInt32(form.transportMarkBox1.SelectedValue);

            if (type == 0 && mark == 0)
            {
                MessageBox.Show("Выберите минимум один параметр для поиска");
            }
            else
            {
                ArrayList al = transDal.CountCarsByParams(type, mark);
                ArrayList carsList = transDal.GetCarsByTypeOrMark(type, mark);

                string carCountStr = "0";
                string carTotalPrice = "0";
                foreach (DbDataRecord record in al)
                {
                    carCountStr = record.GetValue(0).ToString();
                    carTotalPrice = record.GetValue(1).ToString();
                }

                form.transportCountPriceDGV.DataSource = carsList;

                form.transportCountLabel.Text = carCountStr;
                form.transportPriceLabel.Text = (carTotalPrice == "") ? "0" : carTotalPrice;
            }
        }

        public void ShowTypeCount()
        {
            form.transportTypeCountDGV.DataSource = transDal.GetAllTypesCount();
        }

        public void TrafficFirstOpen()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            int day = DateTime.Today.Day;

            for (int y = year; y >= 2000 ; y--)
                form.transportTrafficYear.Items.Add(y.ToString());
            form.transportTrafficYear.SelectedText = year.ToString();

            for (int m = 1; m <= 12; m++)
                form.transportTrafficMonth.Items.Add(m.ToString());
            form.transportTrafficMonth.SelectedText = month.ToString();

            for (int d = 1; d <= 31; d++)
                form.transportTrafficDay.Items.Add(d.ToString());
            form.transportTrafficDay.SelectedText = day.ToString();
        }

        public void TrafficTypeChange() 
        {
            if (form.transportTrafficRadioType.Checked)
            {
                if (TrafficRadioTypeFirstCheck)
                {
                    form.transportTrafficType.DataSource = transDal.GetAllTypes();
                    TrafficRadioTypeFirstCheck = false;
                }
                form.transportTrafficType.Enabled = true;
            }
            else
                form.transportTrafficType.Enabled = false;

            if (form.transportTrafficRadioId.Checked)
                form.transportTrafficCarId.Enabled = true;
            else
                form.transportTrafficCarId.Enabled = false;
        }

        public void ShowTraffic()
        {
            int type = 0;
            int carId = 0;
            int month = (form.trafficMonthCheck.Checked) ? Convert.ToInt32(form.transportTrafficMonth.Text) : 0;
            int day = (form.trafficDayCheck.Checked) ? Convert.ToInt32(form.transportTrafficDay.Text): 0;
            int year = (form.trafficYearCheck.Checked) ? Convert.ToInt32(form.transportTrafficYear.Text): 0;

            if (form.transportTrafficRadioType.Checked)
                type = Convert.ToInt32(form.transportTrafficType.SelectedValue);
            else
                if (form.transportTrafficRadioId.Checked)
                {

                    if (!int.TryParse(form.transportTrafficCarId.Text, out carId) || carId <= 0)
                    {
                        MessageBox.Show("Некорректный ID транспорта");
                        return;
                    }
                }

            if ((month == 0 && day == 0 && year == 0) || (type == 0 && carId == 0))
                MessageBox.Show("Некорректные параметры поиска");
            else
                form.transportTrafficDGV.DataSource = transDal.GetTraffic(type, carId, year, month, day);

        }
    }
}
