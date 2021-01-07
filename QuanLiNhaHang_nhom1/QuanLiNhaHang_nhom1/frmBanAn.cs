using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiNhaHang_nhom1
{
    public partial class frmBanAn : Form
    {
        public String Path = Directory.GetCurrentDirectory();
        public static BLL bll = new BLL();
        public static DateTime ThoiGianHen { get; set; }
        
        public static List<Button> list = new List<Button>();
        public frmBanAn()
        {
            InitializeComponent();
           
            loadPanle(splitContainer2);
            AppencaCheckboxToButton();
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm  tt";

            dateTimePicker1.Value = DateTime.Today;

        }
       
        public void loadPanle(SplitContainer splitContainer1)
        {
             DataTable dt = bll.getDanhSachBan();

            int x = 0;
            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                x = i;
                
                Button button = new Button();
                
                CheckBox checkBox = new CheckBox();
                button.Text = "Bàn "+i.ToString();
                button.Name =i.ToString();
                button.Image = Image.FromFile(Path + @"\Images\bandoi.jpg");
                checkBox.Image= Image.FromFile(Path + @"\Images\bandoi.jpg");
                button.TextAlign = ContentAlignment.TopCenter;
                checkBox.TextAlign = ContentAlignment.TopCenter;
                checkBox.Text = "Bàn "+i.ToString();
                checkBox.Name = i.ToString();

                button.Size = new Size(150, 100);

                checkBox.Size = new Size(150, 100);
                checkBox.Appearance = Appearance.Button;

                if (i % 3 == 1)
                {

                    //button.Location = new Point(37,50*i);
                    button.Left = 0;
                    
                    button.Top = 40*x;

                    checkBox.Left = 0;
                    checkBox.Top = 40*x;

                    splitContainer1.Panel1.Controls.Add(button);
                    splitContainer1.Panel2.Controls.Add(checkBox);
                    button.Click += new EventHandler(this.button_Click);
                   
                    
                }
                if (i % 3 == 2)
                {
                    //button.Location = new Point(290, 50  * i-(i-1)*50);
                    button.Left = 150;
                    button.Top = 40*(x-1);
                    checkBox.Left = 150;
                    checkBox.Top = 40* (x - 1);


                    splitContainer1.Panel2.Controls.Add(checkBox);
                    splitContainer1.Panel1.Controls.Add(button);
                    button.Click += new EventHandler(this.button_Click);
                    
                }
                if (i % 3 == 0)
                {
                    //button.Location = new Point(290, 50  * i-(i-1)*50);
                    button.Left = 300;
                    button.Top = 40*(x-2);
                    checkBox.Left = 300;
                    checkBox.Top = 40*(x-2);


                    splitContainer1.Panel2.Controls.Add(checkBox);
                    splitContainer1.Panel1.Controls.Add(button);
                    button.Click += new EventHandler(this.button_Click);
                    
                }


            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (sender) as Button;
            String str=button.Name;
          
            DataTable listCustomer = bll.getCustomerDininedTable(str);
            getDetailDiningTable(str, listCustomer);
            
        }

        public  void frmBanAn_Load(object sender, EventArgs e)
        {
           
           
        }

       

        
        public void getDetailDiningTable(String MaBan, DataTable listWithTable_ID)
        {
            
            
            ChiTietDatBan chiTietDatBan = new ChiTietDatBan(MaBan, listWithTable_ID);
            chiTietDatBan.Size = new Size(900, Screen.GetWorkingArea(this).Height);
            
            chiTietDatBan.ShowDialog();
            Close();
        }
        // hàm lấy ra mã khách hàng cuối cùng
        public static String getLastIndexCustomer(String MaKHLastIndexof)
        {
            DataTable customers = BLL.showKH();
            int index = customers.Rows.Count;

            if (index > 0)
            {
                DataRow row = customers.Rows[index - 1];

                MaKHLastIndexof = (int.Parse(row["BaseID"].ToString()) + 1).ToString();
                return "KH" + MaKHLastIndexof;
            }
            else
            {
                return "KH1";
            }
        }

       

        
        public  void EnableButton(DateTime data)
        {
           
            DataTable dt = bll.getListTable(data);
            String list = "";



            foreach (Button btn in splitContainer2.Panel1.Controls.OfType<Button>())
            {
                //MessageBox.Show("đã đi qua đây");
                btn.Enabled = true;
            }
            foreach (DataRow row in dt.Rows)
            {

                list = row["MaBan"].ToString()[row["MaBan"].ToString().Length - 1].ToString();

                foreach (Button btn in splitContainer2.Panel1.Controls.OfType<Button>())
                {

                    if (btn.Name == list)
                    {

                        btn.Enabled = false;

                    }
                }

            }
        }
        public void EnableCheckbox(DateTime data)
        {
            DataTable dt = bll.getListTable(data);
            String list = "";



            foreach (CheckBox check in splitContainer2.Panel2.Controls.OfType<CheckBox>())
            {
                
                check.Enabled = true;
            }
            foreach (DataRow row in dt.Rows)
            {

                list = row["MaBan"].ToString()[row["MaBan"].ToString().Length - 1].ToString();

                foreach (CheckBox check in splitContainer2.Panel2.Controls.OfType<CheckBox>())
                {

                    if (check.Name == list)
                    {

                        check.Enabled = false;

                    }
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var x=MessageBox.Show("Bạn có chắc không muốn đặt bàn nữa?", "Bạn có muốn thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x==DialogResult.Yes)
            {
                Close();
            }
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            foreach(CheckBox checkBox in splitContainer2.Panel2.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    checkBoxes.Add(checkBox);
                }
            }
            if (checkBoxes.Count <2)
            {
                MessageBox.Show("Bạn chọn ít nhất là 2 bàn");
            }
            else
            {
                ChiTietDatBan_nhieuBan_cs chiTietDatBan_NhieuBan_Cs = new ChiTietDatBan_nhieuBan_cs(checkBoxes);
                chiTietDatBan_NhieuBan_Cs.Size = new Size(500, Screen.GetWorkingArea(this).Height);
                chiTietDatBan_NhieuBan_Cs.ShowDialog();
            }

            Close();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //comboBox2_SelectedValueChanged(sender, e);
            ThoiGianHen = dateTimePicker1.Value;
            EnableButton(ThoiGianHen);
            EnableCheckbox(ThoiGianHen);




        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnThem.Visible = true;
                
                splitContainer2.Panel1Collapsed = true;
            }
            else
            {
                btnThem.Visible = false;
                splitContainer2.Panel2Collapsed = true;
                
            }
        }

        private void AppencaCheckboxToButton()
        {
           
            foreach(CheckBox check in splitContainer2.Panel1.Controls.OfType<CheckBox>())
            {
                check.Appearance = Appearance.Button;
            }
        }

        
    }
}
