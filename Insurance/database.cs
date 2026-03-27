using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Insurance
{
    internal class database
    {
      
            private SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-9PRCD27\SQLEXPRESS;Initial Catalog=Starahovaya;Integrated Security=True");
            public SqlConnection connect()
            {
                return cn;
            }

            public void open()
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
            }

            public void close()
            {
                if (cn.State == System.Data.ConnectionState.Open)
                    cn.Close();
            }
        }
}
