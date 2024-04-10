using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThaiBaHung_0633_DACN
{
    public partial class frm_Main : Form
    {
        private frm_MonAn formMonAn;
        private frm_DanhMuc formDanhMuc;
        private frm_DatBan formDatBan;
        private frm_HoaDon formHoaDon;
        private frm_DangNhap formDangNhap;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void tấtCảMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMonAn == null || formMonAn.IsDisposed)
            {
                formMonAn = new frm_MonAn();
                formMonAn.Show();
            }
            else
            {
                formMonAn.BringToFront();
            }
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDanhMuc == null || formDanhMuc.IsDisposed)
            {
                formDanhMuc = new frm_DanhMuc();
                formDanhMuc.Show();
            }
            else
            {
                formDanhMuc.BringToFront();
            }
        }

        private void thôngTinBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDatBan == null || formDatBan.IsDisposed)
            {
                formDatBan = new frm_DatBan();
                formDatBan.Show();
            }
            else
            {
                formDatBan.BringToFront();
            }
        }

        private void hóaĐơnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formHoaDon == null || formHoaDon.IsDisposed)
            {
                formHoaDon = new frm_HoaDon();
                formHoaDon.Show();
            }
            else
            {
                formHoaDon.BringToFront();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (formDangNhap == null || formDangNhap.IsDisposed)
                {
                    formDangNhap = new frm_DangNhap();
                    formDangNhap.Show();
                }
                else
                {
                    formDangNhap.BringToFront();
                }
            }
            else
            {
            }
        }
    }
}