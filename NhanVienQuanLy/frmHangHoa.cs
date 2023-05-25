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
namespace NhanVienQuanLy
{
    public partial class frmHangHoa : Form
    {
        BUS_HangHoa bshh = new BUS_HangHoa();
 
        public frmHangHoa()
        {
            InitializeComponent();
        }
        public void clear()
        {
            tb_msp.Text = "";
            tb_tsp.Text = "";
            txt_mtt.Text = "";
            tb_soluong.Text = "";
            tb_gianhap.Text = "";
            tb_giaban.Text = "";
        }
        
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dgv_menu.DataSource = bshh.getHangHoa();
            cbb_danhmuc.DisplayMember = "NhomHang";
            cbb_danhmuc.ValueMember = "MaNhomHang";
            cbb_danhmuc.DataSource = bshh.getNhomHang();
        }

        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = 0;
            row_index = e.RowIndex;
            tb_msp.Text = dgv_menu.Rows[row_index].Cells[0].Value.ToString().Trim();
            tb_tsp.Text = dgv_menu.Rows[row_index].Cells[1].Value.ToString().Trim();
            txt_mtt.Text = dgv_menu.Rows[row_index].Cells[2].Value.ToString().Trim();
            cbb_danhmuc.Text = dgv_menu.Rows[row_index].Cells[3].Value.ToString().Trim();
            tb_soluong.Text = dgv_menu.Rows[row_index].Cells[4].Value.ToString().Trim();
            tb_gianhap.Text = dgv_menu.Rows[row_index].Cells[5].Value.ToString().Trim();
            tb_giaban.Text = dgv_menu.Rows[row_index].Cells[6].Value.ToString().Trim();
        }

        private void bt_them_Click_2(object sender, EventArgs e)
        {
            if (tb_msp.Text != "" && tb_tsp.Text != "" && tb_soluong.Text != "" && tb_giaban.Text != "" && txt_mtt.Text != "")
            {
                MD_HangHoa mdhh = new MD_HangHoa(tb_msp.Text, tb_tsp.Text, txt_mtt.Text, cbb_danhmuc.Text, tb_soluong.Text, tb_gianhap.Text, tb_giaban.Text);
                if (bshh.Them(mdhh))
                {
                    MessageBox.Show("Thêm Thành Công");
                    dgv_menu.DataSource = bshh.getHangHoa();
                }
                else
                {
                    MessageBox.Show("Thêm không Thành Công!!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin!!!");
            }
            clear();
        }

        private void bt_timkiem_Click_2(object sender, EventArgs e)
        {
            if (tb_tsp.Text != "")
            {
                MD_HangHoa mdhh = new MD_HangHoa(tb_msp.Text, tb_tsp.Text, txt_mtt.Text, cbb_danhmuc.Text, tb_soluong.Text, tb_gianhap.Text, tb_giaban.Text);
                dgv_menu.DataSource = bshh.TimKiemHangHoa(mdhh);
            }
            else
            {
                MessageBox.Show("Nhập Đầy ĐỦ Thông Tin!!");
            }
        }

        private void bt_sua_Click_2(object sender, EventArgs e)
        {
            if (tb_msp.Text != "" && tb_tsp.Text != "" && tb_soluong.Text != "" && tb_giaban.Text != "" && txt_mtt.Text != "")
            {

                MD_HangHoa mdhh = new MD_HangHoa(tb_msp.Text, tb_tsp.Text, txt_mtt.Text, cbb_danhmuc.Text, tb_soluong.Text, tb_gianhap.Text, tb_giaban.Text);
                if (bshh.Sua(mdhh))
                {
                    MessageBox.Show("Sửa Thành Công!!!");
                    dgv_menu.DataSource = bshh.getHangHoa();
                }
                else
                {
                    MessageBox.Show("Sửa Không Thành Công!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Tên Sản Phẩm Cần Tìm!!");
            }
            clear();
        }

        private void bt_xoa_Click_2(object sender, EventArgs e)
        {
            if (tb_msp.Text != "" && tb_tsp.Text != "" && tb_soluong.Text != "" && tb_giaban.Text != "" && txt_mtt.Text != "")
            {

                MD_HangHoa mdhh = new MD_HangHoa(tb_msp.Text, tb_tsp.Text, txt_mtt.Text, cbb_danhmuc.Text, tb_soluong.Text, tb_gianhap.Text, tb_giaban.Text);
                if (bshh.Xoa(mdhh))
                {
                    MessageBox.Show("Xóa Thành Công!!!");
                    dgv_menu.DataSource = bshh.getHangHoa();
                }
                else
                {
                    MessageBox.Show("Xóa Không Thành Công!!!");
                }
            }
            else
            {
                MessageBox.Show("Nhập Đầy ĐỦ Thông Tin!!");
            }
            clear();
        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            dgv_menu.DataSource = bshh.getHangHoa();
        }

        private void bt_prev_Click_2(object sender, EventArgs e)
        {
            dgv_menu.DataSource = bshh.Load_prev();
        }

        private void bt_next_Click_2(object sender, EventArgs e)
        
        {
            dgv_menu.DataSource = bshh.Load_next();
        }
    }
}
