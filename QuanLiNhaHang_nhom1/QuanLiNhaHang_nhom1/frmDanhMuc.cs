﻿using System;
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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        private void loadDataGridView()
        {
            DataTable table = new DataTable();
            table = BLL.showDanhMuc();
            dgvDanhMuc.DataSource = table;
        }
        public string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        private void resetValue()
        {
            txtMaDM.Text = "";
            txtTenDanhMuc.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDanhMuc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục");
                    return;
                }
                txtMaDM.Text = NonUnicode(txtTenDanhMuc.Text.ToUpper()).Replace(" ", "");
                BLL.insertDanhMuc(txtMaDM.Text, txtTenDanhMuc.Text);
                loadDataGridView();
                resetValue();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaDM.Text = dgvDanhMuc.Rows[d].Cells[0].Value.ToString();
            txtTenDanhMuc.Text = dgvDanhMuc.Rows[d].Cells[1].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            resetValue();
            txtTenDanhMuc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
                return;
            }
            BLL.updateDanhMuc(txtMaDM.Text, txtTenDanhMuc.Text);
            loadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text=="")
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }
            if(MessageBox.Show("Xác nhận xóa?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BLL.deleteDanhMuc(txtMaDM.Text);
                loadDataGridView();
                resetValue();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
