using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
namespace BUS
{
    public class BUS_NguoiDUng
    {
        DAT_NguoiDung  tkAccess = new DAT_NguoiDung();
        public string CheckLogic(MD_NguoiDung mdnd)
        {
            // Kiểm tra nghiệp vụ
            if (mdnd.sTaiKhoan == "")
            {
                return "requeid_taikhoan";
            }

            if (mdnd.sMatKhau == "")
            {
                return "requeid_password";
            }

            string info = tkAccess.CheckLogic(mdnd);
            return info;
        }
    }
   
}
