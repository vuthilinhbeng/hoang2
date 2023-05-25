using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL
{
    public class DAT_LoaiBaoCao:Db_connect
    {
        public DataTable getBaoCao()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaHangHoa,TenHangHoa,MieuTa,NhomHang,SoLuong FROM HangHoa", _conn);
            DataTable dt_HangHoabb = new DataTable();
            da.Fill(dt_HangHoabb);
            return dt_HangHoabb;
        }
        public DataTable getNhomBaoCao()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DanhMucChungTu", _conn);
            DataTable dt_dmrHangHoa = new DataTable();
            da.Fill(dt_dmrHangHoa);
            return dt_dmrHangHoa;
        }
    }
}
