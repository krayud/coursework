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
    public partial class cars : Form
    {
        public cars()
        {
            InitializeComponent();
        }

        private void cars_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carriercompanyDataSet.transport". При необходимости она может быть перемещена или удалена.
            this.transportTableAdapter.Fill(this.carriercompanyDataSet.transport);

            this.reportViewer1.RefreshReport();
        }
    }
}
