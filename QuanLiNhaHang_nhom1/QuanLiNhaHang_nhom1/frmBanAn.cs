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
    public partial class frmBanAn : Form
    {
        public static BLL bll = new BLL();
        public static DateTime ThoiGianHen { get; set; }
        
        public static List<Button> list = new List<Button>();
        public frmBanAn()
        {
            InitializeComponent();
            AppencaCheckboxToButton();
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm  tt";
            ThoiGianHen = dateTimePicker1.Value;
            

        }


        private void frmBanAn_Load(object sender, EventArgs e)
        {
            
            checkBox1_CheckedChanged(sender, e);
        }

        private void dgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getDetailDiningTable(String MaBan, DataTable listWithTable_ID)
        {

            ChiTietDatBan chiTietDatBan = new ChiTietDatBan(MaBan, listWithTable_ID);
            chiTietDatBan.ShowDialog();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            DataTable listCustomer = bll.getCustomerDininedTable("6");
            getDetailDiningTable("6",listCustomer);
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("26");
            getDetailDiningTable("26",listCustomer);
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("27");
            getDetailDiningTable("27",listCustomer);
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("28");
            getDetailDiningTable("28",listCustomer);
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("29");
            getDetailDiningTable("29",listCustomer);
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("30");
            getDetailDiningTable("30",listCustomer);
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("17");
            getDetailDiningTable("17",listCustomer);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
                 DataTable listCustomer = bll.getCustomerDininedTable("18");
            getDetailDiningTable("18",listCustomer);
        }

        private void button19_Click_1(object sender, EventArgs e) { 


                 DataTable listCustomer = bll.getCustomerDininedTable("19");
        getDetailDiningTable("19",listCustomer);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("20");
            getDetailDiningTable("20",listCustomer);
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("21");
            getDetailDiningTable("21",listCustomer);
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("22");
            getDetailDiningTable("22",listCustomer);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("23");
            getDetailDiningTable("23",listCustomer);
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("24");
            getDetailDiningTable("24",listCustomer);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("9");
            getDetailDiningTable("9",listCustomer);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("10");
            getDetailDiningTable("10",listCustomer);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("11");
            getDetailDiningTable("11",listCustomer);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("12");
            getDetailDiningTable("12",listCustomer);
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("13");
            getDetailDiningTable("13",listCustomer);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("14");
            getDetailDiningTable("14",listCustomer);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("15");
            getDetailDiningTable("15",listCustomer);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("16");
            getDetailDiningTable("16",listCustomer);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("5");
            getDetailDiningTable("5",listCustomer);
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("25");
            getDetailDiningTable("25",listCustomer);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("7");
            getDetailDiningTable("7",listCustomer);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("8");
            getDetailDiningTable("8",listCustomer);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("3");
            getDetailDiningTable("3",listCustomer);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("4");
            getDetailDiningTable("4",listCustomer);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             DataTable listCustomer = bll.getCustomerDininedTable("2");
            getDetailDiningTable("2",listCustomer);
        }

        

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime data= dateTimePicker1.Value;
            DataTable dt = bll.getListTable(data);
            String list = "";
            
            if (comboBox2.SelectedIndex.Equals(1))
            {
                foreach (Button btn in splitContainer1.Panel1.Controls.OfType<Button>())
                {
                    


                        btn.Enabled = true;
                        //btn.Name==
                    
                }

                foreach (DataRow row in dt.Rows)
                {
                  int a=row["MaBan"].ToString().Length;
                    list ="button"+ row["MaBan"].ToString()[a-1].ToString();
                    //for (int i = 0; i < splitContainer1.Panel1.Controls.OfType<Button>().Count(); i++)
                    //{
                        foreach (Button btn in splitContainer1.Panel1.Controls.OfType<Button>())
                        {
                            if (btn.Name == list)
                            {
                                

                                btn.Visible = false;
                                
                            }
                        }



                    

                }
            }
            if (comboBox2.SelectedIndex.Equals(0))
            {
                foreach (Button btn in splitContainer1.Panel1.Controls.OfType<Button>())
                {
                    


                        btn.Visible = true;
                        //btn.Name==
                    
                }
                foreach (DataRow row in dt.Rows)
                {
                    int a = row["MaBan"].ToString().Length;
                    list = "button" + row["MaBan"].ToString()[a - 1].ToString();
                    //for (int i = 0; i < splitContainer1.Panel1.Controls.OfType<Button>().Count(); i++)
                    //{
                        


                    //}
                    foreach(Button btn in splitContainer1.Panel1.Controls.OfType<Button>())
                    {
                        if (btn.Name == list)
                        {
                            btn.Enabled = false;
                        }
                    }

                }
            }
           // MessageBox.Show(.ToString());
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = bll.getListTable(dateTimePicker1.Value);
            DataRow row = dataTable.Rows[0];
            MessageBox.Show(row["MaBan"].ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBox2_SelectedValueChanged(sender, e);
            
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //splitContainer2.Panel1.Visible = true;
                splitContainer2.Panel2Collapsed = true;
            }
            else
            {

                splitContainer2.Panel1Collapsed = true;
                //splitContainer2.Panel2.Visible = true;
            }
        }

        private void AppencaCheckboxToButton()
        {
            foreach(CheckBox check in splitContainer2.Panel1.Controls.OfType<CheckBox>())
            {
                check.Appearance = Appearance.Button;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable listCustomer = bll.getCustomerDininedTable("1");
            getDetailDiningTable("1", listCustomer);
        }



        // lấy thông tin từ bàn truyền sang form chi tiết đặt bàn




    }
}
