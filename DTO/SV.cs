using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03_102190100_NguyenDoVuong.DTO
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public int IDLop { get; set; }
        public DateTime NS { get; set; }

        public static bool CompareName(SV o1, SV o2)
        {
            if (String.Compare(o1.NameSV, o2.NameSV) > 0)
                return true;
            else return false;
        }
        public static bool CompareMSSV(SV o1, SV o2)
        {
            if (String.Compare(o1.MSSV, o2.MSSV) > 0)
                return true;
            else return false;
        }
        public static bool CompareIDLop(SV o1, SV o2)
        {
            if (o1.IDLop > o2.IDLop)
                return true;
            else return false;
        }
        public static bool CompareNS(SV o1, SV o2)
        {
            if (DateTime.Compare(o1.NS, o2.NS) > 0)
                return true;
            else return false;
        }
        public static bool CompareGender(SV o1, SV o2)
        {
            if (String.Compare(o1.Gender.ToString(), o2.Gender.ToString()) > 0)
                return true;
            else return false;
        }
    }
}
