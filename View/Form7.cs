using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT03_102190100_NguyenDoVuong.DTO;
using BT03_102190100_NguyenDoVuong.BLL;

namespace BT03_102190100_NguyenDoVuong.View
{
    public partial class Form7 : Form
    {
        public string MSSVf { get; set; }

        public delegate void Del(int ID_Lop, string Name);
        public Del d1 { get; set; }


        public void funDataSV(string msd)
        {
            txtMSSV.ReadOnly = true;
            txtMSSV.Enabled = false;

            SV s = BLL_QLSV.Instance.getSVbyMSSV(msd);
            txtMSSV.Text = s.MSSV;
            txtNameSV.Text = s.NameSV;
            rdFemale.Checked = !s.Gender;
            cbbChonlop.SelectedIndex = s.IDLop - 1;
            dateTimePicker1.Value = s.NS;
        }

        
        public Form7(string mssv = "")
        {
            MSSVf = mssv;
            InitializeComponent();
            SetCBB();
            cbbChonlop.SelectedIndex = 0;

        }
        public void SetCBB()
        {

            foreach (LSH i in BLL_QLSV.Instance.GetAllLSH_BLL())
            {
                cbbChonlop.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop,
                });

            }

        }

        private void btOK_Click(object sender, EventArgs e)
        {          
            try
            {
                SV s = new SV
                {
                    MSSV = txtMSSV.Text,
                    NameSV = txtNameSV.Text,
                    Gender = rdMale.Checked,
                    IDLop = ((CBBItem)cbbChonlop.SelectedItem).Value,
                    NS = dateTimePicker1.Value
                };

                if (MSSVf == "" && (BLL_QLSV.Instance.sosanhMSSV(txtMSSV.Text)))// dùng 2 cái để so sánh
                {MessageBox.Show("sinh vien nhap vao da bi trung");
                    
                }
                else { BLL_QLSV.Instance.ExecuteDB_BLL(s);
                    d1(0, "");
                    this.Close(); 
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }

           
        }
       
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
