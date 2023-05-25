
namespace NhanVienQuanLy
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_khohang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_nhanvien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_banhang = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_baocao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_dangnhap = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_khohang,
            this.toolStripSeparator1,
            this.ts_nhanvien,
            this.toolStripSeparator3,
            this.ts_banhang,
            this.toolStripSeparator2,
            this.ts_baocao,
            this.toolStripSeparator4,
            this.ts_dangnhap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(130, 906);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_khohang
            // 
            this.ts_khohang.AutoSize = false;
            this.ts_khohang.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_khohang.Image = ((System.Drawing.Image)(resources.GetObject("ts_khohang.Image")));
            this.ts_khohang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_khohang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_khohang.Name = "ts_khohang";
            this.ts_khohang.Size = new System.Drawing.Size(127, 65);
            this.ts_khohang.Text = "Hàng Hóa";
            this.ts_khohang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_khohang.Click += new System.EventHandler(this.ts_khohang_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // ts_nhanvien
            // 
            this.ts_nhanvien.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_nhanvien.Image = ((System.Drawing.Image)(resources.GetObject("ts_nhanvien.Image")));
            this.ts_nhanvien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_nhanvien.Name = "ts_nhanvien";
            this.ts_nhanvien.Size = new System.Drawing.Size(127, 73);
            this.ts_nhanvien.Text = "Nhân Viên";
            this.ts_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_nhanvien.Click += new System.EventHandler(this.ts_nhanvien_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
            // 
            // ts_banhang
            // 
            this.ts_banhang.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_banhang.Image = ((System.Drawing.Image)(resources.GetObject("ts_banhang.Image")));
            this.ts_banhang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_banhang.Name = "ts_banhang";
            this.ts_banhang.Size = new System.Drawing.Size(127, 73);
            this.ts_banhang.Text = "Bán Hàng";
            this.ts_banhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_banhang.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // ts_baocao
            // 
            this.ts_baocao.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_baocao.Image = ((System.Drawing.Image)(resources.GetObject("ts_baocao.Image")));
            this.ts_baocao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_baocao.Name = "ts_baocao";
            this.ts_baocao.Size = new System.Drawing.Size(127, 73);
            this.ts_baocao.Text = "Báo Cáo";
            this.ts_baocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_baocao.Click += new System.EventHandler(this.ts_baocao_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(127, 6);
            // 
            // ts_dangnhap
            // 
            this.ts_dangnhap.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("ts_dangnhap.Image")));
            this.ts_dangnhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_dangnhap.Name = "ts_dangnhap";
            this.ts_dangnhap.Size = new System.Drawing.Size(127, 73);
            this.ts_dangnhap.Text = "Đăng Nhâp";
            this.ts_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_dangnhap.Click += new System.EventHandler(this.ts_dangnhap_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(130, 884);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1196, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1326, 906);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Cửa Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_khohang;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_nhanvien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_baocao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_dangnhap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ts_banhang;
    }
}