using System;
using System.Collections.Generic;
using System.Text;

namespace BT03_102190100_NguyenDoVuong.DTO
{
    class CBBItem
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
