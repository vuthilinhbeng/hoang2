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
    public class BUS_NhanVien
    {
        DAT_NhanVien dnn = new DAT_NhanVien();
        public DataTable getNhanVien()
        {
            return dnn.getNhanVien();
        }
        public DataTable TimKiemNhanVien(MD_NhanVien mdnn)
        {
            return dnn.TimKiemNhanVien(mdnn);
        }
        public bool Them(MD_NhanVien mdnn)
        {
            return dnn.Them(mdnn);
        }
        public bool Sua(MD_NhanVien mdnn)
        {
            return dnn.Sua(mdnn);
        }
        public bool Xoa(MD_NhanVien mdnn)
        {
            return dnn.Xoa(mdnn);
        }
        public bool TimKiem(MD_NhanVien mdnn)
        {
            return dnn.TimKiem(mdnn);
        }

        public DataTable Load_next()
        {
            return dnn.Load_next();
        }

        public DataTable Load_prev()
        {
            return dnn.Load_prev();
        }
    }
}
