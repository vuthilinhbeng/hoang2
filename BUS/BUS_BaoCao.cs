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
    public class BUS_BaoCao
    {
        DAT_LoaiBaoCao dbh = new DAT_LoaiBaoCao();
       
        public DataTable getBaoCao()
        {
            return dbh.getBaoCao();
        }
        public DataTable getNhomBaoCao()
        {
            return dbh.getNhomBaoCao();
        }
   
    }
}
