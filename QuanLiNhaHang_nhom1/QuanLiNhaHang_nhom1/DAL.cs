﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang_nhom1
{
   public class DAL
    {
        
        public static SqlConnection connect()
        {
            //update conString(folow local server sql)
            string conString = @"Data Source=DESKTOP-BBUJIFK;Initial Catalog=QuanLiNhaHang_nhom1;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            return con;
        }

        public static DataTable getTable(string sql)
        {
            SqlConnection con = DAL.connect();
            SqlDataAdapter adap = new SqlDataAdapter(sql,con);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }

        public static void executeNonQuery(string sql)
        {
            SqlConnection con = DAL.connect();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Dispose();
            con.Close();
        }
    }
}
