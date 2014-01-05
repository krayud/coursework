using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Xml.Linq;

namespace carriercompany2.DALS
{
    sealed class Dal
    {
      
        private static Dal instance = null;
        private string connectionString = "";
        private string query = "";

        private Dal()
        {
            try
            {
                XDocument xDocument = XDocument.Load("settings.xml");
                connectionString = xDocument.Element("appsettings").Element("server").Attribute("connectionString").Value;
            }
            catch{
                MessageBox.Show("Не удалось открыть файл настроек");
            }
        }

        public static Dal GetInstance() 
        {
            if (instance == null)
                instance = new Dal();
            return instance;
        }

        public void SetQuery(string query)
        {
            this.query = query;
        }

        public ArrayList ExecuteQueryArrayList()
        {
            ArrayList resultList = new ArrayList();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();

            if (dr.HasRows)
                foreach (DbDataRecord result in dr)
                    resultList.Add(result);

            con.Dispose();

            return resultList;
        }
            
    }
}
