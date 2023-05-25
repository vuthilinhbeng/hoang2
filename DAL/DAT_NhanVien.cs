using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAT_NhanVien:Db_connect
    {
        public SqlDataAdapter da;
        private DataTable dt;
        public DataSet ds;
        int pageNumber = 0;
        int pageList = 3;

        public DataTable getNhanVien()
        {
            da = new SqlDataAdapter("SELECT * FROM NhanVien", _conn);
            dt = new DataTable();
            da.Fill(pageNumber, pageList, dt);
            return dt;
        }
        public DataTable TimKiemNhanVien(MD_NhanVien mdnn)
        {
            string Sql = string.Format("SELECT * FROM NhanVien WHERE TenNhanVien Like N'%{0}%'",mdnn.sTenNhanVien);
            SqlCommand cmd = new SqlCommand(Sql, _conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt_tkfHangHoa = new DataTable();
            da.Fill(dt_tkfHangHoa);
            return dt_tkfHangHoa;
        }
        public bool Them(MD_NhanVien mdnn)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("INSERT INTO NhanVien(MaNhanVien,TenNhanVien,GioiTinh,DiaChi,SoDienThoai,CMND,NgaySinh,Email,IMG) VALUES(N'{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}','{7}', @image)", mdnn.sMaNhanVien, mdnn.sTenNhanVien,mdnn.sGioiTinh, mdnn.sDiaChi, mdnn.sSoDienThoai, mdnn.sCMDD, mdnn.sNgaySinh, mdnn.sEmail);
                SqlCommand cmd = new SqlCommand(Sql, _conn);
                cmd.Parameters.AddWithValue("@image", mdnn.sIMG);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool Sua(MD_NhanVien mdnn)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("UPDATE NhanVien SET TenNhanVien=N'{0}',GioiTinh=N'{1}',DiaChi=N'{2}',SoDienThoai='{3}',CMND='{4}',NgaySinh='{5}', Email=N'{6}',IMG=@image WHERE MaNhanVien=N'{7}'", mdnn.sTenNhanVien, mdnn.sGioiTinh, mdnn.sDiaChi, mdnn.sSoDienThoai, mdnn.sCMDD, mdnn.sNgaySinh, mdnn.sEmail, mdnn.sMaNhanVien, mdnn.sIMG);
                SqlCommand cmd = new SqlCommand(Sql, _conn);
                cmd.Parameters.AddWithValue("@image", mdnn.sIMG);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool Xoa(MD_NhanVien mdnn)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("DELETE FROM NhanVien WHERE MaNhanVien=N'{0}'", mdnn.sMaNhanVien);
                SqlCommand cmd = new SqlCommand(Sql, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool TimKiem(MD_NhanVien mdnn)
        {
            try
            {
                _conn.Open();
                string Sql = string.Format("SELECT * FROM NhanVien WHERE TenNhanVien Like '%@tennhanvien%'", mdnn.sMaNhanVien, mdnn.sTenNhanVien, mdnn.sGioiTinh, mdnn.sDiaChi, mdnn.sSoDienThoai, mdnn.sCMDD, mdnn.sNgaySinh, mdnn.sEmail, mdnn.sIMG);
                SqlCommand cmd = new SqlCommand(Sql, _conn);
                cmd.Parameters.AddWithValue("@tennhanvien", mdnn.sTenNhanVien);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
