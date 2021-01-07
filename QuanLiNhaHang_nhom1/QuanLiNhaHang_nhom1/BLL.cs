﻿using System;
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

        //get số đt khach hang
        public static DataTable SDTKH()
        {
            String sql = "select DienThoai from KHACHHANG";
            DataTable dt=DAL.getTable(sql);
            return dt;
        }
        /*string makh, string tenkh, string diachi, string dienthoai, string sodiemTL*/


        //function select table by time

        public DataTable getListTable(DateTime ThoiGianDatBan)
        {
            String sql = "select MaBan from DATBAN where Datediff(hour,ThoiGianTra,'" + ThoiGianDatBan+"')<0";
           
            DataTable dt = new DataTable();
            SqlConnection con = DAL.connect();
            con.Open();
            
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
            
            String sql = "insert into KHACHHANG(TenKH,DiaChi,DienThoai,NgayGiaNhap) values(N'" + TenKH + "',N'" + DiaChi + "','" + SDT + "', CAST(GETDATE() as Date) )";
            DAL.executeNonQuery(sql);
        }

        //Thêm khách hàng mới và muốn làm thẻ tích lũy điểm
        public void insertCustomers(String TenKH, String DiaChi, String SDT,int SoDiemTichLuy, DateTime NgayGiaNhap)
            //khởi tạo khách hàng với điểm tích lũy bằng 0
        {
            String sql= "insert into KHACHHANG(TenKH,DiaChi,DienThoai,SoDiemTichLuy,NgayGiaNhap) values(N'" + TenKH + "',N'" + DiaChi + "','" + SDT + "',"+SoDiemTichLuy+",  CAST(GETDATE() as Date)  )";
            DAL.executeNonQuery(sql);
        }
        public void insertDATBAN(String MaKH,String MaBan,DateTime ThoiGianDat,DateTime ThoiGianTra,int landat)
        {
            String sql = "insert into DATBAN values('" + MaKH + "','" + MaBan + "',"+landat+",'" + ThoiGianDat + "','" + ThoiGianTra + "')";
            DAL.executeNonQuery(sql);
        }

        public String getLatDatBan(String MaBan,String MaKH)
        {
            String sql = "select count(*) from DATBAN where MaKH='" + MaKH + "' and MaBan='" + MaBan + "'";
            String result=DAL.getValue(sql);
            return result;
        }


        //tìm kiếm khách hàng đã từng sử dụng dịch vụ của nhà hàng nhà hàng
        public static DataTable getCustomerExixs(String SDT)
        {
            
                String sql = "select * from KHACHHANG where DienThoai='" + SDT + "'";
                DataTable dt = DAL.getTable(sql);
                return dt;
           
            
        }
        public static DataTable getDiningTableExixs(String SDT)
        {
            String sql = "select * from KHACHHANG inner join DATBAN on KHACHHANG.MaKH=DATBAN.MaKH where DienThoai='"+SDT+"'";
            DataTable dt = DAL.getTable(sql);
            return dt;
        }
        public void DeleteDatBan(String MaKH)
        {
            String sql = "delete DATBAN where MaKH='" + MaKH + "'";
            DAL.executeNonQuery(sql);
        }

        public DataTable getDanhSachBan()
        {
            String sql = "select * from DANHSACHBAN";
            DataTable dt = DAL.getTable(sql);
            return dt;
            
        }

         public void insertDanhSachDatBan(String TenBan)
        {
            String sql = "insert into DANHSACHBAN(TenBan) values (N'" + TenBan + "')";
            DAL.executeNonQuery(sql);

        }

        //Bll của thành

        public static DataTable fillComboNV()//
        {
            string sql = "select MaNV, TenNV from NHANVIEN";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;

        }
        public static DataTable fillComboKH()
        {
            string sql = "select MaKH, TenKH from KHACHHANG";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static DataTable fillComboBan()
        {
            string sql = "select MaBan, TenBan from DANHSACHBAN";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static string showTenTheoMa(string ma)
        {
            string str;
            string sql = "Select TenNV from NHANVIEN where MaNV =N'" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showTenTheoMaKH(string ma)
        {
            string str;
            string sql = "Select TenKH from KHACHHANG where MaKH =N'" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showDienThoaiTheoMaKH(string ma)
        {
            string str;
            string sql = "select DienThoai from KHACHHANG where MaKH='" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showDiaChiTheoMaKH(string ma)
        {
            string str;
            string sql = "Select DiaChi from KHACHHANG where MaKH =N'" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static DataTable fillComboMonAn()
        {
            string sql = "select MaMon, TenMon from MONAN";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static string showTenTheoMaMon(string ma)
        {
            string str;
            string sql = "Select TenMon from MONAN where MaMon =N'" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showDonGiaTheoMaMon(string ma)
        {
            string str;
            string sql = "Select DonGia from MONAN where MaMon =N'" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        // hiển thị món ăn lên datagridview
        public static DataTable showMonAnTheoMaHoaDon(string ma)
        {
            DataTable table = new DataTable();
            string sql = "select MONAN.MaMon, TenMon, [MONAN].DonGia, SoLuong, GiamGia, (SoLuong*[MONAN].DonGia-SoLuong*[MONAN].DonGia*GiamGia/100) as ThanhTien from CHITIETHOADON inner join MONAN on CHITIETHOADON.MaMon = MONAN.MaMon where CHITIETHOADON.MaHD='" + ma + "'";
            table = DAL.getTable(sql);
            return table;
        }
        public static string showNgayXuatTheoHoaDon(string maHD)
        {
            string formatDate = "yyyy-MM-dd";
            string str;
            string sql = "Select format([NgayXuat],'" + formatDate + "') from HOADON where MaHD ='" + maHD + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showTongTienTheoHoaDon(string maHD)
        {
            string str;
            string sql = "select sum((DonGia*SoLuong)-(DonGia*SoLuong)*GiamGia/100) as TongTien from CHITIETHOADON where MaHD='" + maHD + "' group by MaHD";
            str = DAL.getValue(sql);
            return str;
        }
        public static string showMaNVTheoHoaDon(string ma)
        {
            string str;
            string sql = "select MaNV from HOADON where MaHD ='" + ma + "'";
            str = DAL.getValue(sql);
            return str;
        }
        // thêm hóa đơn
        public static void insertHD(string MaHD, DateTime ngayXuat, string tinhTrang, string MaNV, string MaKH)
        {
            string sql = "insert into HOADON values ('" + MaHD + "',N'" + ngayXuat + "',N'" + tinhTrang + "',N'" + MaNV + "','" + MaKH + "')";
            DAL.executeNonQuery(sql);
        }
        // thêm chitiethoadon
        public static void insertChiTietHD(string maHD, string maMon, int soLuong, float donGia, float giamGia, float thanhTien)
        {
            string sql;
            sql = "insert into CHITIETHOADON values('" + maHD + "','" + maMon + "','" + soLuong + "','" + donGia + "','" + giamGia + "', '" + thanhTien + "')";
            DAL.executeNonQuery(sql);
        }
        // kiểm tra trùng mã hóa đơn khi thêm
        public static bool testHoaDon(string maHD)
        {
            string sql = "select MaHD from HOADON where MaHD='" + maHD + "'";
            DataTable table = DAL.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        /*   //Kiểm tra trùng mã món ăn khi thêm vào hóa đơn
           public static bool testMonAnTrongHoaDon(string maMon, string maHD)
           {
               string sql = "select MaMon from CHITIETHOADON where MaMon='" + maMon + "' and MaHD='"+maHD+"'";
               DataTable table = DAL.getTable(sql);
               if (table.Rows.Count > 0)
                   return true;
               else return false;
           }*/
        /*  public static void deleteHoaDon(string maHD)// xóa 1 row trong HOADON
          {
              string sql = "delete from HOADON where MaHD='"+maHD+"'";
              DAL.executeNonQuery(sql);
          }*/
        public static void deleteChiTietHoaDon(string maHD)
        {
            string sql = "delete from CHITIETHOADON where MaHD='" + maHD + "'";
            DAL.executeNonQuery(sql);
        }
        // lấy thông tin hóa đơn để xuất ra file exel
        public static DataTable showThongTinHoaDonDeXuatRaExel(string ma)
        {
            DataTable table = new DataTable();
            string sql = "select HOADON.MaHD, NgayXuat,sum(SoLuong*CHITIETHOADON.DonGia-SoLuong*CHITIETHOADON.DonGia*GiamGia/100) as TongTien, KHACHHANG.TenKH, KHACHHANG.DienThoai, KHACHHANG.DiaChi, NHANVIEN.TenNV " +
                "from HOADON inner join NHANVIEN on HOADON.MaNV = NHANVIEN.MaNV inner join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH inner join CHITIETHOADON on CHITIETHOADON.MaHD = HOADON.MaHD " +
                "where HOADON.MaHD='" + ma + "' group by HOADON.MaHD,NgayXuat, KHACHHANG.TenKH, KHACHHANG.DienThoai, KHACHHANG.DiaChi, NHANVIEN.TenNV";
            table = DAL.getTable(sql);
            return table;
        }
        // lấy thông tin món ăn để xuất ra file exel
        public static DataTable showMonAnDeXuatRaFileExel(string ma, DateTime ngayXuat)
        {
            DataTable table = new DataTable();
            //  string sql = "select TenMon, SoLuong, [MONAN].DonGia, GiamGia, (SoLuong*[MONAN].DonGia-SoLuong*[MONAN].DonGia*GiamGia/100) as ThanhTien from CHITIETHOADON inner join MONAN on CHITIETHOADON.MaMon = MONAN.MaMon where CHITIETHOADON.MaHD='" + ma + "'";
            string sql = "select CHITIETGOIMON.MaMon, TenMon,sum(SoLuong) as SoLuong,MONAN.DonGia,sum(CHITIETGOIMON.GiamGia) as TongGiamGia,sum(SoLuong*MONAN.DonGia-SoLuong*MONAN.DonGia*GiamGia/100) as ThanhTien  " +
               "from CHITIETGOIMON inner join MONAN on CHITIETGOIMON.MaMon=MONAN.MaMon " +
               "inner join GOIMON on GOIMON.IDGoiMon = CHITIETGOIMON.IDGoiMon where MaKH='" + ma + "' and ThoiGian='" + ngayXuat + "' group by CHITIETGOIMON.MaMon, TenMon,MONAN.DonGia";
            table = DAL.getTable(sql);
            return table;
        }
        public static string showTongTienTheoMaHD(string maHD)
        {
            string sql = "select sum(ThanhTien) from CHITIETHOADON where MaHD='" + maHD + "'";
            string str = DAL.getValue(sql);
            return str;
        }
        // tìm hóa đơn
        /*        public static DataTable showThongTinHoaDonTimKiem(string chuoiTim, bool flag)
                {
                    DataTable table = new DataTable();
                    string sql = "select HOADON.MaHD, NgayXuat, MaNV, MaKH, sum((DonGia*SoLuong)-(DonGia*SoLuong)*GiamGia/100) as TongTien from HOADON " +
                        "inner join CHITIETHOADON on CHITIETHOADON.MaHD=HOADON.MaHD where 1=1 ";
                    if (flag)
                        sql += "and HOADON.MaHD like '%" + chuoiTim + "%'";
                    else
                        sql += "and MaKH like '%" + chuoiTim + "%'";

                    sql += "group by HOADON.MaHD, NgayXuat, MaNV, MaKH";
                    table = DAL.getTable(sql);
                    return table;
                } 
        */
        // NGUYENLIEU
        public static DataTable showNguyenLieu()
        {
            DataTable table = new DataTable();
            string sql = "select * from NGUYENLIEU";
            table = DAL.getTable(sql);
            return table;
        }
        public static void insertNguyenLieu(string maNL, string tenNL, DateTime ngayNhap, int hanSD, string dvTinh, int SLTon, string maNCC)
        {
            string sql = "insert into NGUYENLIEU values('" + maNL + "',N'" + tenNL + "','" + ngayNhap + "','" + hanSD + "',N'" + dvTinh + "','" + SLTon + "','" + maNCC + "')";
            DAL.executeNonQuery(sql);
        }
        public static DataTable fillComboMaNCC()
        {
            string sql = "select MaNCC, TenNCC from NHACUNGCAP";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }

        // GOIMON, CHITIETGOIMON
        public static DataTable showChiTietGoiMon(string maKH)
        {
            DataTable table = new DataTable();
            string sql = "select GOIMON.IDGoiMon, CHITIETGOIMON.MaMon, TenMon, SoLuong, CHITIETGOIMON.DonGia, GiamGia, (SoLuong*CHITIETGOIMON.DonGia-SoLuong*CHITIETGOIMON.DonGia*GiamGia/100) as ThanhTien " +
                "from CHITIETGOIMON inner join MONAN on CHITIETGOIMON.MaMon=MONAN.MaMon " +
                "inner join GOIMON on GOIMON.IDGoiMon = CHITIETGOIMON.IDGoiMon where MaKH='" + maKH + "'";
            table = DAL.getTable(sql);
            return table;
        }
        public static DataTable showChiTietHoaDon(string maKH, DateTime ngayXuat)
        {
            DataTable table = new DataTable();
            string sql = "select CHITIETGOIMON.MaMon, TenMon,sum(SoLuong) as SoLuong,MONAN.DonGia,sum(CHITIETGOIMON.GiamGia) as TongGiamGia,sum(SoLuong*MONAN.DonGia-SoLuong*MONAN.DonGia*GiamGia/100) as ThanhTien  " +
                "from CHITIETGOIMON inner join MONAN on CHITIETGOIMON.MaMon=MONAN.MaMon " +
                "inner join GOIMON on GOIMON.IDGoiMon = CHITIETGOIMON.IDGoiMon where MaKH='" + maKH + "' and ThoiGian ='" + ngayXuat + "' group by CHITIETGOIMON.MaMon, TenMon,MONAN.DonGia";
            table = DAL.getTable(sql);
            return table;
        }
        public static string showTongTienTheoMaKH(string MaHD)
        {
            string str;
            string sql = "select sum(ThanhTien) as TongTien from CHITIETHOADON inner join HOADON on HOADON.MaHD=CHITIETHOADON.MaHD where MaKH='" + MaHD + "'";
            str = DAL.getValue(sql);
            return str;
        }
        // DANH MUC
        public static DataTable showDanhMuc()
        {
            DataTable table = new DataTable();
            string sql = "select * from DANHMUC";
            table = DAL.getTable(sql);
            return table;
        }
        public static void insertDanhMuc(string maDM, string tenDM)
        {
            string sql = "insert into DANHMUC values('" + maDM + "',N'" + tenDM + "')";
            DAL.executeNonQuery(sql);
        }
        public static void deleteDanhMuc(string maDM)
        {
            string sql = "delete from DANHMUC where MaDanhMuc='" + maDM + "'";
            DAL.executeNonQuery(sql);
        }
        public static void updateDanhMuc(string maDM, string tenDM)
        {
            string sql = "update DANHMUC set TenDanhMuc=N'" + tenDM + "' where MaDanhMuc='" + maDM + "'";
            DAL.executeNonQuery(sql);
        }

        //Order gọi món
        public static DataTable fillComboDanhMuc()
        {
            string sql = "select MaDanhMuc, TenDanhMuc from DANHMUC";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static DataTable showMaMon_TenMonTheoMadanhMuc(string tenDM)
        {
            string sql = "select MaMon, TenMon from MONAN inner join DANHMUC where TenDM='" + tenDM + "'";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static DataTable showMonAnTheoTenDanhMuc(string tenDM)
        {
            string sql = "select MaMon, TenMon from MONAN inner join DANHMUC on MONAN.MaDanhMuc = DANHMUC.MaDanhMuc where TenDanhMuc=N'" + tenDM + "'";
            DataTable table = new DataTable();
            table = DAL.getTable(sql);
            return table;
        }
        public static string showAnhTheoMaMon(string maMon)
        {
            string str;
            string sql = "select Anh from MONAN where MaMon='" + maMon + "'";
            str = DAL.getValue(sql);
            return str;
        }
        public static void insertGoiMon(string maKH, bool trangThai, DateTime thoiGian)
        {
            string sql = "insert into GOIMON values('" + trangThai + "','" + maKH + "','" + thoiGian + "')";
            DAL.executeNonQuery(sql);
        }
        public static string IDENT_CURRENT()
        {
            string tableName = "GOIMON";
            string sql = "select IDENT_CURRENT('" + tableName + "')";
            string str = DAL.getValue(sql);
            return str;
        }
        public static void insertChiTietGoiMon(string IDGoiMon, string maMon, int soLuong, float giamGia)
        {
            string sql = "set SET IDENTITY_INSERT CHITIETGOIMON on " +
                "insert into CHITIETGOIMON values('" + IDGoiMon + "','" + maMon + "'," + soLuong + "," + giamGia + ")" +
                " set SET IDENTITY_INSERT CHITIETGOIMON off;";
            DAL.executeNonQuery(sql);
        }

    }
}


