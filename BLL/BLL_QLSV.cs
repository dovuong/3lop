using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT03_102190100_NguyenDoVuong.DTO;
using BT03_102190100_NguyenDoVuong.DAL;

namespace BT03_102190100_NguyenDoVuong.BLL
{
    class BLL_QLSV
    {
        private static BLL_QLSV _Instance;


        public static BLL_QLSV Instance
        {
            get
            {
                if (_Instance == null)
                {

                    _Instance = new BLL_QLSV();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        private BLL_QLSV() { }


        public List<SV> GetAllSV_BLL()
        {
            return DAL_QLSV.Instance.GetAllSV_DAL();
        }

        //public List<SV> GetListSV_BLL(int id)
        //{
        //    return DAL_QLSV.Instance.GetListSV_DAL(id);
        //}


        public List<LSH> GetAllLSH_BLL()
        {
            return DAL_QLSV.Instance.GetAllLSH_DAL();
        }

        public void AddSV_BLL(SV s)
        {

            DAL_QLSV.Instance.AddSV_DAL(s);
        }

        public void EditSV_BLL(SV s)
        {
            DAL_QLSV.Instance.EditSV_DAL(s);
        }

        public void DelSV_BLL(string mssv)
        {
            List<SV> li = DAL_QLSV.Instance.GetAllSV_DAL();
            //if (li.Count > 1)
                DAL_QLSV.Instance.DelSV_DAL(mssv);
        }


        public void ExecuteDB_BLL(SV s)
        {
            if (sosanhMSSV(s.MSSV))
            {
                  EditSV_BLL(s);          
            }
            else                 
            { AddSV_BLL(s);    
                           
            }
        }


        //public List<string> GetColumnName_BLL()
        //{
        //    return DAL_QLSV.Instance.GetColumnName_DAL();
        //}


        public delegate bool CompareObj(SV_View sv1, SV_View sv2);
        public void SortSV_BLL(List<SV_View> li, CompareObj cmp)
        {
            for (int i = 0; i <= li.Count - 1; i++)
            {
                for (int j = li.Count - 1; j >= i; j--)
                {
                    if (cmp(li[i], li[j]))
                    {
                        SV_View a = li[i];
                        li[i] = li[j];
                        li[j] = a;
                    }
                }
            }
        }

        public List<SV> GetListSV(int ID_Lop, string Name)
        {
            List<SV> listSV = new List<SV>();
            foreach (SV i in GetAllSV_BLL())
            {
                if (Name == null)
                {
                    if (i.IDLop == ID_Lop)
                    {
                        listSV.Add(i);
                    }
                }
                else
                {
                    if (i.NameSV.Contains(Name))
                    {
                        listSV.Add(i);
                    }
                }
            }
            return listSV;
        }
        public List<SV_View> GetListSV_View(int ID_Lop, string Name)
        {
            List<SV_View> listSV = new List<SV_View>();
            foreach (SV i in GetAllSV_BLL())
            {
                
                if (Name == null)
                {
                    if (i.IDLop == ID_Lop)
                    {
                        listSV.Add(new SV_View
                        {
                            MSSV = i.MSSV,
                            NameSV = i.NameSV,
                            Gender = i.Gender,
                            NameLop = getNameLop(i.IDLop),
                            NS = i.NS
                        });
                    }
                }
                else
                {
                    if (i.NameSV.Contains(Name))
                    {
                        listSV.Add(new SV_View
                        {
                            MSSV = i.MSSV,
                            NameSV = i.NameSV,
                            Gender = i.Gender,
                            NameLop = getNameLop(i.IDLop),
                            NS = i.NS
                        });
                    }
                }
            }
            return listSV;
        }

        public string getNameLop(int s)
        {
            foreach(LSH i in GetAllLSH_BLL())
            {
                if (s == i.ID_Lop) return i.NameLop;
            }    
            return " ";
        }

        public List<SV> GetListSVView(int ID_Lop, string Name)
        {
            List<SV> listSV = new List<SV>();
            foreach (SV i in GetAllSV_BLL())
            {
                if (Name == null)
                {
                    if (i.IDLop == ID_Lop)
                    {
                        listSV.Add(i);
                    }
                }
                else
                {
                    if (i.NameSV.Contains(Name))
                    {
                        listSV.Add(i);
                    }
                }
            }
            return listSV;
        }

        public bool sosanhMSSV(string msss)
        {

            List<SV> li = new List<SV>();
            li = GetAllSV_BLL();
            if (li.Count == 0) return false;
            foreach (SV i in li)
            {
                if (i.MSSV == msss) return true;
            }

            return false;
        }


        public SV getSVbyMSSV(string mss)
        {
            SV s = new SV();
            foreach (SV i in GetAllSV_BLL())
            {

                if (mss == i.MSSV)
                {
                    s = i;
                }
            }
            return s;
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

    }

}
