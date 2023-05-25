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
    public class BUS_HangHoa
    {
        DAT_HangHoa dhhh = new DAT_HangHoa();

        public DataTable getHangHoa()
        {
            return dhhh.getHangHoa();
        }
        public DataTable getNhomHang()
        {
            return dhhh.getNhomHang();
        }
        public DataTable TimKiemHangHoa(MD_HangHoa hh)
        {
            return dhhh.TimKiemHangHoa(hh);
        }
        public bool Them(MD_HangHoa hh)
        {
            return dhhh.Them(hh);
        }
        public bool Sua(MD_HangHoa hh)
        {
            return dhhh.Sua(hh);
        }
        public bool Xoa(MD_HangHoa hh)
        {
            return dhhh.Xoa(hh);
        }
        public bool TimKiem(MD_HangHoa hh)
        {
            return dhhh.TimKiem(hh);
        }
        public DataTable Load_next()
        {
            return dhhh.Load_next();
        }

        public DataTable Load_prev()
        {
            return dhhh.Load_prev();
        }
    }
}
