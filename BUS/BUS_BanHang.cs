using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_BanHang
    {
        DAT_BanHang dbh = new DAT_BanHang();
        public bool Them(MD_BanHang mdbb)
        {
            return dbh.Them(mdbb);
        }
        public DataTable getBanHang()
        {
            return dbh.getBanHang();
        }
        public DataTable getPhieuBanBanHang(MD_BanHang mdbh)
        {
            return dbh.getPhieuBanBanHang(mdbh);
        }
        public DataTable getNhomHang()
        {
            return dbh.getNhomHang();
        }
        public bool TimKiem(MD_HangHoa mdhh)
        {
            return dbh.TimKiem(mdhh);
        }
        public DataTable TimKiemBanHang(MD_BanHang mdbh)
        {
            return dbh.TimKiemBanHang(mdbh);
        }

    }
}
