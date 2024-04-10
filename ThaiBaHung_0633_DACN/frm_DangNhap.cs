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
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG lopdungchung = new LOPDUNGCHUNG();

        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

            string sql = "select COUNT(*) from TAIKHOAN where TENTAIKHOAN = '" + txt_tk.Text + "' and MATKHAU = '" + txt_mk.Text + "'";
            int kq = Convert.ToInt32(lopdungchung.ExecuteScalar(sql));
            if (kq >= 1)
            {
                frm_Main form1 = new frm_Main();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!");
                txt_tk.Clear();
                txt_mk.Clear();

            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
