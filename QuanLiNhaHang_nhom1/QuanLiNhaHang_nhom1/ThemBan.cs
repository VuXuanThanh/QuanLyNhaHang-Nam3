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
    public partial class ThemBan : Form
    {
        BLL bll = new BLL();
        public ThemBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bll.insertDanhSachDatBan(textBox1.Text);
            var mess=MessageBox.Show("Bạn đã thêm bàn thành công", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mess==DialogResult.OK)
            {
                Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThemBan_Load(object sender, EventArgs e)
        {
            DataTable dt=bll.getDanhSachBan();
            int index = dt.Rows.Count +1;
            textBox1.Text ="Bàn " +index.ToString();
        }
    }
}
