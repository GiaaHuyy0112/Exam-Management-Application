using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCNPM
{
    public partial class DoiThongTinAdmin : Form
    {
        cla_crud crud = new cla_crud();
        DangNhapAdmin dnAdmin;

        public DoiThongTinAdmin()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            Boolean check = crud.ExceData("UPDATE Admin SET matKhauAdmin=N'" + txtPass.Text + "' WHERE tenAdmin=N'" + txtAcc.Text + "'");
            if (check == true)
            {
                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công");
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập Không Đúng");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn sẽ trở lại trang đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Hide();
                dnAdmin = new DangNhapAdmin();
                dnAdmin.Show();
            }
        }

        private void CbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
