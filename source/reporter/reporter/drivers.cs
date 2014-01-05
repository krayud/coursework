using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporter
{
    public partial class drivers : Form
    {
        public drivers()
        {
            InitializeComponent();
        }

        private void drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carriercompanyDataSet.drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.carriercompanyDataSet.drivers);

            this.reportViewer1.RefreshReport();
        }
    }
}
