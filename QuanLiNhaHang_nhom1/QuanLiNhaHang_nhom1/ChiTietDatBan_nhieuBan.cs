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

        }

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
            MessageBox.Show(result);
        }
    }
}
