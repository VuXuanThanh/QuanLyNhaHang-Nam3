using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class ChiTietDatBan_nhieuBan_cs : Form
    {
        BLL bll = new BLL();
        
        public ChiTietDatBan_nhieuBan_cs(List<CheckBox> checkBoxes)
        {
            InitializeComponent();
            
            foreach (CheckBox checkBox in checkBoxes)
            {
                label1.Text += checkBox.Text + " ";
            }
        }
        private void ChiTietDatBan_nhieuBan_cs_Load(object sender, EventArgs e)
        {

            String Makh = "";
            MaKH.Text = frmBanAn.getLastIndexCustomer(Makh);
            ThoiGianDat.Value = frmBanAn.ThoiGianHen;
            
            ThoiGianTra.Value = ThoiGianDat.Value.AddHours(1);
        }
        //insert theo khách hàng theo từng bàn
        
        private void button1_Click(object sender, EventArgs e)
        {
            String str = label1.Text;
            String result = "";
            foreach (Char x in str.ToCharArray())
            {
                if (Char.IsDigit(x))
                {
                    result += x;
                }
            }
            Char[] Soban = result.ToCharArray();
            if (radioButton1.Checked)
            {
                bll.insertCustomers(TenKH.Text, DiaChi.Text, SDT.Text, 0, NgayGiaNhap.Value);
                
                foreach (Char i in Soban)
                {
                    //bll.insertDATBAN(MaKH.Text, "BAN" + i, ThoiGianDat.Value, ThoiGianTra.Value);
                    MessageBox.Show("BAN" + i);
                }
            }else if (radioButton2.Checked)
            {
                bll.insertCustomers(TenKH.Text, DiaChi.Text, SDT.Text, NgayGiaNhap.Value);
                foreach (Char i in Soban)
                {
                    //bll.insertDATBAN(MaKH.Text, "MaBan" + i, ThoiGianDat.Value, ThoiGianTra.Value);
                    MessageBox.Show("BAN" + i);
                }
            }


        }

    }
}
