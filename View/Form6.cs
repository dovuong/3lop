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
using BT03_102190100_NguyenDoVuong.DAL;
using BT03_102190100_NguyenDoVuong.BLL;

namespace BT03_102190100_NguyenDoVuong.View
{
    public partial class Form6 : Form
    {
        // List<LSH> listItem;
        //List<SV> l;

        public Form6()
        {
            InitializeComponent();
            SetCBB();
            cbbLSH.SelectedIndex = 0;
            cbbSort.SelectedIndex = 0;
        }




        public void SetCBB()
        {

            cbbLSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach (LSH i in BLL_QLSV.Instance.GetAllLSH_BLL())
            {
                cbbLSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop,
                });

            }

        }

        public void Show(int ID_Lop, string Name)
        {
            dataGridView1.DataSource = BLL_QLSV.Instance.GetListSV_View(ID_Lop, Name);
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["MSSV"].Visible = false;
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbbLSH.SelectedItem).Value, "");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.d1 += new Form7.Del(Show);
            f.Show();

        }


        private void btEdit_Click(object sender, EventArgs e)
        {
            
            Form7 f;
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 1)
            {

                foreach (DataGridViewRow i in r)
                {
                    f = new Form7(i.Cells["MSSV"].Value.ToString());           
                    f.funDataSV(i.Cells["MSSV"].Value.ToString());
                    f.d1 += new Form7.Del(Show);
                    f.Show();
                }
                
            }
            else 
                if(r.Count > 1 ) 
                    MessageBox.Show("Vui lòng chỉ chọn một sinh viên để sửa!!");
                else MessageBox.Show("không có sinh viên nào được chọn!!");


        }



        private void btSort_Click(object sender, EventArgs e)
        {

            List<SV_View> l1 = BLL_QLSV.Instance.GetListSV_View(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);

            // all ở BLL
            switch (cbbSort.SelectedIndex+1)
            {
                
                case 1:
                    BLL_QLSV.Instance.SortSV_BLL(l1, SV_View.CompareName);
                    break;
                case 2:
                    BLL_QLSV.Instance.SortSV_BLL(l1, SV_View.CompareGender);
                    break;
                case 3:
                    BLL_QLSV.Instance.SortSV_BLL(l1, SV_View.CompareNameLop);
                    break;
                case 4:
                    BLL_QLSV.Instance.SortSV_BLL(l1, SV_View.CompareNS);
                    break;
                default:
                    break;
            }
            dataGridView1.DataSource = l1;
        }


        private void btDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 0)
            {
                foreach (DataGridViewRow i in r)
                {
                    BLL_QLSV.Instance.DelSV_BLL(i.Cells["MSSV"].Value.ToString());
                }
                dataGridView1.DataSource = BLL_QLSV.Instance.GetListSV(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbbLSH.SelectedItem).Value, txtSearch.Text);
        }

    }
}
