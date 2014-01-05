using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunFile(string fileName){
            if (File.Exists(fileName))
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = fileName;
                proc.EnableRaisingEvents = true;
                proc.Start();
            }
            else
                MessageBox.Show("Программа " + fileName + " не найдена", "Ошибка");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunFile("reader.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RunFile("editor.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunFile("reporter.exe");
        }
    }
}
