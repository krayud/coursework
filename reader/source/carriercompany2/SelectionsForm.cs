using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using carriercompany2.DALS;
using System.Collections;
using carriercompany2.BLLS;
using System.Xml.Linq;

namespace carriercompany2
{
    public partial class SelectionsForm : Form
    {

        //Подключаемые bll 
        DriversBll driversBll;
        TransportBll transBll;
        TruckingBll truckingBll;
        StaffBll staffBll;

        //Инициализация bll
        private void BllsInit()
        {
            driversBll = new DriversBll(this);
            transBll = new TransportBll(this);
            truckingBll = new TruckingBll(this);
            staffBll = new StaffBll(this);
        }
        
        public SelectionsForm()
        {
            InitializeComponent();
            BllsInit();
        }
        

        private void refreshDrivers1_Click(object sender, EventArgs e)
        {
            driversBll.AllShowBtnClick();
        }

        private void byCarId1_CheckedChanged(object sender, EventArgs e)
        {
            driversBll.SelectionParamChange();
        }

        private void distributionShow_Click(object sender, EventArgs e)
        {
            driversBll.DistributionShowClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void transportCountBytype1_CheckedChanged(object sender, EventArgs e)
        {
            transBll.ChangeSelectParam();
        }

        private void transportCountBymark1_CheckedChanged(object sender, EventArgs e)
        {
            transBll.ChangeSelectParam();
        }

        private void transportShowCountPrice_Click(object sender, EventArgs e)
        {
            transBll.ShowCountPrice();
        }

        private void transportTypeCountBtn_Click(object sender, EventArgs e)
        {
            transBll.ShowTypeCount();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            transBll.TrafficTypeChange();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            transBll.TrafficTypeChange();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            transBll.TrafficFirstOpen();
        }

        private void transportTrafficShowBtn_Click(object sender, EventArgs e)
        {
            transBll.ShowTraffic();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (trafficMonthCheck.Checked)
                transportTrafficMonth.Enabled = true;
            else
                transportTrafficMonth.Enabled = false;
        }

        private void trafficDayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (trafficDayCheck.Checked)
                transportTrafficDay.Enabled = true;
            else
                transportTrafficDay.Enabled = false;
        }

        private void trafficYearCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (trafficYearCheck.Checked)
                transportTrafficYear.Enabled = true;
            else
                transportTrafficYear.Enabled = false;
        }

        private void truckingShowBtn_Click(object sender, EventArgs e)
        {
            truckingBll.ShowTrucking();

        }

        private void staffBrigadesShowBtn_Click(object sender, EventArgs e)
        {
            staffBll.ShowBrigades();
        }

        private void workshopStaffShowBtn_Click(object sender, EventArgs e)
        {
            staffBll.ShowWorkshopStaff();
        }

        private void SelectionsForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
