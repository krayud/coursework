using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace carriercompany2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void selects_form_btn_Click(object sender, EventArgs e)
        {
            SelectionsForm selectionsform = new SelectionsForm();
            selectionsform.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
