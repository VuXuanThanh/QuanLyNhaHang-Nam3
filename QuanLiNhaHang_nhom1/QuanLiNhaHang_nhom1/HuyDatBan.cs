using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class HuyDatBan : Form
    {
        public BLL bll = new BLL();
        public HuyDatBan()
        {
            InitializeComponent();
            
        }
        //public static Control[] abc = splitContainer2.Panel2.Controls.OfType<CheckBox>();
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Regex rx = new Regex(@"^(0|\+84)\d{9}");

            if (rx.IsMatch(comboBox1.Text))
            {

                DataTable dt = BLL.getDiningTableExixs(comboBox1.Text);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MaKH.Text = row["MaKH"].ToString();
                    TenKH.Text = row["TenKH"].ToString();
                    DiaChi.Text = row["DiaChi"].ToString();
                    //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                    NgayGiaNhap.Text = row["NgayGiaNhap"].ToString();
                    dateTimePicker1.Text = row["ThoiGianDat"].ToString();
                    dateTimePicker2.Text = row["ThoiGianTra"].ToString();
                    label2.Text = row["MaBan"].ToString()+"  ";
                    Bancanxoa.DataSource = dt;
                    Bancanxoa.DisplayMember = "MaBan";
                    
                }
                else
                {
                    String et = "";


                    MaKH.Text = "";
                    TenKH.Text = "";
                    DiaChi.Text = "";
                    //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                    NgayGiaNhap.Text = "";
                    dateTimePicker2.Text = "";
                    dateTimePicker1.Text = "";
                    label2.Text = "";
                    Bancanxoa.DisplayMember = "";

                }


            }
            else
            {
                String et = "";


                MaKH.Text = "";

                TenKH.Text = "";
                DiaChi.Text = "";
                //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                NgayGiaNhap.Text = "";
                dateTimePicker2.Text = "";
                dateTimePicker1.Text = "";
                label2.Text = "";
                Bancanxoa.DisplayMember = "";
            }

        }

        private void HuyDatBan_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bll.DeleteDatBan(MaKH.Text);
            var result=MessageBox.Show("Bạn đã Hủy đặt bàn với khách hàng " + TenKH.Text,"Hủy thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Close();
            }
            Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
