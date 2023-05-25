using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVienQuanLy.Properties;
namespace NhanVienQuanLy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        public void enabled_menu()
        {
            ts_nhanvien.Enabled = true;
            ts_khohang.Enabled = true;
            ts_baocao.Enabled = true;
            ts_banhang.Enabled = false;
            ts_dangnhap.Text = "Đăng Xuất";
            ts_dangnhap.Image = Resources.outot;
        }

        public void NhanVienBanHang()
        {
            ts_nhanvien.Enabled = false;
            ts_khohang.Enabled = false;
            ts_baocao.Enabled = false;
            ts_banhang.Enabled = true;
            ts_dangnhap.Text = "Đăng Xuất";
            ts_dangnhap.Image = Resources.outot;
        } 
        public void disabled_menu()
        {
            ts_nhanvien.Enabled = false;
            ts_khohang.Enabled = false;
            ts_baocao.Enabled = false;
            ts_banhang.Enabled = false;
            ts_dangnhap.Image = Resources.login;
        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ts_khohang_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmHangHoa());

        }

        private void ts_nhanvien_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new fmNhanVien());
        }

        private void ts_dangnhap_Click(object sender, EventArgs e)
        {
            if(ts_dangnhap.Text == "Đăng Nhập")
            {
                closeForm();
                showFrm(new frmDangNhap(this));
            }
            else
            {
                closeForm();
                disabled_menu();
                ts_dangnhap.Text = "Đăng Nhập";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }

        private void ts_baocao_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmBaoCao());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmBanHang());
        }
    }
}
