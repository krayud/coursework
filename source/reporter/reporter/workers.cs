﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporter
{
    public partial class workers : Form
    {
        public workers()
        {
            InitializeComponent();
        }

        private void workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "carriercompanyDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.carriercompanyDataSet.workers);

            this.reportViewer1.RefreshReport();
        }
    }
}