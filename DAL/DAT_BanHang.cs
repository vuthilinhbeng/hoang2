using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
namespace DAL
{
    public class DAT_BanHang : Db_connect
    {
        public DataTable getBanHang()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM HangHoa", _conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public DataTable getPhieuBanBanHang(MD_BanHang mdbh)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM PhieuBanHang", _conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public DataTable getNhomHang()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DanhMucNhomHang", _conn);
            DataTable dt_dmHangHoa = new DataTable();
            da.Fill(dt_dmHangHoa);
            return dt_dmHangHoa;
        }
        public bool Them(MD_BanHang mdbh)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("INSERT INTO PhieuBanHang(MaHangHoa,TenHangHoa,MieuTa,SoLuong,DonGiaBan,NgayThanhToan,ThanhToan) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}',N'{6}')",mdbh.sMaSanPham,mdbh.sMieuTa, mdbh.sTenSanPham, mdbh.sSoLuong, mdbh.sGiaBan, mdbh.sNgayXuat, mdbh.sThanhTien);
                SqlCommand cmd = new SqlCommand(Sql, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable TimKiemBanHang(MD_BanHang mdbh)
        {
            string Sql = string.Format("SELECT * FROM HangHoa WHERE TenHangHoa Like N'%{0}%'", mdbh.sTenSanPham);
            SqlCommand cmd = new SqlCommand(Sql, _conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt_tkdHangHoa = new DataTable();
            da.Fill(dt_tkdHangHoa);
            return dt_tkdHangHoa;


        }
        public bool TimKiem(MD_HangHoa mdhh)
        {
            _conn.Open();
            string Sql = string.Format("SELECT * FROM HangHoa WHERE TenHangHoa Like '@tenhanghoa%'", mdhh.sMaSanPham, mdhh.sTenSanPham, mdhh.sMieuTa, mdhh.sTenNhomHang, mdhh.sSoLuong, mdhh.sGiaNhap, mdhh.sGiaBan);
            SqlCommand cmd = new SqlCommand(Sql, _conn);
            cmd.Parameters.AddWithValue("@tenhanghoa", mdhh.sTenSanPham);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
            {
                return false;
            }

        }
    }
}
