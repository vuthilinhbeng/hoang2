using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BUS;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace NhanVienQuanLy
{
    public partial class frmDangNhap : Form
    {
        frmMain frm;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FDA1KTE;Initial Catalog=taphoabalinh;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adap;
        public frmDangNhap(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        BUS_NguoiDUng bng = new BUS_NguoiDUng();
        MD_NguoiDung mdnd = new MD_NguoiDung();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToShortTimeString();
            lb_date.Text = DateTime.Now.ToShortDateString();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_dangnhap_Click_1(object sender, EventArgs e)
        {
            mdnd.sTaiKhoan = tb_taikhoan.Text;
            mdnd.sMatKhau = tb_matkhau.Text;
            string getuser = bng.CheckLogic(mdnd);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "requeid_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE Taikhoan='" + tb_taikhoan.Text.ToString() + "'AND MatKhau='" + tb_matkhau.Text.ToString() + "'", con);
                adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                Regex abc = new Regex("[a-z-0-9]");
                if (dt.Rows.Count > 0)
                {
                    var amr = dt.Rows[0].Field<string>("Admin");
                    if (amr.Trim() == "y")
                    {
                        if (cc_admin.Checked == true)
                        {
                            MessageBox.Show("Chào mừng bạn đăng nhập băng quyền Nhân Viên Quản Lý!");
                            this.Hide();
                            frm.enabled_menu();
                           
                        }
                        else
                        {
                            MessageBox.Show("Bạn là Nhân Viên Quản Lý nhưng không check vào ô. Mời bạn đăng nhập lại!");
                            //this.Hide();
                            //frm.NhanVienBanHang();
                            con.Close();
                            
                        }
                    }
                    else
                    {
                        if (cc_admin.Checked == true)
                        {
                            MessageBox.Show("Bạn không phải là Nhân Viên Quản Lý bỏ check vào đăng nhập lại");
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Chào mừng Nhân Viên Bán Hàng!!!");
                            this.Hide();
                            frm.NhanVienBanHang();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
