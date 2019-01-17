using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLCT
{
    class KetNoi
    {
        private SqlConnection sqlConn;
        public KetNoi()
        {
            string strconn = @"Data Source=DESKTOP-HOF4G47\MSSQLSERVER66;Initial Catalog=QLTT;Integrated Security=True";
            sqlConn = new SqlConnection(strconn);
        }

        // lay ra 1 databass 1 bang cau lenh 
        public DataTable GetTable(string strCmd)//===============================
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(strCmd, sqlConn);
                sqlConn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter();
                sqlDa.SelectCommand = sqlCmd;
                DataSet ds = new DataSet();
                sqlDa.Fill(ds);
                DataTable dt = ds.Tables[0];
                sqlConn.Close();
                return dt;

            }
            catch
            {
                MessageBox.Show("KHONG THE KET NOI DUOC");
                Application.Exit();
                return null;
            }
        }

        //thuc thi mot cua lenh truy van
        public SqlCommand RunCommand(string strCmd)//================================
        {
            SqlCommand sqlCmd = new SqlCommand(strCmd, sqlConn);
            sqlConn.Open();
             sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
            return sqlCmd;
        }
    }
}
