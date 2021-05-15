using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3Lop
{
    class CSDL_OOP
    {
        public List<SV> LSV { get; set; }
        public List<LSH> LLSH { get; set; }

        private static CSDL_OOP _Instance;


        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private CSDL_OOP()
        {
        }

        public List<SV> GetAllSV()
        {
            List<SV> lsv = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                SV s = new SV
                {
                    MSSV = i["MSSV"].ToString(),
                    NameSV = i["NameSV"].ToString(),
                    Gender = Convert.ToBoolean(i["Gender"]),
                    IDLop = Convert.ToInt32(i["ID_Lop"]),
                    NS = Convert.ToDateTime(i["NS"])
                };
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

        public List<LSH> GetAllLSH()
        {
            List<LSH> llsh = new List<LSH>();
            DataTable dataa = CSDL.Instance.DTLSH;
            DataRowCollection dt = dataa.Rows;
            foreach (DataRow i in dt)
            {
                LSH s = new LSH
                {
                    ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                    NameLop = i["NameLop"].ToString()
                };
                llsh.Add(s);
            }
            return llsh;

        }
        public bool sosanhMSSV(string msss)
        {

            List<SV> li = new List<SV>();
            li = GetAllSV();
            foreach (SV i in li)
            {
                if (i.MSSV == msss) return false;
            }

            return true;
        }


        public SV getSVbyMSSV(string mss)
        {
            SV s = new SV();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                
                if (mss== i["MSSV"].ToString())
                {
                    s.MSSV = i["MSSV"].ToString();
                    s.NameSV = i["NameSV"].ToString();
                    s.Gender = Convert.ToBoolean(i["Gender"]);
                    s.IDLop = Convert.ToInt32(i["ID_Lop"]);
                    s.NS = Convert.ToDateTime(i["NS"]);
                    
                }                
            }return s;
        }

        public LSH GetLSH(DataRow i)
        {
            LSH s = new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"]),
                NameLop = i["NameLop"].ToString()
            };
            return s;
        }


        public List<SV> GetListSV(int ID_Lop, string Name)
        {
            List<SV> lsv = new List<SV>();
            DataTable dataa = CSDL.Instance.DTSV;
            DataRowCollection dt = dataa.Rows;
            foreach (DataRow i in dt)
            {
                if (ID_Lop == 0 && i["NameSV"].ToString().Contains(Name))
                {
                    lsv.Add(GetSV(i));
                }
                if (i["NameSV"].ToString().Contains(Name) && ID_Lop == Convert.ToInt32(i["ID_Lop"]))//
                { lsv.Add(GetSV(i)); }
            }
            return lsv;

            // i.NameSV.contains;
        }

        public void AddSVCSDL(SV s)
        {

            CSDL.Instance.AddSV(s);
        }
        public void DelSVSDL(string s)
        {
            CSDL.Instance.DelSV(s);
        }
        public void FixSVCSDL(SV s)
        {

            CSDL.Instance.FixSV(s);
        }


        public delegate bool CompareObj(SV o1, SV o2);
        public void Sort(List<SV> s, CompareObj cmp)
        {
            for (int i=0;i<s.Count - 1;i++)
                for(int j= s.Count - 1;j>i;j--)
                    if(cmp(s[i],s[j]))
                    {
                        SV a = s[i];
                        s[i] = s[j];
                        s[j] = a;
                    }    
        }


    }

}

