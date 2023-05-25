using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Windows.Forms;

namespace DAL
{
    public class Db_connect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-FDA1KTE;Initial Catalog=taphoabalinh;Integrated Security=True");
        
        public class SqlConnectionData
        {
            // Tạo chuỗi kết nối cơ sở dữ liệu
            public static SqlConnection Connect()
            {
                string strcon = @"Data Source=DESKTOP-FDA1KTE;Initial Catalog=taphoabalinh;Integrated Security=True";

                SqlConnection conn = new SqlConnection(strcon); // khởi tạo connect
                return conn;
            }
        }
        public static string CheckLogicDTO(MD_NguoiDung mdnd)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", mdnd.sTaiKhoan);
            command.Parameters.AddWithValue("@pass", mdnd.sMatKhau);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
        public void ResponsiveDtg(DataGridView dtg)
        {
            dtg.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}