using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT03_102190100_NguyenDoVuong.DTO;
using BT03_102190100_NguyenDoVuong.BLL;
using System.Data;
using System.Windows.Forms;

namespace BT03_102190100_NguyenDoVuong.DAL
{
    class DAL_QLSV
    {
        private static DAL_QLSV _Instance;


        public static DAL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {

                    _Instance = new DAL_QLSV();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        private DAL_QLSV() { }

        public List<LSH> GetAllLSH_DAL()
        {
            List<LSH> listt = new List<LSH>();
            string query = "select * from LopSH";
            foreach(DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                listt.Add(GetLSH(i));
            }
            return listt;
        }
        
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString(),
            };
        }


        public List<SV> GetAllSV_DAL()
        {
            List<SV> lsv = new List<SV>();
            string query = "select * from SV";
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                SV s = GetSV(i);               
                lsv.Add(s);
            }
            return lsv;
        }
        public SV GetSV(DataRow i)
        {
            SV s = new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"]),
                IDLop = Convert.ToInt32(i["ID_Lop"]),
                NS = Convert.ToDateTime(i["NS"])
            };
            return s;
        }


        public void AddSV_DAL(SV s) 
        {
            try
            {
               
                
                string querry = "INSERT INTO SV VALUES('" + s.MSSV + "', N'" + s.NameSV + "', " + Convert.ToInt32(s.Gender) + ", N'" + s.NS + "', " + s.IDLop + ")";
                DBHelper.Instance.ExecuteDB(querry); 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        public void EditSV_DAL(SV s)
        {
            try
            {
                string querry = "UPDATE SV SET SV.NameSV = N'" + s.NameSV + "', SV.Gender = " + Convert.ToInt32(s.Gender) + ", SV.NS = N'" + s.NS + "', SV.ID_Lop = " + s.IDLop + " WHERE SV.MSSV = '" + s.MSSV + "'";
                DBHelper.Instance.ExecuteDB(querry);
            }
            catch (Exception)
            {

            }
            
            
        }

        public void DelSV_DAL(string mssv)
        {
            try
            {
                string querry = "DELETE FROM SV WHERE SV.MSSV = '" + mssv + "'";
                DBHelper.Instance.ExecuteDB(querry);
            }
            catch (Exception)
            {

            }
            
        }
    }
}
