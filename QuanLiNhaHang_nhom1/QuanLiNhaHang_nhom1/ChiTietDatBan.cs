using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
    public partial class ChiTietDatBan : Form
    {
        
        public static BLL bll = new BLL();
        public static String maban { get; set; }

        
        public ChiTietDatBan(String MaBan,DataTable ListCustomer)
        {
            InitializeComponent();

            maban = MaBan;
            loadDataGirdView(ListCustomer, dataGridView1);
            label1.Text ="Bàn số "+ MaBan;
            label1.ForeColor=Color.DarkBlue;
           
            
            
        }


        public DataTable ListCustomersDiningTable = bll.getCustomerDininedTable(maban);


        private void button2_Click(object sender, EventArgs e)
        {
            var re=MessageBox.Show("Bạn có chắc muốn hủy đặt bàn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo
            if (radioButton1.Checked)
            {
                bll.insertCustomers(TenKH.Text, DiaChi.Text, SDT.Text, 0,DateTime.Today);

               // MessageBox.Show("insert Thành công với có làm thẻ tích lũy\n tiếp theo là insert Datban voi mã bàn và MaKH là:" + maban + MaKH.Text);

                bll.insertDATBAN(MaKH.Text,"BAN"+ maban, dateTimePicker1.Value, dateTimePicker2.Value);
                // MessageBox.Show("đã insert Datban voi ma ban la:" + maban);\
                
            }
            else if (radioButton2.Checked)
            {
                bll.insertCustomers(TenKH.Text, DiaChi.Text, SDT.Text, DateTime.Today);
               // MessageBox.Show("insert thành công với không làm thẻ tích lũy\n tiếp theo là insert Datban voi mã bàn và MaKH là:" + maban+MaKH.Text);
                bll.insertDATBAN(MaKH.Text, "BAN"+maban, dateTimePicker1.Value, dateTimePicker2.Value);
                //MessageBox.Show("đã insert Datban voi ma ban la:" + maban);
                
            }

            loadDataGirdView(ListCustomersDiningTable, dataGridView1);            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MaKH_TextChanged(object sender, EventArgs e)
        {

        }
        // thêm khách hàng khi khách hàng là khach mới(lần đầu vào nhà hàng hoặc khách hàng không muốn ghi điểm tích lũy)
        public void insertCustomerWithNotExixs()
        {

        }
        public void loadDataGirdView(DataTable dataListCustomers,DataGridView dataGridView)
        {
            dataGridView.DataSource = dataListCustomers;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private void SDT_KeyUp(object sender, KeyEventArgs e)
        {
            
            Regex rx = new Regex(@"^(0|\+84)\d{9}");

            if (rx.IsMatch(SDT.Text))
            {

                DataTable dt = BLL.getCustomerExixs(SDT.Text);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    MaKH.Text = row["MaKH"].ToString();
                    TenKH.Text = row["TenKH"].ToString();
                    DiaChi.Text = row["DiaChi"].ToString();
                    //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                    NgayGiaNhap.Text = row["NgayGiaNhap"].ToString();
                }
                else
                {
                    String et = "";


                    MaKH.Text = frmBanAn.getLastIndexCustomer(et);
                    TenKH.Text = "";
                    DiaChi.Text = "";
                    //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                    NgayGiaNhap.Text = "";
                }


            }
            else
            {
                String et = "";


                MaKH.Text = frmBanAn.getLastIndexCustomer(et);
                
                TenKH.Text = "";
                DiaChi.Text = "";
                //SoDiemTichLuy.Text = row["SoDiemTichLuy"].ToString();
                NgayGiaNhap.Text = "";
            }
            




        }

        private void ChiTietDatBan_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Value = frmBanAn.ThoiGianHen;
            
            String et="";
            



            MaKH.Text = frmBanAn.getLastIndexCustomer(et) ;
            NgayGiaNhap.Value = DateTime.Today;
            NgayGiaNhap.Enabled = false;
            dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
            dataGridView1.DataSource = ListCustomersDiningTable;
        }

        
    }
}
