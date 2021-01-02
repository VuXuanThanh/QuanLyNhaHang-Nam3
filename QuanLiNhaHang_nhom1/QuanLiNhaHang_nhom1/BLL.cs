using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiNhaHang_nhom1
{
    public class BLL
    {
        //NHACC
        public static DataTable showNCC()
        {
           string sql = "select * from NHACUNGCAP";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }

        public static bool testNCC(string maNCC)
        {
            string sql = "select MaNCC from NHACUNGCAP where MaNCC='" + maNCC + "'";
            DataTable table = DAL.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        //xóa thuộc tính mã nhà cung cấp (mã nhà cung cấp tự tăng)
        public static void insertNCC( string tenNCC, string diaChi, string dienThoai)
        {
            string sql ="insert into NHACUNGCAP(TenNCC,DiaChi,DienThoai) values("+ "'N'" + tenNCC + "',N'" + diaChi + "','" + dienThoai + "')";
            DAL.executeNonQuery(sql);
        }

        public static void updateNCC(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            string sql = "update NHACUNGCAP set TenNCC =N'" + tenNCC + "', DiaChi=N'" + diaChi + "', DienThoai='" + dienThoai + "' where MaNCC ='"+maNCC+"'";
            DAL.executeNonQuery(sql);
        }

        public static void deleteNCC(string maNCC)
        {
            string sql = "delete from NHACUNGCAP where MaNCC='" + maNCC + "'";
            DAL.executeNonQuery(sql);
        }
        public static DataTable show1NCC(string maNCC)
        {
            string sql = "select * from NHACUNGCAP where MaNCC ='"+maNCC+"'";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }
        // NHANVIEN
        public static DataTable showNV()
        {
            string sql = "select * from NHANVIEN";
            DataTable tblNV = new DataTable();
            tblNV = DAL.getTable(sql);
            return tblNV;
        }
        //xóa thuộc tính Mã nhân viên(mã nhân viên tăng tự động)
        public static void insertNV( string TenNV, string GioiTinh, DateTime ngaySinh, string DiaChi, String DienThoai, float luongThang, string chucVu)
        {
           
            string sql = "insert into NHANVIEN(TenNV,GioiTinh,NgaySinh,DiaChi,DienThoai,LuongThang,ChucVu) values (" + "'N'" + TenNV + "',N'" + GioiTinh + "','" + ngaySinh + "',N'" + DiaChi + "','" + DienThoai + "','" + luongThang + "',N'" + chucVu + "')";
            DAL.executeNonQuery(sql);
        }
        public static bool testNV(string maNV)
        {
            string sql = "select MaNV from NHANVIEN where MaNV='" + maNV + "'";
            DataTable table = DAL.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void updateNV(string MaNV, string TenNV, string GioiTinh, DateTime ngaySinh, string DiaChi, String DienThoai, float luongThang, string chucVu)
        {
            string sql = "update NHANVIEN set TenNV=N'" + TenNV + "', GioiTinh=N'" + GioiTinh + "', DiaChi=N'" + DiaChi + "'" +
                ", DienThoai='" + DienThoai + "', LuongThang='" + luongThang + "', ChucVu=N'" + chucVu + "' where MaNV='"+MaNV+"'";
            DAL.executeNonQuery(sql);
        }
        public static void deleteNV(string MaNV)
        {
            string sql = "delete from NHANVIEN where MaNV='" + MaNV + "'";
            DAL.executeNonQuery(sql);
        }
        public static DataTable show1NV(string MaNV)
        {
            string sql = "select * from NHANVIEN where MaNV ='" + MaNV + "'";
            DataTable tblNCC = new DataTable();
            tblNCC = DAL.getTable(sql);
            return tblNCC;
        }
        // KHACHHANG
        public static DataTable showKH()
        {
            string sql = "select * from KHACHHANG";
            DataTable tblKH = new DataTable();
            tblKH = DAL.getTable(sql);
            return tblKH;
        }
        /*string makh, string tenkh, string diachi, string dienthoai, string sodiemTL*/


        //function select table by time

        public DataTable getListTable(DateTime ThoiGianDatBan)
        {
            String sql = "select MaBan from DATBAN where Datediff(hour,ThoiGianTra,'" + ThoiGianDatBan+"')>0";
            //String sql2 = "select MaBan from DATBAN where Datediff(hour, '12/24/2020 9:00:00 AM', '12/24/2020 9:00:00 AM') = 0";
            //String sql = "select Datediff(hour,ThoiDiemKetThuc,'"+ThoiGianDatBan+"') as time1 from DATBAN";
            DataTable dt = new DataTable();
            SqlConnection con = DAL.connect();
            con.Open();
            //SqlCommand cmd = new SqlCommand(sql,con);

            //SqlDataReader dataReader = cmd.ExecuteReader();
            //while (dataReader.Read())
            //{

            //    dt.Rows.Add(dataReader.GetInt32(0).ToString());
            //}
            //dataReader.Close();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public DataTable getCustomerDininedTable(String MaBan)
        {
            DataTable dt = new DataTable();
            String sql = "select * from DATBAN where MaBan='BAN"+MaBan+"'";
            dt=DAL.getTable(sql);


            return dt;
        }
        public DataTable getTableWithCountChair(int CountChair)
        {
            String sql = "select BaseID from DANHSACHBAN where SoCho="+CountChair;
            DataTable dt = new DataTable();
            dt = DAL.getTable(sql);
            return dt;
        }
        //Thêm khách hàng mới và không muốn Lưu thông tin cá nhân(k làm thẻ tích điểm)
        public void insertCustomers(String TenKH,String DiaChi,String SDT,DateTime NgayGiaNhap)
        {
            
            String sql = "insert into KHACHHANG(TenKH,DiaChi,DienThoai,NgayGiaNhap) values('" + TenKH + "','" + DiaChi + "','" + SDT + "', CAST(GETDATE() as Date) )";
            DAL.executeNonQuery(sql);
        }

        //Thêm khách hàng mới và muốn làm thẻ tích lũy điểm
        public void insertCustomers(String TenKH, String DiaChi, String SDT,int SoDiemTichLuy, DateTime NgayGiaNhap)
            //khởi tạo khách hàng với điểm tích lũy bằng 0
        {
            String sql= "insert into KHACHHANG(TenKH,DiaChi,DienThoai,SoDiemTichLuy,NgayGiaNhap) values('" + TenKH + "','" + DiaChi + "','" + SDT + "',"+SoDiemTichLuy+",  CAST(GETDATE() as Date)  )";
            DAL.executeNonQuery(sql);
        }
        public void insertDATBAN(String MaKH,String MaBan,DateTime ThoiGianDat,DateTime ThoiGianTra)
        {
            String sql = "insert into DATBAN values('" + MaKH + "','" + MaBan + "','" + ThoiGianDat + "','" + ThoiGianTra + "')";
            DAL.executeNonQuery(sql);
        }

        


        //tìm kiếm khách hàng đã từng sử dụng dịch vụ của nhà hàng nhà hàng
        public DataTable getCustomerExixs(String SDT)
        {
            
                String sql = "select * from KHACHHANG where DienThoai='" + SDT + "'";
                DataTable dt = DAL.getTable(sql);
                return dt;
           
            
        }
    }
}
