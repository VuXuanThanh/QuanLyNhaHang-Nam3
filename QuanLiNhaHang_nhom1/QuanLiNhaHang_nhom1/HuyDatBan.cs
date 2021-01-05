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
    public partial class HuyDatBan : Form
    {
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
            DataTable dt=BLL.SDTKH();
           
            comboBox1.DataSource = dt;

            comboBox1.DroppedDown = true;
        }

        private void HuyDatBan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
