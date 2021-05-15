using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190100_NguyenDoVuong.DTO
{
    class SV_View
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public string NameLop { get; set; }
        public DateTime NS { get; set; }

        public static bool CompareName(SV_View o1, SV_View o2)
        {
            if (string.Compare(o1.NameSV, o2.NameSV) > 0)
                return true;
            else return false;
        }
        public static bool CompareMSSV(SV_View o1, SV_View o2)
        {
            if (string.Compare(o1.MSSV, o2.MSSV) > 0)
                return true;
            else return false;
        }
        public static bool CompareNameLop(SV_View o1, SV_View o2)
        {
            if (string.Compare(o1.NameLop, o2.NameLop) > 0)
                return true;
            else return false;
        }
        public static bool CompareNS(SV_View o1, SV_View o2)
        {
            if (DateTime.Compare(o1.NS, o2.NS) > 0)
                return true;
            else return false;
        }
        public static bool CompareGender(SV_View o1, SV_View o2)
        {
            if (String.Compare(o1.Gender.ToString(), o2.Gender.ToString()) > 0)
                return true;
            else return false;
        }
    }
}
