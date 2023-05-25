using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class DAT_HangHoa:Db_connect
    {
        public SqlDataAdapter da;
        private DataTable dt;
        public DataSet ds;
        int pageNumber = 0;
        int pageList = 15;

        public DataTable getHangHoa()
        {
            da = new SqlDataAdapter("SELECT MaHangHoa,TenHangHoa,MieuTa,NhomHang,SoLuong,DonGiaNhap,DonGiaBan FROM HangHoa", _conn);
            dt = new DataTable();
            da.Fill(pageNumber, pageList, dt);
            return dt;
        }
        public DataTable getNhomHang()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DanhMucNhomHang", _conn);
            DataTable dt_dmHangHoa = new DataTable();
            da.Fill(dt_dmHangHoa);
            return dt_dmHangHoa;
        }
        public DataTable TimKiemHangHoa(MD_HangHoa mdhh)
        {
            string Sql = string.Format("SELECT MaHangHoa,TenHangHoa,MieuTa,NhomHang,SoLuong,DonGiaNhap,DonGiaBan FROM HangHoa WHERE TenHangHoa Like N'%{0}%'", mdhh.sTenSanPham);
            SqlCommand cmd = new SqlCommand(Sql, _conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt_tkHangHoa = new DataTable();
            da.Fill(dt_tkHangHoa);
            return dt_tkHangHoa;


        }
        public bool Them(MD_HangHoa mdhh)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("INSERT INTO HangHoa(MaHangHoa,TenHangHoa,MieuTa,NhomHang,SoLuong,DonGiaNhap,DonGiaBan) VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", mdhh.sMaSanPham, mdhh.sTenSanPham, mdhh.sMieuTa, mdhh.sTenNhomHang, mdhh.sSoLuong, mdhh.sGiaNhap, mdhh.sGiaBan);
                SqlCommand cmd = new SqlCommand(Sql,_conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool TimKiem(MD_HangHoa mdhh)
        {

            _conn.Open();
            string Sql = string.Format("SELECT * FROM HangHoa WHERE TenHangHoa Like N'@tenhanghoa%'", mdhh.sMaSanPham, mdhh.sTenSanPham, mdhh.sMieuTa, mdhh.sTenNhomHang, mdhh.sSoLuong, mdhh.sGiaNhap, mdhh.sGiaBan);
            SqlCommand cmd = new SqlCommand(Sql, _conn);
            cmd.Parameters.AddWithValue("@tenhanghoa", mdhh.sTenSanPham);
            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
            {
                return false;
            }
        }
        public bool Sua(MD_HangHoa mdhh)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("UPDATE HangHoa SET TenHangHoa=N'{0}',MieuTa=N'{1}',SoLuong=N'{2}',DonGiaNhap=N'{3}',DonGiaBan=N'{4}' WHERE MaHangHoa=N'{5}'", mdhh.sTenSanPham, mdhh.sMieuTa, mdhh.sSoLuong, mdhh.sGiaNhap, mdhh.sGiaBan, mdhh.sMaSanPham);
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
        public bool Xoa(MD_HangHoa mdhh)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("DELETE FROM HangHoa WHERE MaHangHoa='{0}'", mdhh.sMaSanPham);
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
        public DataTable Load_next()
        {
            int nextPage = pageNumber + dt.Rows.Count;
            dt = new DataTable();
            da.Fill(nextPage, pageList, dt);
            pageNumber = nextPage;
            if (dt.Rows.Count != pageList)
            {
                pageNumber = nextPage + dt.Rows.Count;
            }

            return dt;
        }

        public DataTable Load_prev()
        {
            int nextPage = (pageNumber - (dt.Rows.Count + pageList)) < pageList ? 0 : (pageNumber - (dt.Rows.Count + pageList));
            dt = new DataTable();
            da.Fill(nextPage, pageList, dt);
            pageNumber = nextPage;
            if (dt.Rows.Count != pageList)
            {
                pageNumber = nextPage + dt.Rows.Count;
            }
            return dt;
        }
    }
}
