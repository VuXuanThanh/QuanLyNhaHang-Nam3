using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace QuanLiNhaHang_nhom1
{
    public partial class frmMain : Form
    {
        private static System.Timers.Timer timer;
        

        public frmMain()
        {
            InitializeComponent();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            
                 
                
                
                
            
        }
    
        private  void OntimeEvent(Object source,System.Timers.ElapsedEventArgs e)
        {
            int x = button1.Location.X;
            while (button1.Location.X < 500)
            {
                x += 1;
                button1.Location = new Point(x, button1.Location.Y);
            }
        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQLNCC_Click(object sender, EventArgs e)
        {
            frmDMNhaCC frmNCC = new frmDMNhaCC();
            frmNCC.ShowDialog();
        }

        private void mnuQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            frmBanAn datban = new frmBanAn();
            datban.ShowDialog();
            //hiển thị đặt bàn
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HuyDatBan datBan = new HuyDatBan();
            datBan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
