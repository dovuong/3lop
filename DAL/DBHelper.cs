using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BT03_102190100_NguyenDoVuong.DAL
{
    class DBHelper
    {
        SqlConnection cnn;

        private static DBHelper _Instance;


        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Dotnet;Integrated Security=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {                    
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
           // DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
           
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            
            return dt;
        }
    }
}
