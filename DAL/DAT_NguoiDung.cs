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
    public class DAT_NguoiDung : Db_connect
    {
        public string CheckLogic(MD_NguoiDung mdnd)
        {
            string info = CheckLogicDTO(mdnd);
            return info;
        }
    }
}
